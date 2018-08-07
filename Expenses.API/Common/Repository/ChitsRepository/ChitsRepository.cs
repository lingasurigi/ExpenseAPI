using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpensesProject.Common.Repository.ChitsRepository
{
    public class ChitsRepository : IChitsRepository
    {
        Expenses_ExcelEntities _dbContext = new Expenses_ExcelEntities();

        public List<Chit> ChitsList()
        {
            return _dbContext.Chits.ToList();
        }
    }
}