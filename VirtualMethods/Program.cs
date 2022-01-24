using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db1 = new SqlDatabase() 
            { 
                Name="Microsoft SQL Server",
                Company="Microsoft",
                isRelational=true
            };
            db1.Create();
            db1.Update();
            
            SqlDatabase db2= new SqlDatabase()
            {
                Name = "Microsoft SQL Server",
                Company = "Microsoft",
                isRelational = true
            };
            db2.Create();
            db2.Update();

            Database db3 = new OracleDatabase()
            {
                Name="Oracle",
                Company="Oracle",
                isRelational=true
            };
            db3.Read();
            
            Console.ReadLine();
        }
    }
    class Database 
    { 
        public string Name { get; set; }
        public string Company { get; set; } // property
        
        public bool isRelational; // field

        public void Create()  // behavior
        {
            Console.WriteLine("Created by database.");
        }
        public virtual void Update()  // (Virtual)      
        {                                                
            Console.WriteLine("Updated by Database."); 
        }
        public virtual void Delete() // (Virtual)
        {
            Console.WriteLine("Deleted by Database.");
        }
        public virtual void Read() // (Virtual)
        {
            Console.WriteLine("Read by Database");
        }
    }
    class SqlDatabase :Database
    {
        public override void Update() // (Override)
        {
            //base.Update();
            Console.WriteLine("Updated by Sql.");
        }
    }
    class OracleDatabase : Database 
    {
        public override void Read() // (Override)
        {
            base.Read();
            Console.WriteLine("Read by Oracle.");
        }
    }
}
