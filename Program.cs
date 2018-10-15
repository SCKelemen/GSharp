using System;
using Graph;

namespace gsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<int> G = new Graph<int>();
            Edge<int> oneTwo = new Edge<int>(new Vertex<int>(1), new Vertex<int>(2));
            Edge<int> twoThree = new Edge<int>(new Vertex<int>(2), new Vertex<int>(3));
            Edge<int> threeFour = new Edge<int>(new Vertex<int>(3), new Vertex<int>(4));
            Edge<int> fourOne = new Edge<int>(new Vertex<int>(4), new Vertex<int>(1));
            G.AddEdges(oneTwo, twoThree, threeFour, fourOne);
            G.Print();
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
