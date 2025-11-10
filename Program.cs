namespace NavigationOfSoltrianius;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        BackgroundMusic.StartMusic();
        //In the new file, don't use .cs to refer to the files.
        Application.Run(new Form1());
    }    
}