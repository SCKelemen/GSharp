using System;
using Graph;

namespace gsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<int> G = new Graph<int>();
            Edge<int> oneTwo = new Edge<int>(1,2);
            Edge<int> twoThree = new Edge<int>(2,3);
            Edge<int> threeFour = new Edge<int>(3,4);
            Edge<int> fourOne = new Edge<int>(4,1);
            G.AddEdges(oneTwo, twoThree, threeFour, fourOne);
            G.Print();
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
