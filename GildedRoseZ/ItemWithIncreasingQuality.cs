namespace GildedRoseZ
{
    internal class ItemWithIncreasingQuality : Item
    {
        protected override void UpdateQuality()
        {
            Quality = Math.Min(Quality + 1, 50);
        }
    }
}
