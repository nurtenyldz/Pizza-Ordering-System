using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Ordering__System
{
    public partial class Settings : Form
    {
        Functions Con;
        public Settings()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Billing Obj = new Billing();
            Obj.Show();
            this.Hide();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            String Key;
            try
            {
                
                    int Pr = Convert.ToInt32(PriceTb.Text);
                
                
                if (PizzaCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select A Pizza!!!");
                }
                else if (PizzaCb.SelectedIndex == 0)
                {
                    Key = "Extra Large";
                    string Query = "Update PizzaTbll set Price = {0} where Item =  '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated!!!");
                }
                else if (PizzaCb.SelectedIndex == 1)
                {
                    Key = "Large";
                    string Query = "Update PizzaTbll set Price = {0} where Item =  '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated!!!");
                }
                else if (PizzaCb.SelectedIndex == 2)
                {
                    Key = "Medium";
                    string Query = "Update PizzaTbll set Price = {0} where Item =  '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated!!!");
                }
                else if (PizzaCb.SelectedIndex == 3)
                {
                    Key = "Small";
                    string Query = "Update PizzaTbll set Price = {0} where Item =  '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated!!!");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
