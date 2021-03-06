﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Agenda_de_Contatos.DataBase.Config.ControleUsuario
{
    public class UsuarioVisualizar
    {
        public UsuarioVisualizar(SQLiteConnection Conexao)
        {
            //Cria usuario administrador
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("insert into tb_controle_usuario (descricao, master, vizualizacao, editar, dt_timestamp)");
            sql.AppendLine("VALUES");
            sql.AppendLine("('Somente Visualização', 0, 1, 0, datetime())");

            // Classe SQLiteCommand para executar os comandos (Query)
            SQLiteCommand Comando = new SQLiteCommand(sql.ToString(), Conexao);

            // Bloco de tratamento de exceção de erro, para criação de usuario administrador
            try
            {
                Comando.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Erro ao criar Somente Visualização!" + ex.Message);
            }


        }
    }
}
