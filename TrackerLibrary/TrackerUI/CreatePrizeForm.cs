using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(PlaceNameTextBox.Text,
                                                  PlaceNumberTextBox.Text,
                                                  PriceAmountTextBox.Text,
                                                  PrizePercentageTextBox.Text
                                                  );

                foreach(IDataConnection db in GlobalConfig.Connections)
                {
                    db.createPrize(model);
                }

                PlaceNameTextBox.Text = "";
                PlaceNumberTextBox.Text = "";
                PriceAmountTextBox.Text = "0";
                PrizePercentageTextBox.Text = "0";
            }
            else
            {
                MessageBox.Show("THe data you have entered is Invalid!! Check it...");
            }
        }

        private bool ValidateForm()
        {
            int placeNumber = 0;

            bool placeNumberValidNumber = int.TryParse(PlaceNumberTextBox.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                return  false;
            }

            if (placeNumber  < 1)
            {
                return  false;
            }

            if(PlaceNameTextBox.Text.Length == 0)
            {
                return false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizAmountValid = decimal.TryParse(PriceAmountTextBox.Text, out prizeAmount);
            bool prizePercentageValid =  double.TryParse(PrizePercentageTextBox.Text, out prizePercentage);
            
            if (!prizAmountValid && !prizePercentageValid )
            {
                return false;
            }

            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                return false;
            }

            if(prizePercentage < 0 || prizePercentage > 100)
            {
                return false;
            }
            
            return true;
        }
    }
}
