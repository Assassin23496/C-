using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drzewa2
{
    internal class Node
    {
        public int data;
        public Node rodzic;
        public Node lewe;
        public Node prawe;

        public Node(int liczba)
        {
            this.data = liczba;
            this.rodzic = null;
            this.lewe = null;
            this.prawe = null;
        }
    }

}
