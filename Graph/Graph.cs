using System;
using System.Collections.Generic;

namespace Graph
{
    public class Graph<T>
    {
        private List<Vertex<T>> _vertices;
        private List<Edge<T>> _edges;
        
        public Graph()
        {
            _vertices = new List<Vertex<T>>();
            _edges = new List<Edge<T>>();
        }
        public Graph(IEnumerable<Vertex<T>> vertices, IEnumerable<Edge<T>> edges)
        {
            _vertices = new List<Vertex<T>>(vertices);
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

        public Graph<T> AddVertex(Vertex<T> vertex)
        {
            if (!_vertices.Contains(vertex))
            {
                this._vertices.Add(vertex);
            }
            return this;
        }

        public Graph<T> AddVertices(params Vertex<T>[] vertices)
        {
            foreach (Vertex<T> vertex in vertices)
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
        public Graph<T> AddEdge(Vertex<T> src, Vertex<T> dst)
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
            foreach(Vertex<T> vertex in this._vertices)
            {
                Console.WriteLine($"\t v{vertex.Value}");
            }
        }

        public void PrintEdges()
        {
            Console.WriteLine("Edges:");
            foreach(Edge<T> edge in this._edges)
            {
                Console.WriteLine($"\t (v{edge.Source.Value})\t ->\t (v{edge.Destination.Value})");
            }
        }

    }

    public class Edge<T>
    {
        private readonly Vertex<T> _source, _destination; 
        public Edge(Vertex<T> source, Vertex<T> destination)
        {
            _source = source;
            _destination = destination;
        }
        
        public Vertex<T> Source => _source;
        public Vertex<T> Destination => _destination;
    }

    public class Vertex<T>
    {
        private readonly T _value;
        public Vertex(T value)
        {
            _value = value;
        }

        public T Value => _value;
    }
    
}