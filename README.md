# MIKOLAJCZAK_Antoine_TP5_ST2TRD


TP 5

Part 1

1.What is this code about?

This code is about the regulation of an inventory for a warehouse business. It controls and regule the quality of all products which are sold by this warehouse. Clearly the main goal of this code is to show and display the quality and the expiry time of products in the inventory. This program is running during 30 days.

2.Can you clearly identify the name of all the goods stored in the Guilded Rose?

This code is not so clear but at least we are able to identify the name of all goods stored in the Gilded Rose. All the goods are stored in an Item list. The name of all the goods is:
-	+5 Dexterity vest 
-	Aged Brie
-	Elixir of the Mongoose
-	Sulfuras, Hand of Ragnaros 
-	Backstage passes to a TAKFAL80ETC concert 
-	Conjured Mana Cake 

3.What happens when the day is over?

This part of the code is not so clear … At the end of each day the quality of all products is updated, increase, decrease or staying at the same value, it depends on the product. This is manage in the code via the function called “UpdateQuality()” in the “GuildedRose.cs” file / class.The expiry time is updated too with this function.

4.What happens to cheese when the day is over?

At the end of the day, the quality of the cheese which is called “aged Brie” is updated. The fact is the more the time go and higher is the quality of this cheese. Its quality increase with the time. The quality increase by one each day if the sellin is higher than 0 and by 2 if the sellin is bellow to 0.

5.What happens when a concert ticket goes over its expiration day?

When a concert ticket goes over its expiration day, its quality is put to zero with a subtraction. So, after the expiration date, the value / quality of a concert ticket is zero.

6.What makes this code hard to read?

This code is really hard to read and to understand due to big big condition statements. There are too many if / else conditions, due to this it’s so hard to understand. 
After this many things are implemented in the main class so it’s not really efficient to understand the way of functioning of this program. Perhaps it should be smarter to split all of that in some other class / file.
The rest of the code is barely OK but not so understandable.



7.Do you think the rules are clear enough so that you could rework the entire solution from scratch?

I think the rules are pretty clear in the abstract about the topic, the products and the management of the quality and expiry date. But with a critically look, some information is missing in order to implement this code from scratch. Especially concerning the new product of this tavern, the conjured object. It is not clear if it is a attribute of every other products which are existing of just another casual product with its own property…


Part 2 : Tests 

In this part we are supposed to create more or less tens test with the AAA test pattern to test limit case of the guilded rose test. 
The benefit of testing the code by this way is, first to erase errors with limit case. And second it allows to test a really precise part of the code in a really fast way and do it often. It’s really efficient in term of time and complexity cause it’s not difficult to implement once the code is understood. With this kind of tests we are sure that the code doesn’t crash with particular case.

Part 3 : refactoring 

In this part of the TP we were allow to modify the code in order to make it better and more readable. 
So I choose to remove all the if else statement in the “UpdateQuality()” function and replace it with a switch case statement set on the name of the item. By this way the code is more readable, then I create a class for every kind of items where I implemented a function to update quality and expiration date.

Part 4 : up up and away 

In this part of the TP I have implemented a solution to manage Conjured Items. I chose to use the default case of my switch to test if the Item is conjured and after with some if conditions, I manage each items. 
To do this, I chose to implement new functions for each conjured Items in their own classes and I call theses functions in the default case of my switch. This is how work my management of conjured items. 
But I wrote a special finction for the Item “Conjured mana” cause the basic item was not describe in the syllabus paper. So I managed it like a not conjured Item in the code. 

First way of improvement of the code : 

To my mind it would be smart to modify the Item.cs file / class in order add a conjured attribute. With this attribute, it should be easier to manage it with the switch case I implemented just before. This attribute will permit to test easily if the item is conjured. 

Second way of improvement of the code : 

This code is wrote in order to manage a tavern, but here we just manage some items with their expiry date and their quality. But to my mind it could be great to implement a new file / class which manage transactions and selling. To do that we could find a function which earase the item from the stock once its selling. Another function which manage the transaction money of the selling. 
This class seems to be interesting for me because a tavern is a place where products are sold.

Third way of improvement of the code : 

It could be good to implement a class which make some statistics about items available in the tavern. A function of this class should be able to sort out all the products on their quality or their expiry date.  Due to this it would be easier to manage a huge quantity of items and not just a few like there is in the main for the moment.
