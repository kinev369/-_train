using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace пересдача_GUI
{
    delegate void Print();
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Print print = delegate ()
            {
                if (true)
                {
                    for (int i = 0; i < vag.cont.Count; i++)
                    {
                        vag.cont[i].Print();
                    }
                }
                else
                {
                    StreamWriter sw = new StreamWriter(@"2.txt", false, System.Text.Encoding.Default);

                    for (int i = 0; i < vag.cont.Count; i++)
                    {
                        sw.WriteLine(vag.cont[i].Print2());


                    }
                    sw.Close();
                }
            };*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
