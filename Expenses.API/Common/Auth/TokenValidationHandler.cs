using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using ExpenseAPI.Common.Auth;

namespace ExpenseAPI
{
    internal class TokenValidationHandler : DelegatingHandler
    {
        private const string Secret = "db3OIsj+BXE9NZDy0t8W3TcNekrF+2d/1sFnWG4HnV8TZY30iTOdtVWJG8abWvB1GlOgJuQZdcF2Luqm/hccMw==";
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpStatusCode statusCode;
            string token;
            //determine whether a jwt exists or not  
            if (!TryRetrieveToken(request, out token))
            {
                statusCode = HttpStatusCode.Unauthorized;
                //allow requests with no token - whether a action method needs an authentication can be set with the claimsauthorization attribute  
                return base.SendAsync(request, cancellationToken);
            }
            try
            {
                SecurityToken securityToken;
                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                TokenValidationParameters validationParameters = new TokenValidationParameters()
                {
                    // Validate the JWT Audience (aud) claim  
                    ValidateAudience = true,
                    ValidAudience = "http://abc.com", //audienceConfig["Aud"],  
                    // Validate the JWT Issuer (iss) claim  
                    ValidateIssuer = true,
                    ValidIssuer = "http://abc.com", //audienceConfig["Iss"],  
                    // Validate the token expiry  
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    LifetimeValidator = this.LifetimeValidator,
                    // The signing key must match!  
                    ValidateIssuerSigningKey = true,
                    // IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(Secret)),  
                    IssuerSigningKey = new SymmetricSecurityKey(Convert.FromBase64String(Secret)),
                };
                //extract and assign the user of the jwt  

                //Thread.CurrentPrincipal = handler.ValidateToken(token, validationParameters, out securityToken);
                string username = "linga";
                Thread.CurrentPrincipal = JwtAuthentication.ValidateToken(token, out username); ;
                HttpContext.Current.User = Thread.CurrentPrincipal;
                return base.SendAsync(request, cancellationToken);
            }
            catch (SecurityTokenValidationException ex)
            {
                statusCode = HttpStatusCode.Unauthorized;
            }
            catch (Exception)
            {
                statusCode = HttpStatusCode.InternalServerError;
            }
            return Task<HttpResponseMessage>.Factory.StartNew(() => new HttpResponseMessage(statusCode) { });
        }
        private static bool TryRetrieveToken(HttpRequestMessage request, out string token)
        {
            token = null;
            IEnumerable<string> authzHeaders;
            if (!request.Headers.TryGetValues("authorization", out authzHeaders) || authzHeaders.Count() > 1)
            {
                return false;
            }
            var bearerToken = authzHeaders.ElementAt(0);
            token = bearerToken.StartsWith("Bearer ") ? bearerToken.Substring(7) : bearerToken;
            return true;
        }
        public bool LifetimeValidator(DateTime? notBefore, DateTime? expires, SecurityToken securityToken, TokenValidationParameters validationParameters)
        {
            if (expires != null)
            {
                if (DateTime.UtcNow < expires) return true;
            }
            return false;
        }
    }
}