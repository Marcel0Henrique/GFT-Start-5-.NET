using System.Data.SQLite;

namespace sistema_funcionarios.classes
{
    public class Crud
    {
         

        public void Connection()
        {
            SQLiteConnection sql_conn = new SQLiteConnection("Data Source=funcionarios.db; Version=3; New=True; Compress=True;");

            try
            {
                sql_conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            
        }

    }
}