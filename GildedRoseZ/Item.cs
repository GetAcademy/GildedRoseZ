namespace GildedRoseZ
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update()
        {
            UpdateQuality();
            UpdateSellIn();
        }

        protected void UpdateSellIn()
        {
            SellIn--;
        }

        protected virtual void UpdateQuality()
        {
            if (Quality > 0)
            {
                var reduction = SellIn < 1 ? 2 : 1;
                Quality = Math.Max(Quality - reduction, 0);
            }
        }
    }
}
