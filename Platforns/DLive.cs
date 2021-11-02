using System;

namespace AppBridge.Platforns
{
    class DLive : IPlatform
    {
        public DLive() 
        {
            ConfigureRMTP();
            Console.WriteLine("DLive: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("DLive: Autorizando Aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("DLive: Configurando servidor RMTP.");
        }
    }
}
