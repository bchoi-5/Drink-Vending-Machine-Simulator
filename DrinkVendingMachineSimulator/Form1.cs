using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkVendingMachineSimulator
{
    struct Drink
    {
        public string drinkName;
        public double drinkCost;
        public int numOfDrinksInMachine;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Drink> drinkOptions = new List<Drink>();
        Drink cocaCola = new Drink();
        Drink rootBeer = new Drink();
        Drink lemonLime = new Drink();
        Drink grapeSoda = new Drink();
        Drink creamSoda = new Drink();

        private int colaTotal = 20;
        private int lemonLimeTotal = 20;
        private int creamSodaTotal = 20;
        private int rootBeerTotal = 20;
        private int grapeSodaTotal = 20;
        private double sodaTotal = 0;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbCola_Click(object sender, EventArgs e)
        {
            try
            {
                if(colaTotal > 0)
                {
                    cocaCola.drinkName = "Cola";
                    cocaCola.drinkCost = 1.00;
                    cocaCola.numOfDrinksInMachine = colaTotal;

                    drinkOptions.Add(cocaCola);

                    cocaCola.numOfDrinksInMachine -= 1;
                    colaTotal--;
                    lblColaQuantity.Text = (cocaCola.numOfDrinksInMachine).ToString();

                    sodaTotal += cocaCola.drinkCost;
                    lblTotalSales.Text = sodaTotal.ToString("c");
                }
                else
                {
                    MessageBox.Show("Sold Out.");
                }
            }
            catch
            {
                MessageBox.Show("Select a soda");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblColaQuantity.Text = colaTotal.ToString();
            lblRootBeerQuantity.Text = rootBeerTotal.ToString();
            lblLemonLimeQuantity.Text = lemonLimeTotal.ToString();
            lblGrapeSodaQuantity.Text = grapeSodaTotal.ToString();
            lblCreamSodaQuantity.Text = creamSodaTotal.ToString();

            lblTotalSales.Text = sodaTotal.ToString("c");
        }

        private void pbRootBeer_Click(object sender, EventArgs e)
        {
            try
            {
                rootBeer.drinkName = "Root Beer";
                rootBeer.drinkCost = 1.00;
                rootBeer.numOfDrinksInMachine = rootBeerTotal;

                drinkOptions.Add(rootBeer);

                rootBeer.numOfDrinksInMachine -= 1;
                rootBeerTotal--;
                lblRootBeerQuantity.Text = (rootBeer.numOfDrinksInMachine).ToString();

                sodaTotal+=rootBeer.drinkCost;
                lblTotalSales.Text = sodaTotal.ToString("c");
            }
            catch
            {
                MessageBox.Show("Select a soda");
            }
        }

        private void pbLemonLime_Click(object sender, EventArgs e)
        {
            try
            {
                lemonLime.drinkName = "Lemon Lime";
                lemonLime.drinkCost = 1.00;
                lemonLime.numOfDrinksInMachine = lemonLimeTotal;

                drinkOptions.Add(lemonLime);

                lemonLime.numOfDrinksInMachine -= 1;
                lemonLimeTotal--;
                lblLemonLimeQuantity.Text = (lemonLime.numOfDrinksInMachine).ToString();

                sodaTotal+=lemonLime.drinkCost;
                lblTotalSales.Text = sodaTotal.ToString("c");
            }
            catch
            {
                MessageBox.Show("Select a soda");
            }
        }

        private void pbGrapeSoda_Click(object sender, EventArgs e)
        {
            try
            {
                grapeSoda.drinkName = "Grape Soda";
                grapeSoda.drinkCost = 1.50;
                grapeSoda.numOfDrinksInMachine = grapeSodaTotal;

                drinkOptions.Add(grapeSoda);

                grapeSoda.numOfDrinksInMachine -= 1;
                grapeSodaTotal--;
                lblGrapeSodaQuantity.Text = (grapeSoda.numOfDrinksInMachine).ToString();

                sodaTotal+=grapeSoda.drinkCost;
                lblTotalSales.Text = sodaTotal.ToString("c");
            }
            catch
            {
                MessageBox.Show("Select a soda");
            }
        }

        private void pbCreamSoda_Click(object sender, EventArgs e)
        {
            try
            {
                creamSoda.drinkName = "Cream Soda";
                creamSoda.drinkCost = 1.50;
                creamSoda.numOfDrinksInMachine = creamSodaTotal;

                drinkOptions.Add(creamSoda);

                creamSoda.numOfDrinksInMachine -= 1;
                creamSodaTotal--;
                lblCreamSodaQuantity.Text = (creamSoda.numOfDrinksInMachine).ToString();

                sodaTotal+= creamSoda.drinkCost;
                lblTotalSales.Text = sodaTotal.ToString("c");
            }
            catch
            {
                MessageBox.Show("Select a soda");
            }
        }
    }
}
