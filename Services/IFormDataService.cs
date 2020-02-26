using Hanover.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Hanover.Services
{
    public interface IFormDataService
    {
            List<SelectListItem> GetLocations();
            List<SelectListItem> GetClientTypes();
            List<SelectListItem> GetOrderStages();
            List<OrderProductVM> GetProducts();
     
    }
}