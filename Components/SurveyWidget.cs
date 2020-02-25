using Microsoft.AspNetCore.Mvc;
using Hanover.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hanover.Components
{
    public class SurveyWidget : ViewComponent
    {
        private ISurveyService _surveyService;

        public SurveyWidget(ISurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int productId)
        {
            var products = _surveyService.GetSurveyProducts();

            if (productId > 0)
            {
                _surveyService.IncreaseVoteCount(productId);
                return View("Results", products);
            }

            return View(products);
        }
    }

    public class SurveyProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VoteCount { get; set; }
    }
}
