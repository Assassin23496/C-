namespace Kod_Huffmana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var slownik = new Dictionary<char, int>();
            var lista = new List<NodeG>();
            foreach(char litera in textBox1.Text)
            {
                if (slownik.ContainsKey(litera))
                {
                    slownik[litera]++;
                }
                else
                {
                    slownik.Add(litera, 1);
                    textBox2.AppendText(litera.ToString() + "\r\n");
                }
            }
            
            
        }
    }
}
