using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseAPI.Repository.Common
{
    public interface ICommonInterface<T>
    {
        string Create(T obj);
        T Retrieve(string key);
        void Update(T obj);
        void Delete(string key);
    }
}
