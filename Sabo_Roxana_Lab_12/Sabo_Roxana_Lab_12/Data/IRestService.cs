using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sabo_Roxana_Lab_12.Models;

namespace Sabo_Roxana_Lab_12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
