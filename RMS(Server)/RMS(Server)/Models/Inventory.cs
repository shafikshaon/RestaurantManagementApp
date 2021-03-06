﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RMS_Server_.Models
{
    public class Inventory
    {
        public string Id { get; set; }
        public List<InventoryHistoryModel> InventoryHistoryModel { get; set; }
        public string Name { get; set; }
        public float UsedQuantity { get; set; }
        public float RemainingQuantity { get; set; }  
        public string Unit { get; set; }
        public int AveragePrice { get; set; }
      
    }
}