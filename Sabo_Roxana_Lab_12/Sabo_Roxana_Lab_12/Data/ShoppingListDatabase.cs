using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sabo_Roxana_Lab_12;
using Sabo_Roxana_Lab_12.Models;

namespace Sabo_Roxana_Lab_12.Data
{
    public class ShoppingListDatabase
    {
        IRestService restService;

        public RestService RestService { get; }

        public ShoppingListDatabase(IRestService service)
        {
            restService = service;
        }

        public ShoppingListDatabase(RestService restService1)
        {
            RestService = restService1;
        }

        public Task<List<ShopList>> GetShopListsAsync()
        {
            return restService.RefreshDataAsync();
        }

        public Task SaveShopListAsync(ShopList item, bool isNewItem = true)
        {
            return restService.SaveShopListAsync(item, isNewItem);
        }
        public Task DeleteShopListAsync(ShopList item)
        {
            return restService.DeleteShopListAsync(item.ID);
        }

    }
}
