using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDS01___GPSFrancisco.Classe
{
    public class ConfigPlacehouder : TextBox
    {
        public void ConfigurarPlaceholder(TextBox campo, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                campo.Text = placeholder;
                campo.ForeColor = Color.Gray;
            }

            campo.GotFocus += (s, e) =>
            {
                if (campo.Text == placeholder)
                {
                    campo.Text = "";
                    campo.ForeColor = Color.Black;
                }
            };

            campo.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(campo.Text))
                {
                    campo.Text = placeholder;
                    campo.ForeColor = Color.Gray;
                }
            };
        }
    }
}
