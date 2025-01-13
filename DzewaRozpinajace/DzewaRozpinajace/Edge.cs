using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DzewaRozpinajace
{
    internal class Edge
    {
       public NodeG1 Start { get; set; }
       public NodeG1 End { get; set; }
        public int Weight {  get; set; }

        public Edge(NodeG1 start,NodeG1 end,int weight) {
            Start = start;
            End = end; 
            Weight = weight;
        }
       
        //Edges.OrderBy(k=>k.weight).Tostring

    }
}
