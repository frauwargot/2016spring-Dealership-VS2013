using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolinaVargot_Lab_Due4_22_Dealership
{
    public partial class frmDealership : Form
    {
        string[] Brand = new string [15] {"Honda", "Toyota", "BMW", "Ford", "Dodge", 
                                            "Kia", "Infinity", "Nissan", "Audi", "VW", 
                                             "Toyota", "Honda", "Nissan", "VW", "VW"};

        string[] Model = new string[15] {"Odyssey", "Sienna", "X5", "Mustang", "Ram 1500", 
                                            "Rio", "G35", "Quest", "TT", "Vanagon", 
                                             "Corolla", "Civic", "Altima", "Jetta", "Jetta"};

        int[] Year = new int[15] {2005, 2002, 2015, 2004, 2002, 
                                            1999, 2005, 2000, 1999, 1990, 
                                             2000, 2001, 2004, 2010, 1999};

        decimal[] Price = new decimal[15] {8000, 5000, 30000, 10000, 5000, 
                                            3000, 6000, 3000, 5000, 15000, 
                                             4000, 5000, 5000, 7000, 2000};

        private void Display()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Brand.Length; i++)
                listBox1.Items.Add(Brand[i] + "\t\t" + Model[i] + "\t\t" + Year[i] + "\t\t" + Price[i].ToString("c"));
        }
        
        public frmDealership()
        {
            InitializeComponent();
        }

        private void frmDealership_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            decimal NewPrice;
            decimal.TryParse(txtEnterPriceToChange.Text, out NewPrice);
            if (txtEnterPriceToChange.Text == "")
                MessageBox.Show("Enter price before");
            else if (NewPrice < 0)
                MessageBox.Show("Price can't be less then 0");
            else
            {
                if (listBox1.SelectedIndex == -1)
                    MessageBox.Show("Select car before for price change!");
                else
                {
                    Price[listBox1.SelectedIndex] = NewPrice;
                    MessageBox.Show("Price for " + Brand[listBox1.SelectedIndex] + " " + Model[listBox1.SelectedIndex]+" "+
                                      Year[listBox1.SelectedIndex]+" was changed to "+NewPrice.ToString("c"));
                    Display();
                }
            }

        }

        private void btnSellSelectedCar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                MessageBox.Show("Select car before!");
            else
            {
                MessageBox.Show("Car " + Brand[listBox1.SelectedIndex] + " " + Model[listBox1.SelectedIndex] + " " +
                                      Year[listBox1.SelectedIndex] + " was sold!");
                Brand[listBox1.SelectedIndex] = "";
                Model[listBox1.SelectedIndex] = "";                
                Year[listBox1.SelectedIndex] = 0;
                Price[listBox1.SelectedIndex] = 0;                
                Display();
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if ((txtAddCarBrand.Text == "") || (txtAddCarModel.Text == "") || (txtAddCarPrice.Text == "") || (txtAddCarYear.Text == ""))
                MessageBox.Show("Enter all information about adding car!");
            else
            {
                int counter = 0;
                for (int i = 0; i < Brand.Length; i++)
                {
                    if (Brand[i]=="")
                    {
                        Brand[i] = txtAddCarBrand.Text;
                        Model[i] = txtAddCarModel.Text;
                        Year[i] = int.Parse(txtAddCarYear.Text);
                        Price[i] = decimal.Parse(txtAddCarPrice.Text);
                        counter++;
                        MessageBox.Show("Car " + Brand[i] + " " + Model[i] + " " +
                                      Year[i] + " "+ Price[i] + " was added!" );
                        Display();
                        break;
                    }                   
                }
                if (counter == 0)
                    MessageBox.Show("The lot is full, cannot add new car");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTotalAmount_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            for (int i = 0; i < Price.Length; i++)
            {
                total += Price[i];
            }
            MessageBox.Show("Total amount of all cars : "+ total.ToString("c"));
        }

        private void btnShowCarHighestPrice_Click(object sender, EventArgs e)
        {            
            decimal highest = 0;
            for (int i = 0; i < Price.Length; i++)
            {
                if (highest < Price[i])
                    highest = Price[i];
            }
            for (int i = 0; i < Price.Length; i++)
            {
                if (highest == Price[i])
                {
                    MessageBox.Show("Car " + Brand[i] + " " + Model[i] + " " +
                                      Year[i] + " "+Price[i].ToString("c")+" has highest price!");                    
                }
            }    
        }

        private void btnShowCarLowestPrice_Click(object sender, EventArgs e)
        {
            decimal lowest = 1000000000;
            for (int i = 0; i < Price.Length; i++)
            {
                if (lowest > Price[i])
                    lowest = Price[i];
            }
            for (int i = 0; i < Price.Length; i++)
            {
                if (lowest == Price[i])
                {
                    MessageBox.Show("Car " + Brand[i] + " " + Model[i] + " " +
                                      Year[i] + " " + Price[i].ToString("c") + " has lowest price!");
                }
            }
        }
    }
}
