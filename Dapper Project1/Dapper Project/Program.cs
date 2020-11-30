using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Linq;



namespace Dapper_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connString);

            //var container = new Container(X =>
            //{
            //    X.AddTransient<IDbConnection>((c) =>
            //    {
            //        return new MySqlConnection(connstring);
            //    });
            //    X.AddTransient<IDepartmentRepository, DapperDepartmentRepository>();

            //});

            //var repo = container.GetService<IDepartmentRepository>();
            var repo = new DapperDepartmentRepository(conn);


            var departments = repo.GetAllDepartments();

            foreach (var item in departments)
            {
                Console.WriteLine(item.Name);
            }
            

            
        }
    }
}
