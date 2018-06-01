using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarCalc
{
    public partial class MainFormAstroCalc : Form
    {
        double diametrLens;
        double Vlim;
        double magnitude;
        double amountOfStar;

        public MainFormAstroCalc()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            diametrLens = Convert.ToDouble(tbDiametrLens.Text);
            Vlim = -0.4 + 5 * Math.Log10(diametrLens);
            tbMinMagnitude.Text = Math.Round(Vlim, 3).ToString();
        }

        private void btnAmountOfStar_Click(object sender, EventArgs e)
        {
            magnitude = Convert.ToDouble(tbMagnitude.Text);
            double Pow =  0.754 + 0.4896 * magnitude + 0.001159 * Math.Pow(magnitude, 2) -
                0.000235 * Math.Pow(magnitude, 3);
            amountOfStar = Math.Pow(10, Pow);
            tbAmountOfStar.Text = Math.Round(amountOfStar).ToString();
        }

        private void btnBrightnessDifference_Click(object sender, EventArgs e)
        {
            double firstMagnitude = Convert.ToDouble(tbFirsMagnitude.Text);
            double secondMagnitude = Convert.ToDouble(tbSecondMagnitude.Text);
            double brightnessDifference = Math.Pow(2.512, Math.Abs(firstMagnitude - secondMagnitude));
            tbBrightnessDifference.Text = Math.Round(brightnessDifference).ToString();
        }
    }
}
