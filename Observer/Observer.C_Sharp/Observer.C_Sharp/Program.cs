using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Channels;
using static Observer.C_Sharp.YoutubeChannel;

namespace Observer.C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var channel = new YoutubeChannel("Zangado");

            var subscriber = new Subscriber("Fallen");

            channel.Attach(subscriber);

            channel.Attach(new Subscriber("BRKSEDU"));
            channel.Attach(new Subscriber("LEON"));

            channel.ChangeName("Patrão");


            channel.UploadNewVideo();

            Console.ReadKey();
        } 
    }
}
