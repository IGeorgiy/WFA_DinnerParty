﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_DinnerParty
{
    class BirthdayParty
    {

        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40M + ActualLength * .25M;
                else
                    cakeCost = 75M + ActualLength * .25M;
                return totalCost + cakeCost;
            }
        }
        public string CakeWriting { get; set; }
        public bool CakeWritingTooLong {
            get 
            {
                if(CakeWriting.Length > MaxWritingLength())
                {
                    return true;
                }
                return false;
            } 
        }
        private int ActualLength
        {
            get
            {
                int mwl = MaxWritingLength();
                if (CakeWriting.Length > mwl)
                {
                    return mwl;
                }
                return CakeWriting.Length;
            }
            set
            {
                ActualLength = value;
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
                costOfDecorations = NumberOfPeople * 15.00M + 50M;
            else
                costOfDecorations = NumberOfPeople * 7.50M + 30M;
            return costOfDecorations;
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
            {
                return 8;
            }
            return 16;
        }

        private int MaxWritingLength()
        {
            if(CakeSize() == 8)
            {
                return 16;
            }
            return 40;
        }

    }
}
