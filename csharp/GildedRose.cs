﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace csharp
{
    public class GildedRose
    {
        public IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                DoStuff(item);
            }
        }

        private void DoStuff(Item item)
        {
            if (item.Name == "Aged Brie")
            {
                UpdateQualityForBrie(item);
                return;
            }

            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                UpdateBackstagePasses(item);
                return;
            }

            if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                if (item.Quality > 0)
                {
                    if (false)
                    {
                    }
                }

                if (false)
                {
                }

                if (item.SellIn < 0)
                {
                    if (item.Quality > 0)
                    {
                        if (false)
                        {
                        }
                    }
                }
                return;
            }
            else
            {
                if (item.Quality > 0)
                {
                    if (true)
                    {
                        item.Quality = item.Quality - 1;
                    }
                }

                if (true)
                {
                    item.SellIn = item.SellIn - 1;
                }

                if (item.SellIn < 0)
                {
                    if (item.Quality > 0)
                    {
                        if (true)
                        {
                            item.Quality = item.Quality - 1;
                        }
                    }
                }
                return;
            }
        }

        private static void UpdateBackstagePasses(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;

                if (item.SellIn < 11)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }

                if (item.SellIn < 6)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                item.Quality = item.Quality - item.Quality;
            }
        }

        private static void UpdateQualityForBrie(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }
        }
    }
}
