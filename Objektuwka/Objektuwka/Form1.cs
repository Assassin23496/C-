namespace Objektuwka
{
    public partial class Form1 : Form
    {
        private List list = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int liczba))
            {
                list.AddFirst(liczba);
                textBox2.Text = "Adden to front : " + liczba + "\nList : " + list.ToString();
                textBox1.Text = " ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int liczba))
            {
                list.AddLast(liczba);
                textBox2.Text = "adden to end : " + liczba + " \nList " + list.ToString();
                textBox1.Text = " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.RemoveFirst();
            textBox2.Text = "Remove first element.\nList : " + list.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.RemoveLast();
            textBox2.Text = "Remove last element. \nList  " + list.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "List: " + list.ToString;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int index))
            {
                try
                {
                    int value = list.Get(index);
                    textBox2.Text = $"Element at index {index}: {value}";
                }
                catch (IndexOutOfRangeException ex)
                {
                    textBox2.Text = ex.Message;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = list.ToString();
        }
    }
}
