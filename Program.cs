using System;
using AppBridge.Transmissions;
using AppBridge.Platforns;

namespace AppBridge
{
    class Program
    {
        public static void StartLive(IPlatform plataform) 
        {
            Console.WriteLine("Aguarde...");
            Live live = new Live(plataform);

            live.Broadcasting();
            live.Result();
        }

        public static void StartLiveAdvanced(IPlatform plataform)
        {
            Console.WriteLine("Aguarde...");
            AdvancedLive live = new AdvancedLive(plataform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Record();
            live.Result();
        }

        static void Main(string[] args)
        {
            //StartLive(new YouTube());
            //StartLive(new Facebook());
            //StartLive(new TwitchTV());

            StartLiveAdvanced(new YouTube());
            StartLiveAdvanced(new Facebook());
            StartLiveAdvanced(new TwitchTV());
            StartLiveAdvanced(new DLive());

            Console.ReadLine();
        }
    }
}
