using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoUpdater
{
    public class Logger
    {
        public void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        public void UpdateMsg(string tag, string info, string dl)
        {
            Console.WriteLine($"============================\n" +
                              $"Update found: {tag}\n" +
                              $"Info: {info}\n" +
                              $"Download: {dl}");
        }
    }
}
