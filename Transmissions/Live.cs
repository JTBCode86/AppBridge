using System;
using AppBridge.Platforns;

namespace AppBridge.Transmissions
{
    class Live : Itransmisson
    {
        protected IPlatform plataform;
        public Live(IPlatform plataform) 
        {
            this.plataform = plataform;
        }

        public void Broadcasting()
        {
            Console.WriteLine($"Iniciando a transmissão na plataforma {plataform}");
        }

        public void Result()
        {
            Console.WriteLine("******* ON AIR  *******\r\n");
        }
    }
}
