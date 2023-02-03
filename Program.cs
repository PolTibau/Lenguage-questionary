using System.Security.Cryptography.X509Certificates;

namespace preguntes_anglès
{

    internal static class Program
    {
        
        [STAThread]
        static void Main()
        { 

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}