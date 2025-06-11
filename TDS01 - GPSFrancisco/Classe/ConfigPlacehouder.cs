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
        public void ConfigurarPlaceholder(TextBox campoUsuario, TextBox campoSenha, string placeholder, string PlaceholderSenha)
        {
            if (string.IsNullOrWhiteSpace(campoUsuario.Text) || string.IsNullOrWhiteSpace(campoSenha.Text))
            {
                campoUsuario.Text = placeholder;
                campoSenha.Text = PlaceholderSenha;
                campoUsuario.ForeColor = Color.Gray;
                campoSenha.ForeColor = Color.Gray;

                campoUsuario.Font = new Font("Arial", 25);
                campoSenha.Font = new Font("Arial", 25);
            }

           campoSenha.GotFocus += (s, e) =>
            {
                if (campoSenha.Text == PlaceholderSenha)
                {
                    campoSenha.Text = "";
                    campoSenha.ForeColor = Color.Black;
                    campoSenha.PasswordChar = 'l';
                    campoSenha.Font = new Font("Wingdings", 20);
                }
            };

            campoSenha.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(campoSenha.Text))
                {
                    campoSenha.Text = PlaceholderSenha;
                    campoSenha.ForeColor = Color.Gray;
                    campoSenha.Font = new Font("Arial", 25);
                    campoSenha.PasswordChar = '\0';
                }
            };

            campoUsuario.GotFocus += (s, e) =>
            {
                if (campoUsuario.Text == placeholder)
                {
                    campoUsuario.Text = "";
                    campoUsuario.ForeColor = Color.Black;
               
                }
            };

            campoUsuario.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(campoUsuario.Text))
                {
                    campoUsuario.Text = placeholder;
                    campoUsuario.ForeColor = Color.Gray;
                }
            };
        }
    }
}
