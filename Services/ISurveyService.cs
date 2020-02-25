using Hanover.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hanover.Services
{
    public interface ISurveyService
    {
        List<SurveyProduct> GetSurveyProducts();
        void IncreaseVoteCount(int productId);
    }
}
