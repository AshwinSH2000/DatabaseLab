using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public class customer
    {
        public string cname;
        public string pwd;
        public string uid;
        public string accno;
        public long bal;
        public class transaction
        {
            public int dd, mm, yy;
            public string cd;
            public double amount;
            public long trnacc;
            
        }
        public customer()
        {
            pwd = "mitictlab01";
            uid = "1234321";
            cname = "Ashwin S H";
            accno = "1324234254";
            bal = 2342;
            transaction a = new transaction();
            transaction b = new transaction();
            transaction c = new transaction();
            transaction d = new transaction();
            transaction e = new transaction();
        }
    }
            
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
