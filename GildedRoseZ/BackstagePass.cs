using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseZ
{
    internal class BackstagePass : ItemWithIncreasingQuality
    {
        /*
          Quality increases by 2 when there are 10 days or less 
          and by 3 when there are 5 days or less 
        
          but Quality drops to 0 after the concert
         */

        protected override void UpdateQuality()
        {
            if (SellIn < 0)
            {
                Quality = 0;
                return;
            }

            if (SellIn > 10)
            {
                base.Update();
            }

            var increase = SellIn <= 5 ? 3 : 2;
            Quality = Math.Min(Quality + increase, 50);
        }
    }
}
