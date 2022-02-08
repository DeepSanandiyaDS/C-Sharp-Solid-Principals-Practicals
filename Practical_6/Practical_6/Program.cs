using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6
{
    public class ProcessBusinessLogic
    {
        public event EventHandler<bool> ProcessCompleted;

        public void StartProcess()
        {
            try
            {
                Console.WriteLine("Process Started!");

                Console.WriteLine("Process working!");

                OnProcessCompleted(true);
            }
            catch (Exception ex)
            {
                OnProcessCompleted(false);
            }
        }

        protected virtual void OnProcessCompleted(bool IsSuccessful)
        {
            ProcessCompleted?.Invoke(this, IsSuccessful);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted;
            bl.StartProcess();
            Console.ReadLine();
        }

        public static void bl_ProcessCompleted(object sender, bool IsSuccessful)
        {
            Console.WriteLine("Process " + (IsSuccessful ? "Completed Successfully" : "failed"));
        }
    }
}
