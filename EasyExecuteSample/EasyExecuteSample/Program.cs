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
            Enumerable.Range(0,3).ForEach(n=> Enumerable.Range(0, 3).ForEach(nn=>service.ExecuteAsync(nn.ToString(), "Hello world", Console.WriteLine).Wait()));
            ;
            Console.ReadKey();
        }
    }
}
