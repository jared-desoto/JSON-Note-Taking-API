﻿using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace NotesAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:8080/";

            // Start OWIN host
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                 HttpClient client = new HttpClient();

                 Console.WriteLine("Web Server is running.");
                Console.WriteLine("Press any key to quit.");
                Console.ReadLine();
            }
        }
    }
}
