using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_DinnerParty
{
    class DinnerParty
    {

        /*public int NumberOfPeople = 0;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations;
        public const int CostOfFoodPerPerson = 25;

        public void SetHealthyOption(bool isHealthy)
        {
            if (isHealthy)
            {
                CostOfBeveragesPerPerson = 5m;
            }
            else
            {
                CostOfBeveragesPerPerson = 20m;
            }
        }

        public void CalculateCostOfDecorations(bool useFancyDecorations)
        {
            if (useFancyDecorations)
            {
                CostOfDecorations = 15m * NumberOfPeople + 50m;
            }
            else
            {
                CostOfDecorations = 7.5m * NumberOfPeople + 30m;
            }
        }

        public decimal CalculateCost(bool isHealthy)
        {
            decimal wholePrice = (CostOfFoodPerPerson + CostOfBeveragesPerPerson) * NumberOfPeople + CostOfDecorations;
            if (isHealthy)
            {
                return wholePrice * 0.95m;
            }
            return wholePrice;
        }

        public void SetPartyOptions(int numberOfPeople, bool useFancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            CalculateCostOfDecorations(useFancyDecorations);
        }

        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }

        }*/

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public decimal Cost { 
            get {
                decimal totalCost = (25m + CalculateCostOfBeveragesPerPerson()) * NumberOfPeople + CalculateCostOfDecorations();
                if (HealthyOption)
                {
                    return totalCost *= 0.95m;
                }
                return totalCost;
            }
        }

        public DinnerParty(int numberOfPoeple, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPoeple;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        private decimal CalculateCostOfDecorations()
        {
            if (FancyDecorations)
            {
                return 15m * NumberOfPeople + 50m;
            }
            return 7.5m * NumberOfPeople + 30m;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            if (HealthyOption)
            {
                return 5m;
            }
            return 20m;
        }
    }
}
