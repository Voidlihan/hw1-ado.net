using System;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Extensions.Configuration;
using Table;

namespace ADO.NET_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                var grup = new gruppa
                {
                    Name = "vasya"
                };
                context.Add(grup);
                context.SaveChanges();
            }
        }
    }
}
