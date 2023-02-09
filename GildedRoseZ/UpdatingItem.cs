namespace GildedRoseZ
{
    internal class UpdatingItem : Item
    {
        public int SellIn { get; set; }

        public override void Update()
        {
            UpdateQuality();
            UpdateSellIn();
        }

        protected virtual void UpdateQuality()
        {
            if (Quality > 0)
            {
                var reduction = SellIn < 1 ? 2 : 1;
                Quality = Math.Max(Quality - reduction, 0);
            }
        }

        protected void UpdateSellIn()
        {
            SellIn--;
        }
    }
}
