using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        const double BURGER_COST = 15.99;
        const double FRIES_COST = 9.99;
        const double DRINK_COST = 5.99;
        double tax = 0.13;
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
            drinkNumber = Convert.ToInt32(drinksInput.Text);

            if (burgerNumber < 0)
            {
                subTotalOutput.Text = "please imput whole numbers only";
                taxOutput.Text = "please imput whole numbers only";
                totalOutput.Text = "please imput whole numbers only";
            }

            else if (fryNumber < 0)
            {
                subTotalOutput.Text = "please imput whole numbers only";
                taxOutput.Text = "please imput whole numbers only";
                totalOutput.Text = "please imput whole numbers only";
            }

            else if (drinkNumber < 0)
            {
                subTotalOutput.Text = "please imput whole numbers only";
                taxOutput.Text = "please imput whole numbers only";
                totalOutput.Text = "please imput whole numbers only";
            }

            else if (burgerNumber >= 0)
            {
                subtotal = burgerNumber * BURGER_COST + fryNumber * FRIES_COST + drinkNumber * DRINK_COST;
                subTotalOutput.Text = subtotal.ToString("C");
                Refresh();
                Thread.Sleep(500);

                tax = subtotal * 0.13;
                taxOutput.Text = tax.ToString("C");
                Refresh();
                Thread.Sleep(500);

                total = subtotal + tax;
                totalOutput.Text = total.ToString("C");
                Refresh();
                Thread.Sleep(500);

                formGraphics.FillRectangle(whiteBrush, 10, 260, 280, 10);
            }

            else if (fryNumber >= 0)
            {
                subtotal = burgerNumber * BURGER_COST + fryNumber * FRIES_COST + drinkNumber * DRINK_COST;
                subTotalOutput.Text = subtotal.ToString("C");
                Refresh();
                Thread.Sleep(500);

                tax = subtotal * 0.13;
                taxOutput.Text = tax.ToString("C");
                Refresh();
                Thread.Sleep(500);

                total = subtotal + tax;
                totalOutput.Text = total.ToString("C");
                Refresh();
                Thread.Sleep(500);

                formGraphics.FillRectangle(whiteBrush, 10, 260, 280, 10);
            }

            else if (drinkNumber >= 0)
            {
                subtotal = burgerNumber * BURGER_COST + fryNumber * FRIES_COST + drinkNumber * DRINK_COST;
                subTotalOutput.Text = subtotal.ToString("C");
                Refresh();
                Thread.Sleep(500);

                tax = subtotal * 0.13;
                taxOutput.Text = tax.ToString("C");
                Refresh();
                Thread.Sleep(500);

                total = subtotal + tax;
                totalOutput.Text = total.ToString("C");
                Refresh();
                Thread.Sleep(500);

                formGraphics.FillRectangle(whiteBrush, 10, 260, 280, 10);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToDouble(tenderedInput.Text);
            total = subtotal + tax;

            if (tendered > total)
            { change = tendered - total;
                changeOutput.Text = change.ToString("C");
            }
            else
            {
                changeOutput.Text = "Not enough funds";

            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics(); //Alow fo graphiks ott bee crated
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            

            formGraphics.FillRectangle(whiteBrush, 300, 10, 187, 417);
        }
    }
}
