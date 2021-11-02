using System;
using AppBridge.Platforns;

namespace AppBridge.Transmissions
{
    class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform): base(platform) 
        {
            
        }

        public void Subtitle() 
        {
            Console.WriteLine("Legendas ativadas na transmissão!");
        }

        public void Comments()
        {
            Console.WriteLine("Comentários liberados na live.");
        }

        public void Record()
        {
            Console.WriteLine("Gravação iniciada!");
        }

    }
}
