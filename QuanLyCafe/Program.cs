using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
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
            Application.Run(new fQuanLyMay());
            //List<string> strs = new List<string>();
            //strs[0] = "aaa";
            //strs[1] = "bbb";
            //strs.Add("hehe");
            //Console.WriteLine(strs[2]);
        }
    }
}
