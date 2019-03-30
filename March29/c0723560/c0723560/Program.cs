using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c0723560
{
    class Program
    {
        public static object Network { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("downloading a file");
            Console.ReadLine();
        }




        static async Task Download()
        {
            await Network.Download();
            Console.WriteLine("Dowmload complete");
        }




        class Network
        {
            static public Task Download()
            {
                return Task.Run(() => Thread.Sleep(3000));
            }
        }
    }

  






    

