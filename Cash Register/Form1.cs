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
        const double BURGER_COST = 15.99;
        const double FRIES_COST = 9.99;
        const double DRINK_COST = 5.99;
        const double tax = 0.13;
        double subtotal;
        double total;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics(); //Alow fo graphiks ott bee crated
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            formGraphics.FillRectangle(whiteBrush, 0, 290, 300, 10);
        }


    }
}
