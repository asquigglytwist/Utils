using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpNRun
{
    class Program
    {
        static void Main(string[] args)
        {
            Crawler c = new Crawler("http://msnatyalaya.com/");
            c.BeginCrawl();
        }
    }
}
