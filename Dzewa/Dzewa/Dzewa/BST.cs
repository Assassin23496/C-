using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dzewa
{
    // сделать метод добавь  в BST
    internal class BST
    {
        public Class1? root;
        public BST() => this.root = null;

        public void Add(int liczba)
        {
            var newClass = new Class1(liczba);
            if (this.root == null)
            {
                this.root = newClass;
                return;
            }
            else
            {
                Class1 current = this.root;
                Class1? parrent = null;
                while (current != null)
                {
                    parrent = current;
                    if (liczba < current.data)
                    {
                        current = current.lewe;
                    }
                    else
                    {
                        current = current.prawe;
                    }
                }
                newClass.rodzic = parrent;
                if (liczba >= parrent.data)
                {
                    parrent.prawe = newClass;
                }
                else
                {
                    parrent.lewe = newClass;
                }
            }
        }
        public void DisplayInOrder(Class1 class1, TextBox texBox2)
        {
            if (class1 != null)
            {
                DisplayInOrder(class1.lewe, texBox2);
                texBox2.AppendText(class1.data + " ");
                DisplayInOrder(class1.prawe, texBox2);
            }
        }
        public void Remove(int liczba)
        {
            root  = REmoveRecursive(root: root,liczba);
        }
        private Class1 REmoveRecursive(Class1 root,int liczba)
        {
            if (root == null)
                return root;
            if(liczba < root.data)
                root.lewe = REmoveRecursive(root.lewe,liczba);
            else if(liczba > root.data)
                root.prawe = REmoveRecursive(root.prawe,liczba);
            else
            {
                if (root.lewe == null)
                    return root.prawe;
                else if (root.prawe == null)
                    return root.lewe;

                root.data = FindMin(root.prawe).data;
                root.prawe = REmoveRecursive(root.prawe,root.data);
            }
            return root;
        }
        private Class1 FindMin(Class1 class1)
        {
            while(class1.lewe != null)
                class1 = class1.lewe;
            return class1;
        }
        public void DrawTree(Graphics g, int x, int y, Class1 class1, int horizontalSpacing)
        {
            if (class1 == null) return;

            if (class1.lewe != null)
            {
                g.DrawLine(Pens.Black, x, y, x - horizontalSpacing, y + 50);
                DrawTree(g, x - horizontalSpacing, y + 50, class1.lewe, horizontalSpacing / 2);
            }

            if (class1.prawe != null)
            {
                g.DrawLine(Pens.Black, x, y, x + horizontalSpacing, y + 50);
                DrawTree(g, x + horizontalSpacing, y + 50, class1.prawe, horizontalSpacing / 2);
            }
            int classRadius = class1.data.ToString().Length > 2 ? 40 : 30;

            Rectangle classRect = new Rectangle(x - classRadius, y - classRadius / 2, classRadius, classRadius);
            g.FillEllipse(Brushes.LightBlue, classRect);
            g.DrawEllipse(Pens.Black, classRect);

            int fontSize = class1.data.ToString().Length > 2 ? 8 : 10;
            using (Font font = new Font("Arial", fontSize))
            {
                StringFormat format = new StringFormat {

                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center,
                };                 
                g.DrawString(class1.data.ToString(), font , Brushes.Black, classRect, format);

            }
        }
        public void DisplayTree(Graphics g, Class1 node, int x, int y, string order)
        {
            if (node == null) return;

            if (order == "pre") g.DrawString(node.data + " ", new Font("Arial", 10), Brushes.Black, x, y);

            DisplayTree(g, node.lewe, x, y + 20, order);
            if (order == "in") g.DrawString(node.data + " ", new Font("Arial", 10), Brushes.Black, x, y);
            DisplayTree(g, node.prawe, x + 50, y + 20, order);

            if (order == "post") g.DrawString(node.data + " ", new Font("Arial", 10), Brushes.Black, x, y);
        }

    }
}