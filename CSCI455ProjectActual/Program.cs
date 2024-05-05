namespace CSCI455ProjectActual
{
    internal static class Program
    {
        /// <summary>
        /// Public variables to be used across the system to see if 
        /// dark mode is activated or if it is a patient login
        /// </summary>
        public static Boolean dark = false;
        public static Boolean isPatient = false;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string fileName = "rawMessages/John_Doe.txt";
            try
            {
                using (FileStream fs = File.Create(fileName))
                {
                    // You can add content to the file here if needed
                    // For example:
                    byte[] content = System.Text.Encoding.UTF8.GetBytes(Properties.Resources.John_Doe);
                    fs.Write(content, 0, content.Length);
                }

            }
            catch { }
            Application.Run(new LoginPage());
        }
    }
}   