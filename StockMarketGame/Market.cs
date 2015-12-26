﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketGame
{
    public class Market
    {
        public int Index { get; set; }

        public int Price(Stock stock)
        {
            return (stock.TopPrice - stock.BottomPrice) / this.Index;
        }

        public Market()
        {
        }

        public void Move(int marketMovement)
        {
            this.Index += marketMovement;
        }
    }
}