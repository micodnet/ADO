using System.Data.SqlClient;

string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ADO;Integrated Security=True;Connect Timeout=60;Encrypt=False";
using (SqlConnection connection = new SqlConnection(connectionString))
{
    #region commentaires
    //connection.ConnectionString = connectionString;
    //Console.WriteLine(connection.State);
    //connection.Open();
    //Console.WriteLine(connection.State);
    //connection.Close();
    //Console.WriteLine(connection.State);
    #endregion

    using (SqlCommand command = new SqlCommand())
    {
        command.Connection = connection;

        string sql = "SELECT COUNT(*) FROM Student";
        command.CommandText = sql;
        connection.Open();
        int resultat = (int)command.ExecuteScalar();
        connection.Close();
        Console.WriteLine(resultat);         
    }

    using (SqlCommand command = connection.CreateCommand())
    {
        string sql = "SELECT* FROM Student";
        command.CommandText = sql;
        connection.Open();

        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine(reader["BirthDate"]);
            }
        }
        connection.Close();
    }
}
//command.ExecuteNonQuery();//pas de resultat (INSERT, UPDATE, DELETE)
//command.ExecuteXmlReader();//SELECT avec resultat multi valeurs
//command.ExecuteScalar();//SELECT avec resultat a valeur unique

