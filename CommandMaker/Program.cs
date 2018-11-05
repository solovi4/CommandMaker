using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandMaker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            if(args.Length == 1)
            {
                try
                {
                    switch (args[0])
                    {
                        case "VolumeUp": QueueManager.VolumeUp(); break;
                        case "VolumeDown": QueueManager.VolumeDown(); break;
                        case "VolumeOff": QueueManager.VolumeOff(); break;
                        case "Shutdown": QueueManager.Shutdown(); break;
                        case "MicOn": QueueManager.MicOn(); break;
                        case "MicOff": QueueManager.MicOff(); break;
                        case "CancelShutdown": QueueManager.CancelShutdown(); break;
                        default: MessageBox.Show($"Unknown command {args[0]}"); break;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
