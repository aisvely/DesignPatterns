using Gifts;
using Gifts.Factories;

var easterGiftFactory = new EasterGiftFactory();
var manager = new GiftManager(easterGiftFactory);
manager.OrderGift();

Console.WriteLine();

var birthdayGiftFactory = new BirthdayGiftFactory();
manager = new GiftManager(birthdayGiftFactory);
manager.OrderGift();