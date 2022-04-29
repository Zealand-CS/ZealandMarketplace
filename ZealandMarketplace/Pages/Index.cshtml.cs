using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZealandMarketplace.Models;
using ZealandMarketplace.Services.Interfaces;

namespace ZealandMarketplace.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private IItemService _itemService;
    public IEnumerable<Item> Items { get; set; }

    public IndexModel(ILogger<IndexModel> logger, IItemService service)
    {
        _logger = logger;
        _itemService = service;
    }


    public void OnGet()
    {
        Items = _itemService.GetItems();
    }
}