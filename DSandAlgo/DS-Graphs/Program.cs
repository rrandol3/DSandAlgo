using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            for (int i = 0; i < 7; i++)
            {
                graph.AddVertex(i);
            }
            graph.AddEdge(3, 1);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 2);
            graph.AddEdge(4, 5);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 0);
            graph.AddEdge(0, 2);
            graph.AddEdge(6, 5);
            graph.ShowConnections();
        }
    }
}
