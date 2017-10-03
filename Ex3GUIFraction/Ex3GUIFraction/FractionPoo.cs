/***
 * Name     :   Fractions
 * Author   :   B.Silka
 * Desc.    :   Fractions view
 * Version  :   1.0, 3.10.2017, B.SILKA  
 ***/

using Fractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3GUIFraction
{
    public partial class FractionPoo : Form
    {
        public FractionPoo()
        {
            InitializeComponent();
        }

        private void BtnCalcul_Click(object sender, EventArgs e)
        {
            try
            {
                Fraction fraction1 = new Fraction(Convert.ToInt32(txbFrac1Num.Text),
                                  Convert.ToInt32(txbFrac1Den.Text));

                Fraction fraction2 = new Fraction(Convert.ToInt32(txbFrac2Num.Text),
                                                  Convert.ToInt32(txbFrac2Den.Text),
                                                  new BeautifierInterfaceParenthesis());

                Fraction fraction3 = new Fraction(Convert.ToInt32(txbFrac3Num.Text),
                                                  Convert.ToInt32(txbFrac3Den.Text),
                                                  new BeautifierInterfaceLatex());

                Fraction fraction4 = new Fraction(Convert.ToDecimal(txbFrac4.Text));
                Fraction fraction5 = fraction1.Add(fraction2);
                Fraction fraction6 = fraction1.Add(fraction2);
                Fraction fraction7 = fraction6.Sub(fraction3);

                lblResult1.Text = fraction1.ToString();
                lblResult2.Text = fraction2.ToString();
                lblResult3.Text = fraction3.ToString();
                lblResult4.Text = fraction1.ToString() + " + " + fraction3.ToString() + " = " + fraction5.ToString();
                lblResult5.Text = fraction1.ToString() + " + " + fraction2.ToString() + " - " + fraction3.ToString() + " = " + fraction7.ToString();
                lblResult6.Text = fraction4.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Fractions can not be empty");
            }
        }

        /// <summary>
        /// Allow only number in textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Allow only numbers and a dot in textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyPressForDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
