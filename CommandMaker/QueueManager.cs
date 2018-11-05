using CommandMessageNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CommandMaker
{
    static class QueueManager
    {
        private const string queueName = @".\Private$\OlegQueue";        

        private static MessageQueue GetMessageQueue()
        {
            MessageQueue messageQueue = new MessageQueue(queueName);
            messageQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(CommandMessage) });
            return messageQueue;
        }

        public static void VolumeUp()
        {
            MessageQueue messageQueue = GetMessageQueue();
            messageQueue.Send(new CommandMessage() { command = CommandMessage.Command.VolumeUp });
            messageQueue.Close();
        }

        public static void VolumeDown()
        {
            MessageQueue messageQueue = GetMessageQueue();
            messageQueue.Send(new CommandMessage() { command = CommandMessage.Command.VolumeDown });
            messageQueue.Close();
        }

        public static void CancelShutdown()
        {
            MessageQueue messageQueue = GetMessageQueue();
            messageQueue.Send(new CommandMessage() { command = CommandMessage.Command.CancelShutdown });
            messageQueue.Close();
        }

        public static void MicOff()
        {
            MessageQueue messageQueue = GetMessageQueue();
            messageQueue.Send(new CommandMessage() { command = CommandMessage.Command.MicOff });
            messageQueue.Close();
        }


        public static void MicOn()
        {
            MessageQueue messageQueue = GetMessageQueue();
            messageQueue.Send(new CommandMessage() { command = CommandMessage.Command.MicOn });
            messageQueue.Close();
        }

        public static void Shutdown()
        {
            MessageQueue messageQueue = GetMessageQueue();
            messageQueue.Send(new CommandMessage() { command = CommandMessage.Command.Shutdown });
            messageQueue.Close();
        }

        public static void VolumeOff()
        {
            MessageQueue messageQueue = GetMessageQueue();
            messageQueue.Send(new CommandMessage() { command = CommandMessage.Command.VolumeOff });
            messageQueue.Close();
        }


    }
}
