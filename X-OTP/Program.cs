namespace XOTP
{
    internal static class Program
    {
        private static Mutex mutex = new Mutex(true, "{FE440547-0E8F-4E61-B33A-BFA7E72E2DCE}");

        [STAThread]
        static void Main()
        {

            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());

                mutex.ReleaseMutex();
            }
        }
    }
}
