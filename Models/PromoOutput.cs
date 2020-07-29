using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class PromoOutput
    {
        public double PercentageOff { get; set; }

        public double discount { get; set; }

		private Dictionary<string, int> _items;

		public Dictionary<string, int> Items
		{
			get { return _items; }
			set { _items = value; }
		}

	}
}
