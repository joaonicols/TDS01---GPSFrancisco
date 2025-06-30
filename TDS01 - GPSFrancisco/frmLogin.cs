using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDS01___GPSFrancisco.Classe;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

namespace TDS01___GPSFrancisco
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            ConfigPlacehouder configPlacehouder = new ConfigPlacehouder();
            configPlacehouder.ConfigurarPlaceholder(txtLoginUsuario, txtLoginSenha, "Usuário:", "Senha:");
        }

        private void btnEntrar_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;  // Ajuste o raio conforme desejar
            Rectangle rect = btnEntrar.ClientRectangle;

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            btnEntrar.Region = new Region(path);
        }
    }
}
