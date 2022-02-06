using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }
        
        public void UpdateQuality()
        {
            AgedBrie Brie = new AgedBrie();
            DexterityVestAndElixir vest = new DexterityVestAndElixir();
            Sulfuras sulfuras = new Sulfuras();
            BackstagePassesConcert BackstageConcert = new BackstagePassesConcert();
            ConjuredCake ConjuredManaCake = new ConjuredCake();
            Elixir Elixir = new Elixir();
            
            
            for (var i = 0; i < Items.Count; i++)
            {
                string[] ListOfSplitItemName = Items[i].Name.Split(' ');
                switch (Items[i].Name)
                {
                    case "Aged Brie":
                        if (ListOfSplitItemName[0] == "Conjured")
                        {
                            Brie.UpdateAgedBrie(Items[i]);
                        }
                        Brie.UpdateAgedBrie(Items[i]);
                        break;
                    
                    case "+5 Dexterity Vest":
                        if (ListOfSplitItemName[0] == "Conjured")
                        {
                            vest.UpdateDexterityVest(Items[i]);
                        }
                        vest.UpdateDexterityVest(Items[i]);
                        break;
                    
                    case "Elixir of the Mongoose":
                        if (ListOfSplitItemName[0] == "Conjured")
                        {
                            Elixir.UpdateElixir(Items[i]);
                        }
                        Elixir.UpdateElixir(Items[i]);
                        break;
                    
                    case "Sulfuras, Hand of Ragnaros" :
                        if (ListOfSplitItemName[0] == "Conjured")
                        {
                            sulfuras.UpdateSulfuras(Items[i]);
                        }
                        sulfuras.UpdateSulfuras(Items[i]);
                        break;
                    
                    case "Backstage passes to a TAFKAL80ETC concert":
                        if (ListOfSplitItemName[0] == "Conjured")
                        {
                            BackstageConcert.UpdateBacksatagePassesConcert(Items[i]);
                        }
                        BackstageConcert.UpdateBacksatagePassesConcert(Items[i]);
                        break;
                    
                    case "Conjured Mana Cake":
                        
                        ConjuredManaCake.UpdateConjuredCake(Items[i]);
                        break;
                    
                    default:
                        if (ListOfSplitItemName[0] == "Conjured")
                        {
                            if (ListOfSplitItemName[1] == "Aged")
                            {
                                Brie.UpdateConjuredAgedBrie(Items[i]);
                            }
                            if (ListOfSplitItemName[2] == "Dexterity")
                            {
                                vest.UpdateConjuredDexterityVest(Items[i]);
                            }
                            if (ListOfSplitItemName[1] == "Elixir")
                            {
                                Elixir.UpdateConjuredElixir(Items[i]);
                            }
                            if (ListOfSplitItemName[1] == "Backstage")
                            {
                                BackstageConcert.UpdateConjuredBacksatagePassesConcert(Items[i]);
                            }
                        }

                        break;
                    
                    
                        
                }
                Items[i].SellIn = Items[i].SellIn - 1;
                
            }

            
        }
    }

    public class AgedBrie
    {
        public void UpdateAgedBrie(Item item)
        {
            if (item.SellIn > 0 && item.Quality<50)
            {
                item.Quality = item.Quality + 1;  
            }
                        
            if (item.SellIn <= 0 && item.Quality<50)
            {
                item.Quality = item.Quality + 2;  
            }
            
        }
        
        public void UpdateConjuredAgedBrie(Item item)
        {
            if (item.SellIn > 0 && item.Quality<50)
            {
                item.Quality = item.Quality + 2;  
            }
                        
            if (item.SellIn <= 0 && item.Quality<50)
            {
                item.Quality = item.Quality + 4;  
            }
            
        }
    }

    public class DexterityVestAndElixir
    {
        public void UpdateDexterityVest(Item item)
        {
            if (item.Quality < 50 && item.Quality >0)
            {
                item.Quality = item.Quality - 1;  
            }
            if (item.SellIn <= 0 && item.Quality >0)
            {
                item.Quality = item.Quality - 2;  
            }
        }
        
        public void UpdateConjuredDexterityVest(Item item)
        {
            if (item.Quality < 50 && item.Quality >0)
            {
                item.Quality = item.Quality - 2;  
            }
            if (item.SellIn <= 0 && item.Quality >0)
            {
                item.Quality = item.Quality - 4;  
            }
        }
    }
    
    public class Elixir
    {
        public void UpdateElixir(Item item)
        {
            if (item.Quality < 50 && item.Quality >0)
            {
                item.Quality = item.Quality - 1;  
            }
           
        }
        public void UpdateConjuredElixir(Item item)
        {
            if (item.Quality < 50 && item.Quality >0)
            {
                item.Quality = item.Quality - 2;  
            }
           
        }
    }

    public class Sulfuras
    {
        public void UpdateSulfuras(Item item)
        {
            item.Quality = 80;
            item.SellIn += 1;
        }
    }

    public class BackstagePassesConcert
    {
        public void UpdateBacksatagePassesConcert(Item item)
        {
            if (item.Quality < 50 && item.SellIn < 6)
            {
                item.Quality = item.Quality +3 ;
                if (item.Quality > 50)
                {
                    item.Quality = 50 ;
                }
            }

            if (item.Quality < 50 && item.SellIn >= 6 && item.SellIn < 11)
            {
                item.Quality = item.Quality +2 ;  
                if (item.Quality > 50)
                {
                    item.Quality = 50 ;
                }
            }
                        
            if (item.Quality < 50 && item.SellIn >= 11)
            {
                item.Quality = item.Quality + 1;
            }

            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }
        }
        
        public void UpdateConjuredBacksatagePassesConcert(Item item)
        {
            if (item.Quality < 50 && item.SellIn < 6)
            {
                item.Quality = item.Quality +3 ;
                if (item.Quality > 50)
                {
                    item.Quality = 50 ;
                }
            }

            if (item.Quality < 50 && item.SellIn >= 6 && item.SellIn < 11)
            {
                item.Quality = item.Quality +4 ;  
                if (item.Quality > 50)
                {
                    item.Quality = 50 ;
                }
            }
                        
            if (item.Quality < 50 && item.SellIn >= 11)
            {
                item.Quality = item.Quality + 2;
            }

            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }
        }
    }

    public class ConjuredCake
    {
        public void UpdateConjuredCake(Item item)
        {
            if (item.Quality < 50 && item.Quality >0 && item.SellIn >0)
            {
                item.Quality = item.Quality - 1;  
            }
            if (item.SellIn <= 0 && item.Quality >0)
            {
                item.Quality = item.Quality - 2;  
            }

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
