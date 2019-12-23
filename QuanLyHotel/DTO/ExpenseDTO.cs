using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expenseDTO
{
    public class ExpenseDTO
    {
        private string ide;
        private string name;
        private string kind;
        private DateTime date;
        private Decimal cost;

        public string IDE { get => ide; set => ide = value; }
        public string NAME { get => name; set => name = value; }
        public string KIND { get => kind; set => kind = value; }
        public DateTime DATE { get => date; set => date = value; }
        public Decimal COST { get => cost; set => cost = value; }

    }