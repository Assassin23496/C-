using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzewa
{
    internal class Class1
    {
        public Class1 rodzic;
        public Class1 lewe;
        public Class1 prawe;
        public int data;
       public Class1(int liczba)
        {
            this.data = liczba;
            this.rodzic = null;
            this.lewe = null;
            this.prawe = null;
        }
        void Polacz(Class1 dziecko)
        {
            dziecko.rodzic = this;
            if(dziecko.data < this.data)
            {
                this.lewe = dziecko;

            }
            else
            {
                this.prawe = dziecko;
            }
        }
    }
}
