using expenseDAO;
using expenseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expenseBUS
{
    public class ExpenseBUS
    {
        private ExpenseDAO sDao;
        public ExpenseBUS()
        {
            sDao = new ExpenseDAO();
        }
        public bool add(ExpenseDTO pt)
        {
            bool re = sDao.add(pt);
            return re;
        }

        public bool delete(ExpenseDTO pt)
        {
            bool re = sDao.delete(pt);
            return re;
        }

        public bool edit(ExpenseDTO pt)
        {
            bool re = sDao.edit(pt);
            return re;
        }

        public List<ExpenseDTO> select()
        {
            return sDao.select();
        }
        public List<ExpenseDTO> selectNameService()
        {
            return sDao.selectNameService();
        }
        public List<ExpenseDTO> search(string Keyword)
        {
            return sDao.search(Keyword);
        }
        public List<ExpenseDTO> selectCost(string sKeyword)
        {
            return sDao.selectCost(sKeyword);
        }
    }
}
