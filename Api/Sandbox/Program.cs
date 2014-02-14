using System;

namespace Sandbox {
    class Program {
        //note: как обычно. под страхом сеппуку не коммитим этот файл. / Подойма /
        static void Main(string[] args) {
            var start = DateTime.Now;
            try {
                Console.WriteLine("Keeper sandbox start.");
                //note: пишем здесь.
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
            Console.WriteLine("Keeper sandbox end. Time elapsed: {0}", (DateTime.Now - start));
            Console.ReadLine();
        }
    }
}
