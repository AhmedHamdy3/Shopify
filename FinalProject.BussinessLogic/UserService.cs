using Azure;
using Shopify.DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shopify.BussinessLogic
{
    public class UserService
    {
        DbContext context;
        public UserService(string connectionString) {
            context = new DbContext(connectionString);
        }
        public int insertUser(string Username, string Email, string Password, int Age, string Address, string role) {
            string query =
                $"insert into users(Username, Password, Email, Age, Address, role) values ('{Username}', '{Password}', '{Email}', {Age}, '{Address}', '{role}');";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }

        public DataTable getUser(string email, string password)
        {
            string query = $"select * from users where Email='{email}' and Password='{password}'";
            DataTable dt = context.ExecuteQuery(query);
            return dt;

        }

        public DataTable getAllUsers()
        {
            string query = $" select UserId ID, Username, Password, Email, Age, Address, Role from users";
            DataTable dt = context.ExecuteQuery(query);
            return dt;

        }

        public DataTable getUserById(int id)
        {
            string query = $"select * from users where UserId = {id}";
            DataTable dt = context.ExecuteQuery(query);
            return dt;
        }
        public int updateUser(int id, string username, string email, int age, string address, string role)
        {
            //int x;
            //messagBox.
            string query = $"update users set Username ='{username}', Email = '{email}', Age = {age}, Address = '{address}', role = '{role}' where userId = {id}";
            int x = context.ExecuteNonQuery(query);
            return x;
        }

        public int updateUserPassword(int id, string password) {
            string query = $"update users set Password ='{password}' where userId = {id}";
            int x = context.ExecuteNonQuery(query);
            return x;
        }

        public int deleteUser(int id)
        {
            string query = $"delete from users where userId = {id}";
            int x = context.ExecuteNonQuery(query);
            return x; ;
        }

        
    }
}
