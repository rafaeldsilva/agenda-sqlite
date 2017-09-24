using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Agenda_de_Contatos.DataBase.Config.UsuarioAdmin
{
    public class UsuarioAdmin
    {
        public UsuarioAdmin(SQLiteConnection Conexao)
        {
           //Cria usuario administrador
           StringBuilder sql = new StringBuilder();
           sql.AppendLine("insert into tb_usuario (login, senha, nome, sobrenome, fk_controle_usuario, ativo, dt_timestamp)");
           sql.AppendLine(" values ");
           sql.AppendLine("('administrador', 'admin', 'Usuario', 'Administrador', 1, 1, datetime())");

           // Classe SQLiteCommand para executar os comandos (Query)
           SQLiteCommand Comando = new SQLiteCommand(sql.ToString(), Conexao);

           // Bloco de tratamento de exceção de erro, para criação de usuario administrador
           try
           {
               Comando.ExecuteNonQuery();
               Conexao.Close();
           }
           catch (Exception ex)
           {
               System.Windows.Forms.MessageBox.Show("Erro ao criar usuario administrador!" + ex.Message);
           }
        }
    }
}
