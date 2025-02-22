using Shopify.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopify.BussinessLogic
{
    public class ProductService
    {
        DbContext context;
        public ProductService(string connectionString)
        {
            context = new DbContext(connectionString);
        }
        public DataTable getProducts()
        {
            string query = "select p.ProductId as ID, p.ProductName Product, p.Price, c.CategoryName Category from Products p, Categories c where p.CategoryId = c.CategoryId";
            DataTable products = context.ExecuteQuery(query);
            return products;
        }
        public DataTable getProductsByIds(string ids)
        {
            string query = $"select * from Products where ProductId in ({ids})";
            DataTable products = context.ExecuteQuery(query);
            return products;
        }
        public int insertProduct(string productName, double price, int category)
        {
            string query = $"insert into Products(productName, Price, CategoryId) values('{productName}',{price},{category})";
            int x = context.ExecuteNonQuery(query);
            return x;
        }
        public int updateProduct(int id, string productName, double price, int category)
        {
            string query = $"update products set ProductName = '{productName}', Price = {price},CategoryId = {category} where ProductId = {id}";
            int x = context.ExecuteNonQuery(query);
            return x;
        }
        public int deleteProduct(int id)
        {
            string query = $"delete from products where productId = {id}";
            int x = context.ExecuteNonQuery(query);
            return x;
        }
        
    }
}
