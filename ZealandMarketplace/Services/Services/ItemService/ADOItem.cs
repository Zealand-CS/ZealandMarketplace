using ZealandMarketplace.Models;
using Microsoft.Data.SqlClient;

namespace ZealandMarketplace.Services.Services.ItemService;

public class ADOItem
{
    public IConfiguration Configuration { get; }
    public ADOItem(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    
    public List<Item> GetItems()
    {
        List<Item> items = new List<Item>();
        using (SqlConnection conn = new SqlConnection(Configuration.GetConnectionString("Azure")))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM item", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item item = new Item();
                        item.Name = reader["name"].ToString();
                        item.Id = reader["id"].ToString();
                        items.Add(item);
                    }
                }
            }
        }
        return items;
    }
    
    
}