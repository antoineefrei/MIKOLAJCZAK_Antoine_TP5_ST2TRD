# MIKOLAJCZAK_Antoine_TP5_ST2TRD


1.What is this code about?

This code is about the regulation of an inventory for a warehouse business. It controls and regule the quality of all products which are sold by this warehouse. Clearly the main goal of this code is to show and display the quality and the expiry time of products in the inventory.

2.Can you clearly identify the name of all the goods stored in the Guilded Rose?

This code is not so clear but at least we are able to identify the name of all goods stored in the Gilded Rose. All the goods are stored in an Item list. The name of all the goods is:
-	+5 Dexterity vest 
-	Aged Brie
-	Elixir of the Mongoose
-	Sulfuras, Hand of Ragnaros 
-	Backstage passes to a TAKFAL80ETC concert 
-	Conjured Mana Cake 

3.What happens when the day is over?

This part of the code is not so clear … At the end of each day the quality of all products is updated, increase, decrease or staying at the same value, it depends on the product. This is manage in the code via the function called “UpdateQuality()”.The expiry time is updated too with this function.

4.What happens to cheese when the day is over?

At the end of the day, the quality of the cheese which is called “aged Brie” is updated. The fact is the more the time go and higher is the quality of this cheese. Its quality increase with the time.

5.What happens when a concert ticket goes over its expiration day?

When a concert ticket goes over its expiration day, its quality is put to zero with a subtraction. So, after the expiration date, the value / quality of a concert ticket is zero.

6.What makes this code hard to read?

This code is really hard to read and to understand due to big big condition statements. There are too many if / else conditions, due to this it’s so hard to understand. The rest of the code is barely OK but not so understandable.

7.Do you think the rules are clear enough so that you could rework the entire solution from scratch?

I think the rules are pretty clear in the abstract about the topic, the products and the management of the quality and expiry date. But with a critically look, some information are missing in order to implement this code from scratch.
