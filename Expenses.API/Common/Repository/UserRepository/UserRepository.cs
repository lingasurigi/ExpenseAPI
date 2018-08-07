using ExpenseAPI.Repository.UserRepository;
using ExpensesProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ExpenseAPI.Repository.UserRepository
{
    public class UserRepository : IUserRepository
    {
        Expenses_ExcelEntities _dbContext = new Expenses_ExcelEntities();

        public List<User> UsersList()
        {
           return _dbContext.Users.ToList();
        }


        public void SaveUser(User user)
        {
             user.CreatedBy = 1;
             user.CreatedDate = DateTime.Now;
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public User EditUser(int userId)
        {
            return _dbContext.Users.Where(wh => wh.UserId == userId).SingleOrDefault();
        }

        public void UpdateUser(User user)
        {
            user.UpdatedBy = 1;
            user.UpdatedDate = DateTime.Now;
            _dbContext.Entry(user).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
             var user = new User { UserId = userId };
            _dbContext.Entry(user).State = EntityState.Deleted;
            _dbContext.SaveChanges();
        }
    }
}