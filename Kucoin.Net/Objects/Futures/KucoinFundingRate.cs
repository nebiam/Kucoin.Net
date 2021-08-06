﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kucoin.Net.Objects.Futures
{
    /// <summary>
    /// Funding rate info
    /// </summary>
    public class KucoinFundingRate: KucoinIndexBase
    {
        /// <summary>
        /// Predicted value
        /// </summary>
        public decimal PredictedValue { get; set; }
    }
}
