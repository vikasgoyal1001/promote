using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PromotionEngineController
    {
        List<Promotion> _promotions = new List<Promotion>();
        Dictionary<SKU, Promotion> SKUPromotionMapping = new Dictionary<SKU, Promotion>();

        public void InitialDataSetUp()
        {
            // Setting up the SKU
            

            var CandDPromo = new Promotion(3, "C and D for 30", Enums.PromoCat.ComboDiscount);
            SKUPromotionMapping.Add(new SKU("A", 50), new Promotion(1,"3 A's for 130",Enums.PromoCat.BulkDiscount));
            SKUPromotionMapping.Add(new SKU("B", 30), new Promotion(2, "2 B's for 130", Enums.PromoCat.BulkDiscount));
            SKUPromotionMapping.Add(new SKU("C", 20), CandDPromo);
            SKUPromotionMapping.Add(new SKU("D", 15), CandDPromo);
        }

        

        private List<Promotion> getPromotionList(Cart cart)
        {
            var promoList = new List<Promotion>();
            foreach (var item in cart.cartItems)
            {
                if (SKUPromotionMapping.Select(a => a.Key.SKUId == item.Key).First())
                { 
                    
                }
            }
        }
        public int CalculateGrossAmount(Cart cart)
        {

            var promoList = getPromotionList(cart);
            foreach (var promo in promoList)
            {
                if (cart.cartItems.Count == 0)
                {
                    break;
                }

                else
                {
                    if (Enums.PromoCat.FIXED == promo.promotionCategory)
                    {

                    }
                    
                    
                }
            }

            return 0;

        }
    }
}
