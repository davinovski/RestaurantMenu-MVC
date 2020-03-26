using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuApp.Models
{
    public static class Helper
    {
        public static void CheckAndWrite(string logEvent)
        {
            string path = "./Logger/logger.txt";
            using var sw = new StreamWriter(path, File.Exists(path));
            sw.WriteLine(logEvent);
        }
    }
}
