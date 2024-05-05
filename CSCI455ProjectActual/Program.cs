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
        public static Boolean fullscreen = false;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginPage());
    }
    }
}   