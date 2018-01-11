namespace Server
{
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Program" />
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Defines the logsLocation
        /// </summary>
        private static string logsLocation = "\\Logs";

        /// <summary>
        /// Defines the orderLocation
        /// </summary>
        private static string orderLocation = "\\All_Saves";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            Application.Run(new Form1());
        }

        /// <summary>
        /// The Application_ApplicationExit
        /// </summary>
        /// <param name="sender">The <see cref="object"/></param>
        /// <param name="e">The <see cref="EventArgs"/></param>
        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            var date = DateTime.UtcNow.ToString(@"MM_dd_yyyy");
            try
            {
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + orderLocation))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(
                        Environment.SpecialFolder.Desktop)+ orderLocation);
                }
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    + orderLocation + string.Format("\\{0}.json", date), JsonConvert.SerializeObject(Form1.ListOfOrders));
            }
            catch (Exception ex)
            {
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    + orderLocation + logsLocation))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                        + orderLocation + logsLocation);
                }
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    + orderLocation + logsLocation + string.Format("\\Log_{0}", date), ex.ToString());
            }
        }
    }
}
