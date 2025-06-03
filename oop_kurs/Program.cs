namespace oop_kurs
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			MessageBox.Show("Петрунин Антон 23ВП2\nАвтобусный парк",
				   "",
				   MessageBoxButtons.OK,
				   MessageBoxIcon.Information);
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
			ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}