using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class SKU
    {
        public SKU(string sKUId, int unitPrice)
        {
            SKUId = sKUId;
            UnitPrice = unitPrice;
        }

        public string SKUId { get; set; }
        public int UnitPrice { get; set; }
    }
}
