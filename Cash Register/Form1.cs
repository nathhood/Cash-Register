using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {



        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics(); //Alow fo graphiks ott bee crated
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            formGraphics.FillRectangle(blackBrush, 30, 30, 100, 200);
        }
        private void calculateTotalButton_Click(object sender, EventArgs e)
        {

        }
    }
}
