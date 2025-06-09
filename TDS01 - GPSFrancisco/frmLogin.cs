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

namespace TDS01___GPSFrancisco
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            ConfigPlacehouder configPlacehouder = new ConfigPlacehouder();
            configPlacehouder.ConfigurarPlaceholder(txtLoginUsuario, "Usuário:");
            configPlacehouder.ConfigurarPlaceholder(txtLoginSenha, "Senha:");

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
