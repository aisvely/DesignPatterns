using Gifts.Models;
using Gifts.Models.EasterGift;

namespace Gifts.Factories;

public class EasterGiftFactory : IGiftFactory
{
    public IGift CreateGift()
    {
        return new ChocolateEasterBunny();
    }

    public IPostcard CreatePostcard()
    {
        return new EasterPostcard();
    }

    public IPackaging CreatePackaging()
    {
        return new WovenBasket();
    }
}