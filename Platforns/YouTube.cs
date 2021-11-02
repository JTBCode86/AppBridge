using System;

namespace AppBridge.Platforns
{
    class YouTube : IPlatform
    {
        public YouTube() 
        {
            ConfigureRMTP();
            Console.WriteLine("YouTube: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("YouTube: Autorizando Aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("YouTube: Configurando servidor RMTP."); 
        }
    }
}
