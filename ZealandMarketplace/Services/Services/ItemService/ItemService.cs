using ZealandMarketplace.Models;
using ZealandMarketplace.Services.Interfaces;

namespace ZealandMarketplace.Services.Services.ItemService;

public class ItemService : IItemService
{
    private ADOItem service;

    public ItemService(ADOItem adoItem)
    {
        service = adoItem;
    }
    
    public IEnumerable<Item> GetItems()
    {
        return service.GetItems();
    }
}