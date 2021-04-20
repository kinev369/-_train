using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пересдача_GUI
{
    public partial class Form1 : Form
    {
        ContainerVas vag;
        public Form1()
        {
            InitializeComponent();
            vag = new ContainerVas();
            vag.fromFile("1.txt");
            pictureBox1.Image = Image.FromFile(@"мем.jpg");
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = vag.cont[0].Print2();
            label2.Text = vag.cont[1].Print2();
            label17.Text = vag.cont[0].takeFrost();
            label16.Text = vag.cont[1].takeFrost();



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //label4.Text = Convert.ToString(vag.cont[0].GetAllPrice());
            label8.Text = Convert.ToString(vag.cont[1].GetAllPrice());
            //label13.Text = Convert.ToString(vag.cont[0].eGetAllWeight());
            label14.Text = Convert.ToString(vag.cont[1].GetAllWeight());
            label3.Text = vag.cont[1].findUbt();

            label19.Text = Convert.ToString(vag.cont[0].GetAllPrice());
            //label13.Text = Convert.ToString(vag.cont[0].eGetAllWeight());
            label18.Text = Convert.ToString(vag.cont[0].GetAllWeight());
            label20.Text = vag.cont[0].findUbt();
            //label16.Text = vag.cont[1].takeFrost();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
      
}

