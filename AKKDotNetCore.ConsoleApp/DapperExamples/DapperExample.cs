﻿using AKKDotNetCore.ConsoleApp.Dtos;
using AKKDotNetCore.ConsoleApp.Services;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AKKDotNetCore.ConsoleApp.DapperExamples
{
    internal class DapperExample
    {
        public void Run()
        {
            //Read();
            //Edit(1);
            //Edit(15);
            //Create("title2", "author2", "content2");
            //Update(15, "title3", "author3", "content3");
            Delete(15);
        }

        public void Read()
        {
            using IDbConnection db = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
            List<BlogDto> lst = db.Query<BlogDto>("select * from tbl_blog").ToList();
            foreach (BlogDto item in lst)
            {
                Console.WriteLine(item.BlogId);
                Console.WriteLine(item.BlogTitle);
                Console.WriteLine(item.BlogAuthor);
                Console.WriteLine(item.BlogContent);
                Console.WriteLine("---------------------------");
            }
        }

        public void Edit(int id)
        {
            using IDbConnection db = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
            var item = db.Query<BlogDto>("select * from tbl_blog where blogid = @BlogId", new BlogDto { BlogId = id }).FirstOrDefault();
            if (item is null)
            {
                Console.WriteLine("No data found.");
                return;
            }
            Console.WriteLine(item.BlogId);
            Console.WriteLine(item.BlogTitle);
            Console.WriteLine(item.BlogAuthor);
            Console.WriteLine(item.BlogContent);
            Console.WriteLine("---------------------------");
        }

        public void Create(string title, string author, string content)
        {
            var item = new BlogDto
            {
                BlogTitle = title,
                BlogAuthor = author,
                BlogContent = content
            };
            string query = @"INSERT INTO [dbo].[Tbl_Blog]
                ([BlogTitle]
                ,[BlogAuthor]
                ,[BlogContent])
                VALUES
                (@BlogTitle
                ,@BlogAuthor
                ,@BlogContent)";
            using IDbConnection db = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
            int result = db.Execute(query, item);

            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            Console.WriteLine(message);
        }

        public void Update(int id, string title, string author, string content)
        {
            var item = new BlogDto
            {
                BlogId = id,
                BlogTitle = title,
                BlogAuthor = author,
                BlogContent = content
            };
            string query = @"UPDATE [dbo].[Tbl_Blog]
                SET [BlogTitle] = @BlogTitle
                ,[BlogAuthor] = @BlogAuthor
                ,[BlogContent] = @BlogContent
                WHERE BlogId = @BlogId";
            using IDbConnection db = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
            int result = db.Execute(query, item);

            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            Console.WriteLine(message);
        }

        public void Delete(int id)
        {
            var item = new BlogDto
            {
                BlogId = id
            };
            string query = @"DELETE FROM [dbo].[Tbl_Blog]
                WHERE BlogId = @BlogId";
            using IDbConnection db = new SqlConnection(ConnectionStrings.SqlConnectionStringBuilder.ConnectionString);
            int result = db.Execute(query, item);

            string message = result > 0 ? "Delete Successful." : "Delete Failed.";
            Console.WriteLine(message);
        }
    }
}
