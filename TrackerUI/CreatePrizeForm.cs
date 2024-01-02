using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {

        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValid = int.TryParse(placeNumberValue.Text, out placeNumber);
            if (placeNumberValid == false) ;
            {
                output = false ;
            }
            if (placeNumber < 1)
            {
                output = false ;
            }
            if (placeNameValue.Text.Length == 0) ;
            {
                output = false;
            }
            return output;
        }
    }
}
