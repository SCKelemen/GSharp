using System;
using System.Collections.Generic;

namespace Graph
{
    public class Graph<T>
    {
        private List<T> _vertices;
        private List<Edge<T>> _edges;
        
        public Graph()
        {
            _vertices = new List<T>();
            _edges = new List<Edge<T>>();
        }
        public Graph(IEnumerable<T> vertices, IEnumerable<Edge<T>> edges)
        {
            _vertices = new List<T>(vertices);
            _edges = new List<Edge<T>>(edges);
        }

        public bool IsValidGraph()
        {
            return _vertices.Count != 0;
        }

        public bool IsComplete()
        {
            return false;
        }

        public Graph<T> GetCompliment()
        {
            return this;
        }

        public Graph<T> AddVertex(T vertex)
        {
            if (!_vertices.Contains(vertex))
            {
                this._vertices.Add(vertex);
            }
            return this;
        }

        public Graph<T> AddVertices(params T[] vertices)
        {
            foreach (T vertex in vertices)
            {
                this.AddVertex(vertex);
            }
            return this;
        }
        public Graph<T> AddEdge(Edge<T> edge)
        {
            this.AddVertices(edge.Source, edge.Destination);
            if (!_edges.Contains(edge))
            {
                _edges.Add(edge);
            }
            return this;
        }
        public Graph<T> AddEdge(T src, T dst)
        {
            Edge<T> edge = new Edge<T>(src, dst);
            return this.AddEdge(edge);            
        }
        public Graph<T> AddEdges(params Edge<T>[] edges)
        {
            foreach (Edge<T> edge in edges)
            {
                this.AddEdge(edge);
            }
            return this;;
        }

        public void Print()
        {
            this.PrintVertices();
            Console.WriteLine();
            this.PrintEdges();
        }

        public void PrintVertices()
        {
            Console.WriteLine("Vertices:");
            foreach(T vertex in this._vertices)
            {
                Console.WriteLine($"\t {vertex}");
            }
        }

        public void PrintEdges()
        {
            Console.WriteLine("Edges:");
            foreach(Edge<T> edge in this._edges)
            {
                Console.WriteLine($"\t ({edge.Source})\t ->\t ({edge.Destination})");
            }
        }

    }

    public class Edge<T>
    {
        private readonly T _source, _destination; 
        public Edge(T source, T destination)
        {
            _source = source;
            _destination = destination;
        }
        
        public T Source => _source;
        public T Destination => _destination;
    }
    
}