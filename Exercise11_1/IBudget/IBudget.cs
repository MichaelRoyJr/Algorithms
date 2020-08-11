using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBudgetNamespace
{
    public interface IBudget
    {
        void ShowRevenueStats();
        decimal CalculateRevenue();
        decimal CalculateCosts();
        
    }
}
