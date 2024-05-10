/*
 * database.cs
 * This file is meant to handle connecting to the remote server
 * where the database design and data is located.
 * Created by Michael Post
 * Created on May 2, 2024
 */

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace CSCI455ProjectActual
{
    /// <summary>
    /// Creates a class to initilize the connection to the database
    /// </summary>
    internal class Database
    {
        static readonly string server = "sql5.freesqldatabase.com";
        static readonly string user = "sql5703611";
        static readonly string password = "HmvTQjaPi9";
        static readonly string database = "sql5703611";
        public static string connection_string = "server='" + server + "'; user= '" + user + "'; database= '" + database + "'; password= '" + password + "'";
        public MySqlConnection mySqlConnection = new MySqlConnection(connection_string);
        /// <summary>
        /// Opens a connection to the data base
        /// </summary>
        public bool connect_db()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// closes the database connection
        /// </summary>
        public bool close_db()
        {
            try
            {
                mySqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
