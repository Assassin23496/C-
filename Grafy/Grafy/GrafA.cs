using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class GrafA
    {
        private List<NodeG> nodes = new List<NodeG>();
        public List<NodeG> wrzerz(NodeG start)
        {
            var odwiedzane = new List<NodeG>() { start};

            for(int i = 0;i < odwiedzane.Count; i++)
            {
                var temp = odwiedzane[i];
                for(int j = 0;j < temp.sasiedni.Count; j++)
                {
                    if (!odwiedzane.Contains(temp.sasiedni[j]))
                    {
                        odwiedzane.Add(temp.sasiedni[j]);
                    }
                }
            }
            return odwiedzane;
        }

       
}
}