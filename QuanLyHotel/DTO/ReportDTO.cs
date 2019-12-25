using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reportDTO
{
    public class ReportDTO
    {
        private string idrp;
        private string month;
        private string year;
        private float roomsum;
        private float servicesum;
        private Decimal costsum;

        public string IDRP { get => idrp; set => idrp = value; }
        public string MONTH { get => month; set => month = value; }
        public string YEAR { get => year; set => year = value; }
        public float ROOMSUM { get => roomsum; set => roomsum = value; }
        public float SERVICESUM { get => servicesum; set => servicesum = value; }
        public Decimal COSTSUM { get => costsum; set => costsum = value; }
    }
}
