namespace Directorio2024B
{
    internal static class Program
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

            MongoHelper mongo = new MongoHelper();

            // manda a llamar el metodo para conectarse a mONGO
            mongo.connectToMongoService();

            Application.Run(new Form1(mongo));
        }
    }
}