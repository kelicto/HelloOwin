using System;
using System.Configuration;

using Microsoft.Owin.Hosting;

namespace KeLi.HelloOwin.App
{
    internal class Program
    {
        private static void Main()
        {
            var baseAddress = ConfigurationManager.AppSettings["BaseAddress"];

            using (WebApp.Start<Startup>(baseAddress))
			{
				Console.WriteLine("Running on {0}", baseAddress);
                Console.WriteLine("Press enter to exit.");
                Console.ReadLine();
            }
        }
    }
}