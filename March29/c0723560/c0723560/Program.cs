using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c0723560
{
    class Program
    {


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
            public static async Task Download()
            {
                HttpClient client = new HttpClient();
                
                var data = await client.GetStringAsync("http://torontopubliclibrary.ca");
                Console.WriteLine("Download Complete");
            }
        }
    }
}
  






    

