using System.Data.SQLite;

namespace sistema_funcionarios.classes
{
    public class Sistema
    {
        //* Atributos
        private string? _nome;

        private int _admin;


        //* Getters e Setters
        public string? nome
        {
            get
            { return this._nome; }
            set { this._nome = value; }
        }

        public int admin
        {
            get { return this._admin; }
            set { this._admin = value; }
        }

        SQLiteConnection sql_conn = new SQLiteConnection("Data Source=funcionarios.db; Version=3; New=True; Compress=True;");

        public void Connection()
        {
            try
            {

                FileInfo file = new FileInfo(@"funcionarios.db");
                if (file.Exists)
                {
                    Console.WriteLine("Banco de dados já criado");
                }
                else
                {
                    sql_conn.Open();
                    SQLiteCommand cmd = sql_conn.CreateCommand();

                    cmd.CommandText = "CREATE TABLE funcionarios (id INTEGER NOT NULL UNIQUE, nome TEXT NOT NULL, sobrenome	INTEGER NOT NULL, email TEXT NOT NULL, senha TEXT NOT NULL, admin NUMERIC NOT NULL, PRIMARY KEY(id AUTOINCREMENT));";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO funcionarios (nome, sobrenome, email, senha, admin) VALUES ('admin', 'suporte','admin@suporte.com','admin', 1)";
                    cmd.ExecuteNonQuery();
                    sql_conn.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }

        public bool Login(string? email, string? senha)
        {

            sql_conn.Open();
            SQLiteDataReader reader;
            SQLiteCommand cmd = sql_conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM funcionarios WHERE email = '{email}' AND senha = '{senha}'";

            reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.GetString(3) != "")
            {
                Console.WriteLine();
                this.nome = email;
                this.admin = reader.GetInt32(5);
                return true;
            }
            else
            {
                return false;
            }

        }
        public void Cadastrar(string nome, string sobrenome, string email, string senha, int admin = 0)
        {

            SQLiteCommand cmd = sql_conn.CreateCommand();
            cmd.CommandText = $"INSERT INTO funcionarios (nome, sobrenome, email, senha, admin) VALUES ('{nome}', '{sobrenome}','{email}','{senha}', {admin})";
            cmd.ExecuteNonQuery();


        }
        public void Apagar(string email)
        {
            if (this.admin == 1)
            {
                SQLiteCommand cmd = sql_conn.CreateCommand();
                cmd.CommandText = $"DELETE FROM funcionarios WHERE email = '{email}'";
                cmd.ExecuteNonQuery();
            }

        }

        public void Promover(string email)
        {
            if (this.admin == 1)
            {
                SQLiteCommand cmd = sql_conn.CreateCommand();
                cmd.CommandText = $"UPDATE funcionarios SET admin = 1 WHERE email = '{email}'";
            }
        }
    }
}