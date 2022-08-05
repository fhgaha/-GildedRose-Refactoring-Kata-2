using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ApprovalTests;
using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace csharp
{
    [UseReporter(typeof(DiffReporter))]
    [TestFixture]
    public class ApprovalTest 
    {
        //[Test]
        //public void ThirtyDays()
        //{
        //    StringBuilder fakeoutput = new StringBuilder();
        //    Console.SetOut(new StringWriter(fakeoutput));
        //    Console.SetIn(new StringReader("a\n"));

        //    Program.Main(new string[] { });
        //    var output = fakeoutput.ToString();

        //    Approvals.Verify(output);
        //}

        [Test]
        public void foo()
        {
            string[] names = new string[] { "foo", "Aged Brie", "Backstage passes to a TAFKAL80ETC concert" };
            int[] qualities = new int[] { 0 };
            CombinationApprovals.VerifyAllCombinations(DoStuff, names, qualities);
        }

        private static string DoStuff(string name, int quality)
        {
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = 0, Quality = quality } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            string result = app.Items[0].ToString();
            return result;
        }
    }
}
