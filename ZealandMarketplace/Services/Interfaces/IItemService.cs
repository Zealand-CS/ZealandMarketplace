using ZealandMarketplace.Models;

namespace ZealandMarketplace.Services.Interfaces;

public interface IItemService
{
    IEnumerable<Item> GetItems();
}