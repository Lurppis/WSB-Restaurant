using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Server
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
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            Application.Run(new Form1());
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            var date = DateTime.UtcNow.ToString(@"MM_dd_yyyy");
            try
           {
                File.WriteAllText(string.Format("C:\\Users\\marci\\Documents\\Project\\All_Saves\\{0}.json", date),JsonConvert.SerializeObject(Form1.ListOfOrders));
            }
            catch (Exception ex)
            {
                File.WriteAllText(string.Format("C:\\Users\\marci\\Documents\\Project\\All_Saves\\Logs\\Log_{0}", date), ex.ToString());
            }
        }
    }
}
