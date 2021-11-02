using System;

namespace AppBridge.Platforns
{
    class Facebook : IPlatform
    {
        public Facebook()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Facebook: Autorizando Aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: Configurando servidor RMTP.");
        }
    }
}
