using System;
using System.Collections;

using System.Collections.Generic;
using csharp;
using NUnit.Framework;

namespace GuildedRose.Test
{
    [TestFixture]
    public class QualityUpdateTest
    {
        
        
        [Test]
        public void QualityShouldNeverBeLowerThanZero()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 0},
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            
            Assert.AreEqual(0, Items[0].Quality);
        }

        
        [Test]
        public void QualityShouldNeverBeUpperThanFifty()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 10, Quality = 50},
            };
            
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality); 

        }

        [Test]
        public void QualityOfSulfurasEqualToEighty()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80},
            };
            
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(80, Items[0].Quality);
            
        }
        
        
        [Test]
        public void QualityOfBrieShouldBePlusOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 10, Quality = 20},
            };
            
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(21, Items[0].Quality); 

        }
        
        [Test]
        public void QualityDecreaseTwiceFastWithSellinLowerThanZero()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = -1, Quality = 10},
            };

            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            
            Assert.AreEqual(8, Items[0].Quality);
        }

        [Test]
        public void QualityBackstagePassIncreaseByTwoWhenSellinBetweenTenAndFive()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 8, Quality = 10},
            };
            
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            
            Assert.AreEqual(12, Items[0].Quality);
        }
        
        [Test]
        public void QualityBackstagePassIncreaseByTwoWhenSellinBetweenFiveAndOne()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn =3, Quality = 10},
            };
            
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            
            Assert.AreEqual(13, Items[0].Quality);
        }
        
        [Test]
        public void QualityBackstagePassShouldBeResetAtSellinEqualZero()
        {
            IList<Item> Items = new List<Item>
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn =0, Quality = 10},
            };
            
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            
            Assert.AreEqual(0, Items[0].Quality);
        }
        
        
    }
}