﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ApprovalTests;
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
            string result = DoStuff();
            Approvals.Verify(result);
        }

        private static string DoStuff()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            string result = app.Items[0].ToString();
            return result;
        }
    }
}
