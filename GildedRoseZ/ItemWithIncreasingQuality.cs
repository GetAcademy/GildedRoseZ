namespace GildedRoseZ
{
    internal class ItemWithIncreasingQuality : UpdatingItem
    {
        protected override void UpdateQuality()
        {
            Quality = Math.Min(Quality + 1, 50);
        }
    }
}
