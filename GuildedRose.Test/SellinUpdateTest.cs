using System;
using System.Collections;

using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace GuildedRose.Test
{
    [TestFixture]
    public class SellinUpdateTest
    {
        [Test]
        public void SellinDecreaseByOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 5, Quality = 2},
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            
            Assert.AreEqual(4, Items[0].SellIn);
        }
    }
}