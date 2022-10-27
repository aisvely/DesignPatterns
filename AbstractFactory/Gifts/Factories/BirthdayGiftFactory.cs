using Gifts.Models;
using Gifts.Models.BirthdayGift;

namespace Gifts.Factories;

public class BirthdayGiftFactory : IGiftFactory
{
    public IGift CreateGift()
    {
        return new Perfume();
    }

    public IPackaging CreatePackaging()
    {
        return new BirthdayBox();
    }

    public IPostcard CreatePostcard()
    {
        return new BirthdayPostcard();
    }
}