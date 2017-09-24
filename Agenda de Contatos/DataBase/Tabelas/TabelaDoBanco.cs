using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Agenda_de_Contatos.DataBase.Tabelas
{   // Classe de criação das tabelas do banco de dados
    public class TabelaDoBanco
    {
        public void CriarTabelaUsuario(SQLiteConnection Conexao)
        {
            //Cria-se a tabela de usuarios
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("create table if not exists tb_usuario ([pkey] integer primary key autoincrement,");
            sql.AppendLine("[login] varchar(50),");
            sql.AppendLine("[senha] varchar(50),");
            sql.AppendLine("[nome] varchar(550),");
            sql.AppendLine("[sobrenome] varchar(550),");
            sql.AppendLine("[email] varchar(150),");
            sql.AppendLine("[fk_controle_usuario] int,");
            sql.AppendLine("[ativo] bit,");
            sql.AppendLine("[dt_timestamp] datetime)");

            // Classe SQLiteCommand para executar os comandos (Query)
            SQLiteCommand Comando = new SQLiteCommand(sql.ToString(), Conexao);

            // Bloco de tratamento de exceção de erro, para criação da tabela usuarios
            try
            {
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Erro ao criar tabela de usuários!" + ex.Message);
            }
        }
     
        public void CriarTabelaControleDeUsuario(SQLiteConnection Conexao)
        {
            //Cria-se a tabela controle de usuarios
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("create table if not exists tb_controle_usuario ([pkey] integer primary key autoincrement,");
            sql.AppendLine("[descricao] varchar(50),");
            sql.AppendLine("[master] bit,");
            sql.AppendLine("[vizualizacao] bit,");
            sql.AppendLine("[editar] bit,");
            sql.AppendLine("[dt_timestamp] datetime)");

            // Classe SQLiteCommand para executar os comandos (Query)
            SQLiteCommand Comando = new SQLiteCommand(sql.ToString(), Conexao);

            // Bloco de tratamento de exceção de erro, para criação da tabela controle usuarios
            try
            {
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Erro ao criar tabela controle de usuários!" + ex.Message);
            }
        }

        public void CriarTabelaContato(SQLiteConnection Conexao)
        {
            // Cria-se a tabela de contatos
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("create table if not exists tb_contato ([pkey] integer primary key autoincrement,");
            sql.AppendLine("[nome] varchar(550),");
            sql.AppendLine("[sobrenome] varchar(550),");
            sql.AppendLine("[empresa] varchar(550),");
            sql.AppendLine("[departamento] varchar(550),");
            sql.AppendLine("[comentario] varchar(2000),");
            sql.AppendLine("[dt_timestamp] datetime)");

            // Classe SQLiteCommand para executar os comandos (SQL-T)
            SQLiteCommand Comando = new SQLiteCommand(sql.ToString(), Conexao);

            // Bloco de tratamento de exceção de erro, para criação da tabela de contatos
            try
            {
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Erro ao criar tabela de contatos!" + ex.Message);
            }
        }

        public void CriarTabelaTelefone(SQLiteConnection Conexao)
        {
            // Cria-se a tabela de telefone
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("create table if not exists telefone ([pkey] integer primary key autoincrement,");
            sql.AppendLine("[telefone] varchar(50),");
            sql.AppendLine("[fk_contato] int,");
            sql.AppendLine("[tipotel] varchar(50),");
            sql.AppendLine("[obsversacao] varchar(1000),");
            sql.AppendLine("[dt_timestamp] datetime)");

            // Classe SQLiteCommand para executar os comandos (Query)
            SQLiteCommand Comando = new SQLiteCommand(sql.ToString(), Conexao);

            // Bloco de tratamento de exceção de erro, para criação da tabela de telefone
            try
            {
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Erro ao criar tabela de telefone!" + ex.Message);
            }
        }

        public void CriarTabelaEmail(SQLiteConnection Conexao)
        {
            // Cria-se a tabela de email
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("create table if not exists email ([pkey] integer primary key autoincrement,");
            sql.AppendLine("[email] varchar(50),");
            sql.AppendLine("[fk_contato] int,");
            sql.AppendLine("[tipoemail] varchar(50),");
            sql.AppendLine("[obsversacao] varchar(1000),");
            sql.AppendLine("[dt_timestamp] datetime)");

            // Classe SQLiteCommand para executar os comandos (Query)
            SQLiteCommand Comando = new SQLiteCommand(sql.ToString(), Conexao);

            // Bloco de tratamento de exceção de erro, para criação da tabela de email
            try
            {
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Erro ao criar tabela de email!" + ex.Message);
            }
        }
    }
}
