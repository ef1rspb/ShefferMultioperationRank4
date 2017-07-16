﻿using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ShefferMultioperationRank4
{
    /// <summary>
    /// Entry point class 
    /// </summary>
    class Program1
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            // generate all multioperations of rank 4 (count = 2^16 = 65536)
            var gen4 = (from a in Enumerable.Range(0, 16)
                        from b in Enumerable.Range(0, 16)
                        from c in Enumerable.Range(0, 16)
                        from d in Enumerable.Range(0, 16)
                        select new Multioperation4(a, b, c, d)).ToArray();

            // contents multioperation f and number of elements
            // in corresponging algebra of unary multioperations
            var results = new ConcurrentBag<Tuple<Multioperation4, int>>();
            var finished = new bool[1] { false };

            var thread = new Thread((obj) =>
            {
                var fin = (bool[])obj;

                using (var file = new FileStream("ops.txt", FileMode.Append, FileAccess.Write, FileShare.Read))
                using (var wr = new StreamWriter(file))
                {
                    while (!fin[0])
                    {
                        Tuple<Multioperation4, int> tpl;
                        while (results.TryTake(out tpl))
                        {
                            wr.WriteLine(tpl);
                            Console.Out.WriteLine("Tuple = {0}, count = ", tpl.Item1, tpl.Item2);
                        }
                        wr.Flush();
                        //Thread.Sleep(500);
                    }
                }
            });

            thread.Priority = ThreadPriority.BelowNormal;
            thread.Start(finished);


            Parallel.ForEach(gen4, new ParallelOptions() { MaxDegreeOfParallelism = 8 }, op =>
            {
                var opCnt = ArrSet4.CheckOp4Arr(op);
                results.Add(new Tuple<Multioperation4, int>(op, opCnt));
            });
            finished[0] = true;

            Console.ReadKey();
            return;
        }
    }
}
