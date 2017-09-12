namespace Hangfire.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("Hangfire");

            using (var server = new BackgroundJobServer())
            {
                System.Console.WriteLine("Hangfire Server started. Press any key to exit...");
                System.Console.ReadKey();
            }
        }
        
    }
}
