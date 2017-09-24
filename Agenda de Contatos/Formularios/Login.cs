using Agenda_de_Contatos.DataBase.Conexao;
using Agenda_de_Contatos.DataBase.Config;
using Agenda_de_Contatos.DataBase.Tabelas;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_de_Contatos
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           ConfiguraBanco configBD = new ConfiguraBanco();
        }
    }
}
