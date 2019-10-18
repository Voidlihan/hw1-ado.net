using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using Microsoft.Extensions.Configuration;

namespace ADO.NET_HW1
{
    class Program
    {
        readonly static string connectionString = "Server=A-305-03;Database=ShopDB;Trusted_Connection=True;";
        static void Main(string[] args)
        {
            Query();
        }
        public static void Query()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = connection.CreateCommand())
            {
                string query = $"CREATE TABLE [dbo].[gruppa]([id][uniqueidentifier] NOT NULL, [Name] [nvarchar](max) NULL, " +
                    $"CONSTRAINT [PK_gruppa] PRIMARY KEY CLUSTERED ([id] ASC) " +
                    $"WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, " +
                    $"ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) " +
                    $"ON [PRIMARY]) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]";
                command.CommandText = query;
                connection.Open();
            }
        }
    }
}
