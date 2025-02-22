using Azure;
using Shopify.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shopify.BussinessLogic
{
    public class FavouritesServices
    {
        DbContext context;
        public FavouritesServices(string connectionString)
        {
            context = new DbContext(connectionString);
        }

        public int insertFavourite(int user, int product)
        {
            string query =
              $"insert into Favourites values ({user}, {product});";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }
        public DataTable getFavourites(int user)
        {
            string query =
                $"select p.ProductId ID, p.ProductName Product, p.Price, c.CategoryName Category from Favourites f, Products p, Categories c where f.ProductId = p.ProductId and p.CategoryId = c.CategoryId and UserId = {user}";
            DataTable table = context.ExecuteQuery(query);
            return table;
        }
        public int deleteFavourite(int user, int product)
        {
            string query =
                $"delete from Favourites where UserId ={user} and ProductId ={product}";
            int rowsAffected = context.ExecuteNonQuery(query);
            return rowsAffected;
        }
    }
}
