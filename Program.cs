using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace lab7
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           /* 
            using (hospitalEntities dbc = new hospitalEntities())
            {
                dbc.Database.Log = msg => Console.WriteLine(msg);
                dbc.Configuration.LazyLoadingEnabled = false;
                IQueryable<Doctor> seg1 = dbc.Doctors.Where(doct => doct.Phone.Contains("745321"));//.OrderBy(doct => doct.Name);
                //Console.WriteLine(seg1.Expression);
                //Console.WriteLine(seg1.ElementType.Name);
                foreach(Doctor item in seg1)
                {
                    Console.WriteLine($"{item.ID,-10}{item.Name,-20}{item.Phone,-20}{item.Visitings.Count, -20}");
                }
            }
            */
        }
    }
}
