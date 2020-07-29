using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Cart
    {
		
		private Dictionary<string, int> _cartItems;

		public Cart( Dictionary<string, int> cartItems)
		{
			this.cartItems = cartItems;
		}

		public Dictionary<string, int> cartItems
		{
			get { return _cartItems; }
			set { _cartItems = value; }
		}


	}
}
