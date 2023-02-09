namespace GildedRoseZ
{
    public class Item
    {
        public string Name { get; set; }
        public int Quality { get; set; }

        public virtual void Update()
        {
        }
    }

    /*
    public abstract class Item
    {
        public string Name { get; set; }
        public int Quality { get; set; }

        public abstract void Update();
    }     
     */
}
