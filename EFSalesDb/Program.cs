using EFSalesDb.Models;
using System;
using System.Linq;

namespace EFSalesDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SalesdbContext(); // insert instance of your dbcontextclass

            var customers = context.Customers.ToList(); // gets all customer from db

            var customer = context.Customers.Find(1); // get customer by PK 


            var customersInCinci = context.Customers // get customer that are located in city Cinci
                .Where(c => c.City == "Cincinnati")
                .ToList(); // return data in list

// INSERT NEW CUSTOMER
            //var newCustomer = new Customer()
            //{
            //    Name = "TQL", City = "Cincinnati", State = "OH", Sales = 4000000, Active = true
            //};

            ////context.Customers.Add(newCustomer); // 
            ////var rowsAffected = context.SaveChanges(); // saveschanges actually commits the actions

            //// UPDATING BY PK
            //var tql = context.Customers.Find(36); // read the record
            //tql.Name = "Total Quality Logistics"; // what changes you want 

            //var rowsAffected = context.SaveChanges();// return 

            //tql = context.Customers.Find(36); // read the data
            //context.Customers.Remove(tql); // deletes the row (what you want to delete goes in here) 
            //rowsAffected = context.SaveChanges(); // returns rows affected and saves changes 




            var orders = context.Orders.ToList(); // viewing all the order data with customer 
        }



    }
}
