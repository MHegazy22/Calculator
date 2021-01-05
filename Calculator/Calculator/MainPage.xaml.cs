using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Data;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            inputLabel.Text += (sender as Button).Text;
        }

        private void clearButton(object sender, EventArgs e)
        {
            inputLabel.Text = "";
            resultLabel.Text = "0";
        }

        private void calculate(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                int answer = (int)dt.Compute(inputLabel.Text, "");
                resultLabel.Text = answer.ToString();
            }
            catch (InvalidCastException)
            {
                double answer = (double)dt.Compute(inputLabel.Text, "");
                resultLabel.Text = answer.ToString();
            }
            
            
        }

        private void deleteButton(object sender, EventArgs e)
        {
            inputLabel.Text = inputLabel.Text.Substring(0, inputLabel.Text.Length-1);
        }
    }
}
