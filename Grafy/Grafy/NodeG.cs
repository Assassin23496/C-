using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class NodeG
    {
        public List<NodeG> sasiedni = new List<NodeG>();
        public int data;
       public NodeG(int liczba,GrafA graf)
        {
            this.data = liczba;
        }
        public override string ToString()
        {
            return this.data.ToString();
        }
        public void DodajSasiada(NodeG sasiad)
        {
            if (!sasiedni.Contains(sasiad))
            {
                sasiedni.Add(sasiad);
                sasiad.DodajSasiada(this); // Dodaj dwukierunkowe połączenie
            }
        }

    }
}
