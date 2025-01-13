using System.Drawing.Text;

namespace Dzewa
{
    public partial class Form1 : Form
    {
        private BST tree;
        public Form1()
        {
            InitializeComponent();
            tree = new BST();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            panel1.Paint += new PaintEventHandler(panel1_Paint);
            panel1.AutoScroll = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int liczba))
            {
                tree.Add(liczba);
                textBox1.Clear();
                panel1.Invalidate();
            }
            else
            {
                MessageBox.Show("Wpisz poprawnie!");
            }
        }
        private void DisplayTree()
        {
            textBox2.Clear();
            tree.DisplayInOrder(tree.root, textBox2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (tree.root != null)
            {
                tree.DrawTree(e.Graphics, panel1.Width / 2, 20, tree.root, panel1.Width / 4);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int liczba))
            {
                tree.Remove(liczba);
                textBox1.Clear();
                panel1.Invalidate(); // Перерисовать дерево после удаления
            }
            else
            {
                MessageBox.Show("Введите корректное число!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Invalidate(); // Перерисовать панель вывода
            using (Graphics g = panel1.CreateGraphics())
            {
                g.Clear(panel1.BackColor);
                tree.DisplayTree(g, tree.root, 10, 20, "in");
            }
        }
    }
}
