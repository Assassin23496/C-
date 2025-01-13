using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DzewaRozpinajace
{
    internal class Graf1
    {
        private List<Edge> edges = new List<Edge>(); // Список рёбер
        private List<NodeG1> nodes = new List<NodeG1>(); // Список узлов

        public Graf1() { }

        // Добавление ребра
        public void AddEdge(Edge edge)
        {
            if (!edges.Contains(edge))
            {
                edges.Add(edge);

                if (!nodes.Contains(edge.Start))
                    nodes.Add(edge.Start);

                if (!nodes.Contains(edge.End))
                    nodes.Add(edge.End);
            }
        }

       
        public void Join(Graf1 otherGraph)
        {
            foreach (var edge in otherGraph.edges)
            {
                AddEdge(edge);
            }
        }
        
        
        public List<Edge> AlgKruskala()
        {
            var mst = new List<Edge>();
            var sortedEdges = edges.OrderBy(e => e.Weight).ToList();

            var parent = new Dictionary<NodeG1, NodeG1>();
            var rank = new Dictionary<NodeG1, int>();

            // Инициализация
            foreach (var node in nodes)
            {
                parent[node] = node;
                rank[node] = 0;
            }

            
            NodeG1 Find(NodeG1 node)
            {
                if (parent[node] != node)
                    parent[node] = Find(parent[node]); 
                return parent[node];
            }

            
            void Union(NodeG1 node1, NodeG1 node2)
            {
                var root1 = Find(node1);
                var root2 = Find(node2);

                if (root1 != root2)
                {
                    if (rank[root1] > rank[root2])
                    {
                        parent[root2] = root1;
                    }
                    else if (rank[root1] < rank[root2])
                    {
                        parent[root1] = root2;
                    }
                    else
                    {
                        parent[root2] = root1;
                        rank[root1]++;
                    }
                }
            }

           
            foreach (var edge in sortedEdges)
            {
                if (Find(edge.Start) != Find(edge.End))
                {
                    mst.Add(edge);
                    Union(edge.Start, edge.End);
                }
            }

            return mst;
        }
    }
}