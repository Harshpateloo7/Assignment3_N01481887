﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment3_N01481887.Models
{
    public class SchoolDbContext
    {
        //These are readonly "secret" properties. 
        //Only the TeachersDBContext class can use them.
        //Change these to match your own local blog database!
        private static string User { get { return "root"; } }
        private static string Password { get { return "root"; } }
        private static string Database { get { return "blog"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }
        //ConnectionString is a series of credentials used to connect to the database.
        protected static string ConnectionString
        {
            get
            {
                // Convert Zero Datetime is a setting that will interpret a 0000-00-00 as null
                // This makes it easier for C# to convert to a proper DateTime type
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password
                    + "; convert zero datetime = True";
            }
        }
        //This is the method we actually use to get the database!
        /// <summary>
        /// Returns a connection to the blog database.
        /// </summary>
        /// <example>
        /// private BlogDbContext Blog = new BlogDbContext();
        /// MySqlConnection Conn = Blog.AccessDatabase();
        /// </example>
        /// <returns>A MySqlConnection Object</returns>
        public MySqlConnection AccessDatabase()
        {
            //We are instantiating the MySqlConnection Class to create an object
            //the object is a specific connection to our blog database on port 3306 of localhost
            return new MySqlConnection(ConnectionString);
        }

    }
}