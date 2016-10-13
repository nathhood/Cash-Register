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
        int burgerNumber;
        int fryNumber;
        int drinkNumber;
        double subtotal;
        double total;
        double tendered;
        double change;
        public Form1()
        {
            InitializeComponent();

        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics(); //Alow fo graphiks ott bee crated
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            //convert all the textboxes to a variable
            burgerNumber = Convert.ToInt32(burgersInput.Text);
            fryNumber = Convert.ToInt32(friesInput.Text);
            drinkNumber = Convert.ToInt32(burgersInput.Text);

            subtotal = 




            formGraphics.FillRectangle(whiteBrush, 10, 260, 280, 10);
        }
    }
}
