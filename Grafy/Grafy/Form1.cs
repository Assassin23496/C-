using System.Security.Cryptography.X509Certificates;

namespace Grafy
{
    public partial class Form1 : Form
    { 
       
        public Form1()
        {
           
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {

            GrafA graf = new GrafA();

            NodeG wezA = new(1, graf);
            NodeG wezB = new(2, graf);
            NodeG wezC = new(3, graf);
            NodeG wezD = new(4, graf);
            NodeG wezE = new(5, graf);
            NodeG wezF = new(6, graf);
            NodeG wezG = new(7, graf);
            wezA.DodajSasiada(wezB);
            wezA.DodajSasiada (wezC);
            wezB.DodajSasiada(wezD);
            wezB.DodajSasiada(wezE);
            wezC.DodajSasiada(wezD);
            wezC.DodajSasiada(wezF);
            wezE.DodajSasiada(wezF);
            wezF.DodajSasiada(wezG);
        }
    }
}
