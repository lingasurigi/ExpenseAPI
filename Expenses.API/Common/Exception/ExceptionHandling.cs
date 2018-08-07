using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace ExpensesProject.Common.Exception
{
    public class ExceptionHandling : IExceptionFilter
    {
        public Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, System.Threading.CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public bool AllowMultiple
        {
            get { throw new NotImplementedException(); }
        }
    }
}