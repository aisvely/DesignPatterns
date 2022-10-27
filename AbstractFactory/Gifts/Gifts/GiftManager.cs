using Gifts.Factories;
using Gifts.Models;

namespace Gifts;

public class GiftManager
{
    private IGift _gift;
    private IPostcard _postcard;
    private IPackaging _packaging;

    public GiftManager(IGiftFactory giftFactory)
    {
        _gift = giftFactory.CreateGift();
        _postcard = giftFactory.CreatePostcard();
        _packaging = giftFactory.CreatePackaging();
    }

    public void OrderGift()
    {
        Console.WriteLine($"Ordering gift for {_gift.Occassion}...");
        Console.WriteLine(_gift.GiftSet(_postcard, _packaging));
    }
}