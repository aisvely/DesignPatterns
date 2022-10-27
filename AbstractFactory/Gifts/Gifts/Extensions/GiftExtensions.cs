using Gifts.Models;

namespace Gifts.Extensions;

public static class GiftExtensions
{
    public static string GetGiftSet(this IGift gift, IPostcard postcard, IPackaging packaging)
    {
        return $"Gift: {gift.Type} \n" +
                $"Postcard greeting: {postcard.Greeting} \n" +
                $"Packaging: {packaging.Type}";
    }
}
