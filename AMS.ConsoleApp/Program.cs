using System;
using AMS.Data;

namespace AMS.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext context = new DataContext();
            context.Database.Initialize(true);
        }
    }
}
