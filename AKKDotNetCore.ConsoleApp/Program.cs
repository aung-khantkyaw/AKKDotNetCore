using AKKDotNetCore.ConsoleApp;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
// adoDotNetExample.Create("title2", "author2", "content2");
// adoDotNetExample.Update(13, "title3", "author3", "content3");
// adoDotNetExample.Delete(13);
// adoDotNetExample.Edit(13);
// adoDotNetExample.Edit(12);

DapperExample dapperExample = new DapperExample();
dapperExample.Run();

Console.ReadKey();