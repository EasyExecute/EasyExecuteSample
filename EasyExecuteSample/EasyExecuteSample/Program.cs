using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExecuteSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new EasyExecuteLib.EasyExecute();
            service.ExecuteAsync("1", () =>
            {
                Console.WriteLine("Hello world");
                return Task.FromResult(new object());
            }).Wait();
        }
    }
}
