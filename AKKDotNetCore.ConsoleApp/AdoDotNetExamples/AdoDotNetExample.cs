using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKKDotNetCore.ConsoleApp.AdoDotNetExamples
{
    internal class AdoDotNetExample
    {

        private readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "Aung-Khant-Kyaw\\AUNGKHANT",
            InitialCatalog = "DotNetTrainingBatch4",
            UserID = "sa",
            Password = "sasa@123"
        };
        public void Read()
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);

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
        }

        public void Edit(int id)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);

            connection.Open();

            string quary = "select * from tbl_blog where BlogId = @BlodId;";
            SqlCommand cmd = new SqlCommand(quary, connection);
            cmd.Parameters.AddWithValue("@BlodId", id);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            connection.Close();

            if (dt.Rows.Count == 0)
            {
                Console.WriteLine("Data Not Found");
                return;
            }

            DataRow dr = dt.Rows[0];

            Console.WriteLine("Blgo Id => " + dr["BlogId"]);
            Console.WriteLine("Blgo Title=> " + dr["BlogTitle"]);
            Console.WriteLine("Blgo Author => " + dr["BlogAuthor"]);
            Console.WriteLine("Blgo Content => " + dr["BlogContent"]);
            Console.WriteLine("____________________________________");

        }

        public void Create(string title, string author, string content)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);

            connection.Open();

            string query = @"INSERT INTO [dbo].[Tbl_Blog]
                ([BlogTitle]
                ,[BlogAuthor]
                ,[BlogContent])
                VALUES
                (@BlogTitle
                ,@BlogAuthor
                ,@BlogContent)";
            SqlCommand cmd = new SqlCommand(@query, connection);
            cmd.Parameters.AddWithValue("@BlogTitle", title);
            cmd.Parameters.AddWithValue("@BlogAuthor", author);
            cmd.Parameters.AddWithValue("@BlogContent", content);
            int result = cmd.ExecuteNonQuery();

            connection.Close();

            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            Console.WriteLine(message);
        }

        public void Update(int id, string title, string author, string content)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);

            connection.Open();
            string query = @"UPDATE [dbo].[Tbl_Blog]
                SET [BlogTitle] = @BlogTitle
                ,[BlogAuthor] = @BlogAuthor
                ,[BlogContent] = @BlogContent
                WHERE BlogId = @BlogId";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@BlogId", id);
            cmd.Parameters.AddWithValue("@BlogTitle", title);
            cmd.Parameters.AddWithValue("@BlogAuthor", author);
            cmd.Parameters.AddWithValue("@BlogContent", content);
            int result = cmd.ExecuteNonQuery();

            connection.Close();
            string message = result > 0 ? "Update Successful." : "Update Failed.";
            Console.WriteLine(message);
        }

        public void Delete(int id)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();

            string query = @"DELETE FROM [dbo].[Tbl_Blog]
                WHERE BlogId = @BlogId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@BlogId", id);
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            string message = result > 0 ? "Delete Successful." : "Delete Failed.";
            Console.WriteLine(message);
        }
    }
}
