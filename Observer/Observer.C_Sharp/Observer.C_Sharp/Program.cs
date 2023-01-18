using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Channels;
using static Observer.C_Sharp.Program.YoutubeChannel;

namespace Observer.C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var channel = new YoutubeChannel("Amamos programar");

            var subscriber = new Subscriber("Random Guy");

            channel.Attach(subscriber);

            channel.Attach(new Subscriber("Nice Guest"));
            channel.Attach(new Subscriber("Observer"));

            channel.ChangeName("Change channel");

            channel.UploadNewVideo();

            Console.ReadKey();
        }

        public interface ISubject
        {
            void Attach(IObserver o);
            void Detach(IObserver o);
            void Notify();
        }
        public interface IObserver
        {
            void Update(ISubject s);

        }
        public class YoutubeChannel : ISubject
        {
            readonly List<IObserver> observers;

            public string Name { get; private set;}
            public YoutubeChannel(string name) 
            {
                observers = new List<IObserver>();
                Name = name;
            }
            public void Attach(IObserver observer)
            {
                Console.WriteLine("Anexando novo observador!");
                Console.WriteLine();
                observers.Add(observer);
            }
            public void Detach(IObserver observer)
            {
                Console.WriteLine("Desanexando novo observador!");
                Console.WriteLine();
                observers.Remove(observer);
            }
            public void Notify() 
            {
                foreach(var observer in observers)
                    observer.Update(this);
            }
            public void ChangeName(string newName)
            {
                Console.WriteLine("O canal {0} alterou o nome para {1}", Name, newName);
                Console.WriteLine();
                Name = newName;

                Notify();
            }

            public void UploadNewVideo()
            {
                Console.WriteLine("O canal {0} postou um novo video!", Name);
                Console.WriteLine();

                Notify();
            }

            public class Subscriber : IObserver
            {
             
                public string Name { get; private set; }

                public Subscriber(string name)
                {
                    Name = name;
                }
                public void Update(ISubject subject)
                {
                    Console.WriteLine("O usuário {0} recebeu a notificação das alterações do canal{1}",
                        Name,(subject as YoutubeChannel).Name );

                    Console.WriteLine();
                }

            }
        }
    }

}
