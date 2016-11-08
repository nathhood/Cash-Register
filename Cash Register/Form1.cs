//Nathan Hood, October 14, 2016
//This program is for a cah register at BLob's Burger Stand
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
using System.Media;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        //Identify all veriables
        const double BURGER_COST = 15.99;
        const double FRIES_COST = 9.99;
        const double DRINK_COST = 5.99;
        const double TAX_RATE = 0.13;
        double tax;
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
            newOrderButton.Visible = false;//make the newOrderButton hide
        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics(); //Allow for graphics to be crated
            SolidBrush whiteBrush = new SolidBrush(Color.White); //create brush for graphics

            try
            {
                //convert all the textboxes to a variable
                burgerNumber = Convert.ToInt32(burgersInput.Text);
                fryNumber = Convert.ToInt32(friesInput.Text);
                drinkNumber = Convert.ToInt32(drinksInput.Text);
            }
            catch
            {
                subTotalOutput.Text = "Please imput whole numbers only";
                return;
            }
            if (burgerNumber < 0) //to handle poor input
            {
                subTotalOutput.Text = "plese input positive \nwhole numbers only";
                taxOutput.Text = "";
                totalOutput.Text = "";
            }

            else if (fryNumber < 0) //to handle poor input
            {
                subTotalOutput.Text = "plese input positive  \nwhole numbers only";
                taxOutput.Text = "";
                totalOutput.Text = "";
            }

            else if (drinkNumber < 0) //to handle poor input
            {
                subTotalOutput.Text = "plese input positive  \nwhole numbers only";
                taxOutput.Text = "";
                totalOutput.Text = "";
            }

            //give subtotal, tax and total a value then post them on the cah register
            else if (burgerNumber >= 0)
            {
                subtotal = burgerNumber * BURGER_COST + fryNumber * FRIES_COST + drinkNumber * DRINK_COST;
                subTotalOutput.Text = subtotal.ToString("C");
                Refresh();
                Thread.Sleep(500);

                tax = subtotal * TAX_RATE;
                taxOutput.Text = tax.ToString("C");
                Refresh();
                Thread.Sleep(500);

                total = subtotal + tax;
                totalOutput.Text = total.ToString("C");
                Refresh();
                Thread.Sleep(500);

                formGraphics.FillRectangle(whiteBrush, 10, 260, 280, 10);
            }

            //give subtotal, tax and total a value then post them on the cah register
            else if (fryNumber >= 0)
            {
                subtotal = burgerNumber * BURGER_COST + fryNumber * FRIES_COST + drinkNumber * DRINK_COST;
                subTotalOutput.Text = subtotal.ToString("C");
                Refresh();
                Thread.Sleep(500);

                tax = subtotal * TAX_RATE;
                taxOutput.Text = tax.ToString("C");
                Refresh();
                Thread.Sleep(500);

                total = subtotal + tax;
                totalOutput.Text = total.ToString("C");
                Refresh();
                Thread.Sleep(500);

                formGraphics.FillRectangle(whiteBrush, 10, 260, 280, 10);
            }

            //give subtotal, tax and total a value then post them on the cah register
            else if (drinkNumber >= 0)
            {
                subtotal = burgerNumber * BURGER_COST + fryNumber * FRIES_COST + drinkNumber * DRINK_COST;
                subTotalOutput.Text = subtotal.ToString("C");
                Refresh();
                Thread.Sleep(500);

                tax = subtotal * TAX_RATE;
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
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text); //convert tenderedImput to a double
            }
            catch
            {
                changeOutput.Text = "Please input a number only.";
                return;
            }
            total = subtotal + tax; //give total a value

            //give change a value and handle poor input
            if (tendered >= total)
            {
                change = tendered - total;
                changeOutput.Text = change.ToString("C");
            }
            else
            {
                changeOutput.Text = "Not enough funds";
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            SoundPlayer receiptSound = new SoundPlayer(Properties.Resources.receiptSound); //to desgnate the sound file
            DateTime thisDay = DateTime.Today; //Get the current date.
            Graphics formGraphics = this.CreateGraphics(); //Allow for graphics to be crated
            SolidBrush whiteBrush = new SolidBrush(Color.White); //create a brush for graphics
            SolidBrush blackBrush = new SolidBrush(Color.Black); //create a brush for graphics
            Font Font = new Font("Consolas", 7, FontStyle.Bold); //create a font for graphics

            if (tendered > total) // if tendered is more than total then draw the receipt with this statement, and play the sound
            {
                double burgerTotal = burgerNumber * BURGER_COST;
                double fryTotal = fryNumber * FRIES_COST;
                double drinkTotal = drinkNumber * DRINK_COST;
                formGraphics.FillRectangle(whiteBrush, 300, 10, 187, 360);

                receiptSound.Play();

                formGraphics.DrawString("BLob's Burger Bananza", Font, blackBrush, 337, 25);

                formGraphics.DrawString("Order Number 1034", Font, blackBrush, 305, 55);
                Thread.Sleep(500);
                formGraphics.DrawString(thisDay.ToString("D"), Font, blackBrush, 305, 65);
                Thread.Sleep(500);

                formGraphics.DrawString("Burgers", Font, blackBrush, 305, 95);
                formGraphics.DrawString("x" + burgerNumber + " @ " + burgerTotal, Font, blackBrush, 375, 95);
                Thread.Sleep(500);
                formGraphics.DrawString("Fries", Font, blackBrush, 305, 105);
                formGraphics.DrawString("x" + fryNumber + " @ " + fryTotal, Font, blackBrush, 375, 105);
                Thread.Sleep(500);
                formGraphics.DrawString("Drinks", Font, blackBrush, 305, 115);
                formGraphics.DrawString("x" + drinkNumber + " @ " + drinkTotal, Font, blackBrush, 375, 115);
                Thread.Sleep(500);

                formGraphics.DrawString("Subtotal", Font, blackBrush, 305, 145);
                formGraphics.DrawString(subtotal.ToString("C"), Font, blackBrush, 375, 145);
                Thread.Sleep(500);
                formGraphics.DrawString("Tax     ", Font, blackBrush, 305, 155);
                formGraphics.DrawString(tax.ToString("C"), Font, blackBrush, 375, 155);
                Thread.Sleep(500);
                formGraphics.DrawString("Total   ", Font, blackBrush, 305, 165);
                formGraphics.DrawString(total.ToString("C"), Font, blackBrush, 375, 165);
                Thread.Sleep(500);

                formGraphics.DrawString("Tendered", Font, blackBrush, 305, 195);
                formGraphics.DrawString("$" + tendered, Font, blackBrush, 375, 195);
                Thread.Sleep(500);
                formGraphics.DrawString("Change", Font, blackBrush, 305, 205);
                formGraphics.DrawString(change.ToString("C"), Font, blackBrush, 375, 205);
                Thread.Sleep(500);

                formGraphics.DrawString("Have a Nice Day!!", Font, blackBrush, 305, 235);

                newOrderButton.Visible = true; //unhide the newOrder button
            }

            else if (total == 0) // this will happen if tendered is equal to 0
            {
                invalidOrderLabel.Text = "Invalid order, you must order something";
            }

            else if (tendered < total) // this will happen if tendered is less than total
            {
                invalidOrderLabel.Text = "You must pay more than the total";
            }
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics(); //Allow for graphics to be crated

            //clear graphics and reset all labels
            formGraphics.Clear(Color.Black);
            burgersInput.Text = "0";
            friesInput.Text = "0";
            drinksInput.Text = "0";
            subTotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            tenderedInput.Text = "0";
            changeOutput.Text = "";

            //reset all variables
            tax = 0;
            burgerNumber = 0;
            fryNumber = 0;
            drinkNumber = 0;
            subtotal = 0;
            total = 0;
            tendered = 0;
            change = 0;

            newOrderButton.Visible = false; //hide newOrder button
        }
    }
}
