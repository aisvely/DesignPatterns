using Gifts;
using Gifts.Factories;

var easterGiftFactory = new EasterGiftFactory();
var manager = new GiftManager(easterGiftFactory);
manager.OrderGift();