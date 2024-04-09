using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
stringBuilder.DataSource = "Aung-Khant-Kyaw\\AUNGKHANT";
stringBuilder.InitialCatalog = "DotNetTrainingBatch4";
stringBuilder.UserID = "sa";
stringBuilder.Password = "sasa@123";
SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);

connection.Open();
Console.WriteLine("Connection open.");

string quary = "select * from tbl_blog;";
SqlCommand cmd = new SqlCommand(quary, connection);
SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
sqlDataAdapter.Fill(dt);

connection.Close();
Console.WriteLine("Connection close.");

foreach (DataRow dr in dt.Rows)
{
    Console.WriteLine("Blgo Id => " + dr["BlogId"]);
    Console.WriteLine("Blgo Title=> " + dr["BlogTitle"]);
    Console.WriteLine("Blgo Author => " + dr["BlogAuthor"]);
    Console.WriteLine("Blgo Content => " + dr["BlogContent"]);
    Console.WriteLine("____________________________________");
}

Console.ReadKey();