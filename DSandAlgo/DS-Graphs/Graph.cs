using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Graphs
{
    public class Graph
    {
        private int numberOfNodes = 0;
        private Dictionary<int, List<int>> adjacentList = new Dictionary<int, List<int>>();
        public void AddVertex(int node)
        {
            adjacentList.Add(node, new List<int>());
            numberOfNodes++;
        }

        public void AddEdge(int node1, int node2)
        {
            //Unidirected Graph
            adjacentList[node1].Add(node2);
            adjacentList[node2].Add(node1);
        }

        public void ShowConnections()
        {
            var allNodes = adjacentList.Keys;
            foreach (var node  in allNodes)
            {
                List<int> nodeConnections = adjacentList[node];
                string connections = "";
                
                foreach (var vertex in nodeConnections)
                {
                    connections += vertex + " ";
                }
                Console.WriteLine(node + "-->" + connections);
            }
        }
    }
}
