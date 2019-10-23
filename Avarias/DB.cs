using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageExt.ClassInstances;
using MySql.Data.MySqlClient;
using static System.Console;

namespace Database
{
     class DB
    {
        private MySqlConnection conn;
        private MySqlDataAdapter adaptador;
        protected string table;
        public string Table { get; set; }

      public  DB()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("Data Source=localhost;database=vistoria");
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                this.adaptador = adaptador;
                adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                this.conn = conn;

            }
            catch (MySqlException e)
            {
                WriteLine("Erro ao conectar ao banco de dados" + e.GetBaseException());
            }

        }

        public static MySqlCommand All()
        {
            var query = new MySqlCommand("SELECT * FROM " + this.table);
            var dados = this.adaptador.SelectCommand = query;
            return this.adaptador.SelectCommand;
        }

    }
}
