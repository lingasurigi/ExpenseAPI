using ExpensesProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseAPI.Repository.UserRepository
{
    public interface IUserRepository
    {
        List<User> UsersList();
        void SaveUser(User user);
        User EditUser(int userId);
        void UpdateUser(User user);
        void DeleteUser(int userId);
    }
}
