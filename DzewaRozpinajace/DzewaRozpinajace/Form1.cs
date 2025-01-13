using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DzewaRozpinajace
{
    public partial class Form1 : Form
    {
        private TextBox outputTextBox;

        public Form1()
        {
            InitializeComponent();
            InitializeTextBox();
        }

        private void InitializeTextBox()
        {
            outputTextBox = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill
            };
            Controls.Add(outputTextBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 4-6 : 1
            // 4-5 : 2
            // 0-6: 3
            // 2-7 : 3
            // 2-4 : 4
            // 2-6 : 5 X
            // 0-1 : 5
            // 1-5 : 6 X
            // 5-6 : 6 X
            // 1-7 : 7 X
            // 1-4 : 8 X
            // 3-6 : 8 
            // 0-3 : 9 X
            // 2-3 : 9 X
            // 1-2 : 9 X
            // 6-7 : 9 X

            var graf1 = new Graf1();

            
            var nodes = new Dictionary<int, NodeG1>();
            for (int i = 0; i <= 7; i++)
            {
                nodes[i] = new NodeG1(i);
            }

            // Добавляем рёбра
            graf1.AddEdge(new Edge(nodes[4], nodes[6], 1));
            graf1.AddEdge(new Edge(nodes[4], nodes[5], 2));
            graf1.AddEdge(new Edge(nodes[0], nodes[6], 3));
            graf1.AddEdge(new Edge(nodes[2], nodes[7], 3));
            graf1.AddEdge(new Edge(nodes[2], nodes[4], 4));
            graf1.AddEdge(new Edge(nodes[0], nodes[1], 5));
            graf1.AddEdge(new Edge(nodes[3], nodes[6], 8));

            // Находим минимальное остовное дерево
            var mst = graf1.AlgKruskala();

            // Выводим результат
            outputTextBox.AppendText("Минимальное остовное дерево:\r\n");
            foreach (var edge in mst)
            {
                outputTextBox.AppendText($"{edge.Start.data} - {edge.End.data} : {edge.Weight}\r\n");
            }
        }
    }
}
