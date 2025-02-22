using Shopify.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopify.BussinessLogic
{
    public class CategoryServices
    {
        DbContext context;
        public CategoryServices(string connectionString) {
            context = new DbContext(connectionString);
        }
        public DataTable getCategories()
        {
            string query = $"select CategoryId ID, CategoryName Category from Categories";
            DataTable dt = context.ExecuteQuery(query);
            return dt;
        }

        public int deleteCategory(int id)
        {
            string query = $"delete from Categories where CategoryId = {id}";
            int x = context.ExecuteNonQuery(query);
            return x;
        }

        public int insertCategory(string name)
        {
            string query = $"insert into Categories(CategoryName) values('{name}')";
            int x = context.ExecuteNonQuery(query);
            return x;
        }

        public int updateCategory(int id, string name) {
            string query = $"update Categories set CategoryName='{name}' where CategoryId = {id}";
            int x = context.ExecuteNonQuery(query);
            return x;
        }
    }
}
