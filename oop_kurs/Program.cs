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
			MessageBox.Show("�������� ����� 23��2\n���������� ����",
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