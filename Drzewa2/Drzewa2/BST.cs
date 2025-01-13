using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drzewa2
{
    internal class BST
    {
        public Node root;

        public BST()
        {
            this.root = null;
        }

        public void Add(int liczba)
        {
            Node newNode = new Node(liczba);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent = null;

                while (current != null)
                {
                    parent = current;
                    if (liczba < current.data)
                    {
                        current = current.lewe;
                    }
                    else
                    {
                        current = current.prawe;
                    }
                }

                newNode.rodzic = parent;

                if (liczba < parent.data)
                {
                    parent.lewe = newNode;
                }
                else
                {
                    parent.prawe = newNode;
                }
            }
        }

        public void Remove(int liczba)
        {
            root = RemoveRecursive(root, liczba);
        }

        private Node RemoveRecursive(Node root, int liczba)
        {
            if (root == null) return root;

            if (liczba < root.data)
                root.lewe = RemoveRecursive(root.lewe, liczba);
            else if (liczba > root.data)
                root.prawe = RemoveRecursive(root.prawe, liczba);
            else
            {
                // У узла нет потомков или один потомок
                if (root.lewe == null)
                    return root.prawe;
                else if (root.prawe == null)
                    return root.lewe;

                // У узла два потомка, находим минимальный узел в правом поддереве
                root.data = FindMin(root.prawe).data;

                // Удаляем минимальный узел в правом поддереве
                root.prawe = RemoveRecursive(root.prawe, root.data);
            }

            return root;
        }

        private Node FindMin(Node node)
        {
            while (node.lewe != null)
                node = node.lewe;
            return node;
        }

        public void DrawTree(Graphics g, int x, int y, Node node, int horizontalSpacing)
        {
            if (node == null) return;

            if (node.lewe != null)
            {
                g.DrawLine(Pens.Black, x, y, x - horizontalSpacing, y + 50);
                DrawTree(g, x - horizontalSpacing, y + 50, node.lewe, horizontalSpacing / 2);
            }

            if (node.prawe != null)
            {
                g.DrawLine(Pens.Black, x, y, x + horizontalSpacing, y + 50);
                DrawTree(g, x + horizontalSpacing, y + 50, node.prawe, horizontalSpacing / 2);
            }

            int nodeRadius = node.data.ToString().Length > 2 ? 40 : 30;
            Rectangle nodeRect = new Rectangle(x - nodeRadius / 2, y - nodeRadius / 2, nodeRadius, nodeRadius);

            g.FillEllipse(Brushes.LightBlue, nodeRect);
            g.DrawEllipse(Pens.Black, nodeRect);

            int fontSize = node.data.ToString().Length > 2 ? 8 : 10;
            using (Font font = new Font("Arial", fontSize))
            {
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString(node.data.ToString(), font, Brushes.Black, nodeRect, format);
            }
        }

        public void DisplayTree(Graphics g, Node node, int x, int y, string order)
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

