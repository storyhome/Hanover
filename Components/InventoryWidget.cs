using Hanover.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hanover.Components
{
    public class InventoryWidget : ViewComponent
    {
        private IInventoryService _inventoryService;

        public InventoryWidget(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int threshold = 10)
        {
          

            return View(_inventoryService.GetInventoryLevels(threshold));
        }
    }

    public class InventoryItem
    {
        public InventoryItem()
        {
        }

        public string Name { get; set; }
        public int Count { get; set; }
    }
}
