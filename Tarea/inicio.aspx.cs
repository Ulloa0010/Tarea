using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class inicio : System.Web.UI.Page
    {
        float num1 = 0;
        float num2 = 0;
        float resultado = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void radioboton()
        {
            num1 = float.Parse(tn1.Text);
            num2 = float.Parse(tn2.Text);

            if (csuma.Checked)
            {
                resultado = num1 + num2;
            }
            else if (cresta.Checked)
            {
                resultado = num1 - num2;
            }
            else if (cdivision.Checked)
            {
                resultado = num1 / num2;
            }
            else if (cmultiplicacion.Checked)
            {
                resultado = num1 * num2;
            }
            else if (cpotencia2.Checked)
            {
                resultado = num1 * num1;
            }
            else if (cexponentes.Checked)
            {
                resultado = (float)Math.Pow(num1, num2);
            }

            lresultado.Text = resultado.ToString();
        }

        private void menudesplegable()
        {
            num1 = float.Parse(tn1.Text);
            num2 = float.Parse(tn2.Text);

            if (doperacion.SelectedIndex == 0)
            {
                resultado = num1 + num2;
            }
            else if (doperacion.SelectedIndex == 1)
            {
                resultado = num1 - num2;
            }
            else if (doperacion.SelectedIndex == 2)
            {
                resultado = num1 / num2;
            }
            else if (doperacion.SelectedIndex == 3)
            {
                resultado = num1 * num2;
            }
            else if (doperacion.SelectedIndex == 4)
            {
                resultado = num1 * num1;
            }
            else if (doperacion.SelectedIndex == 5)
            {
                resultado = (float)Math.Pow(num1, num2);
            }

            lresultado.Text = resultado.ToString();
        }

        protected void bresultado_Click(object sender, EventArgs e)
        {
            if (csuma.Checked || cresta.Checked ||
                cdivision.Checked || cmultiplicacion.Checked ||
                cpotencia2.Checked || cexponentes.Checked)
            {
                radioboton();
            }
            else
            {
                menudesplegable();
            }
        }
    }
}