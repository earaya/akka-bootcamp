using System;
﻿using Akka.Actor;

namespace WinTail
{
    #region Program
    class Program
    {
        public static ActorSystem MyActorSystem;

        static void Main(string[] args)
        {
            // initialize MyActorSystem
            // YOU NEED TO FILL IN HERE
            MyActorSystem = ActorSystem.Create("MyActorSystem");

            // time to make your first actors!
            //YOU NEED TO FILL IN HERE
            // make consoleWriterActor using these props: Props.Create(() => new ConsoleWriterActor())
            // make consoleReaderActor using these props: Props.Create(() => new ConsoleReaderActor(consoleWriterActor))
            Props consoleWriterActorProps = Props.Create<ConsoleWriterActor>();
            IActorRef consoleWriter = MyActorSystem.ActorOf(consoleWriterActorProps, "consoleWriter");
            Props consoleValidatorProps = Props.Create(() => new ConsoleValidatorActor(consoleWriter));
            IActorRef consoleValidator = MyActorSystem.ActorOf(consoleValidatorProps, "consoleValidator");
            Props consoleReaderActorProps = Props.Create(() => new ConsoleReaderActor(consoleValidator));
            IActorRef consoleReader = MyActorSystem.ActorOf(consoleReaderActorProps, "consoleReader");
            // tell console reader to begin
            //YOU NEED TO FILL IN HERE
            consoleReader.Tell(ConsoleReaderActor.StartCommand);

            // blocks the main thread from exiting until the actor system is shut down
            MyActorSystem.AwaitTermination();
        }
    }
    #endregion
}
