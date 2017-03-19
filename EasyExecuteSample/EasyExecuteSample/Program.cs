using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Util.Internal;

namespace EasyExecuteSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new EasyExecuteLib.EasyExecute();
            Parallel.ForEach(Enumerable.Range(0,3),n=> Parallel.ForEach(Enumerable.Range(0, 3),nn=>service.ExecuteAsync(nn.ToString(), "Hello world "+nn, Console.WriteLine).Wait()));
            ;
            Console.ReadKey();
        }
    }
}
