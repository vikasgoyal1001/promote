using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Promotion
    {
        public Promotion(int promotionId, string promotionDescription, Enums.PromoCat promotionCategory)
        {
            this.promotionId = promotionId;
            this.promotionDescription = promotionDescription;
            this.promotionCategory = promotionCategory;
        }

        public int promotionId { get; set; }
        public string promotionDescription { get; set; }
        //public Dictionary<string[], int> promo { get; set; }

        public Enums.PromoCat promotionCategory {get; set;}

        //public Dictionary<Buys, PromoOutput> promo { get; set; }

        //public Dictionary<Cart, Enums.PromoCat> PromotionList { get; set; } 


    }
}
