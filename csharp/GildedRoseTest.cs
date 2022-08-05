using ApprovalTests;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            string[] names = new string[]
            {
                "foo",
                "Aged Brie",
                "Backstage passes to a TAFKAL80ETC concert",
                "Sulfuras, Hand of Ragnaros"
            };
            int[] sellIns = Enumerable.Range(-1, 15).ToArray();
            int[] qualities = new int[] { 0, 1, -1, 49, 50, 51 };

            CombinationApprovals.VerifyAllCombinations(DoStuff, names, sellIns, qualities);
        }

        private static string DoStuff(string name, int sellIn, int quality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = sellIn, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            string result = app.Items[0].ToString();
            return result;
        }

        [Test]
        public void Conjured()
        {
            Approvals.Verify(DoStuff("Conjured Pot", 10, 2));
        }
    }
}
