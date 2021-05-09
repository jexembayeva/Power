using ExponentiationBase;
using System;

namespace LuckyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\algorithms\03._Алгебраические_алгоритмы\3.Power-19350-3eb875\3.Power\";

            Console.WriteLine("-------------------Binary------------------------");
            ITask binaryTask = new BinaryTask();

            Tester binaryTaskTester = new Tester(binaryTask, path);
            binaryTaskTester.RunTests();

            Console.WriteLine("-------------------Multiplication------------------------");
            ITask multiplicationTask = new MultiplicationTask();

            Tester multiplicationTaskTester = new Tester(multiplicationTask, path);
            multiplicationTaskTester.RunTests();

            Console.WriteLine("-------------------Iterative------------------------");
            ITask iterativeTask = new IterativeTask();

            Tester iterativeTaskTester = new Tester(iterativeTask, path);
            iterativeTaskTester.RunTests();

            Console.ReadKey();
        }
    }
}
