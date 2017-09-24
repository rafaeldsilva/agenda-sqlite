using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda_de_Contatos.DataBase.DSBanco
{   // Classe de acesso ao caminho do banco de dados
    public class DataSourcedBanco
    {
        private static string _dataSource;
        private static string _banco;

        public string DataSource { get => _dataSource; set => _dataSource = value; }
        public string Banco { get => _banco; set => _banco = value; }

        // Método construtor da classe DataSourcedBanco
        public DataSourcedBanco()
        {
            // Caminho de orígem do banco de dados Sqlite
            DataSource = "Data Source = BDAgenda.db; Version = 3;";
            // Nome do banco de dados
            Banco = "BDAgenda.db";
        }
    }
}
