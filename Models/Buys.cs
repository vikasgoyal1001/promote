using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Buys
    {
		private Dictionary<string, int> _items;

		public Buys(Dictionary<string, int> Items)
		{
			this.Items = Items;
		}

		public Dictionary<string, int> Items
		{
			get { return _items; }
			set { _items = value; }
		}


	}
}
