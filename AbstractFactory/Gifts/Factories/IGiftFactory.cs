using Gifts.Models;

namespace Gifts.Factories;

public interface IGiftFactory
{
    IGift CreateGift();
    IPostcard CreatePostcard();
    IPackaging CreatePackaging();
}