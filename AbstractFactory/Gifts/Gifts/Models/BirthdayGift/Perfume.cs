using Gifts.Extensions;

namespace Gifts.Models.BirthdayGift;

public class Perfume : IGift
{
    public string Type => "Perfume";

    public string Occassion => "Birthday";

    public string GiftSet(IPostcard postcard, IPackaging packaging)
    {
        return this.GetGiftSet(postcard, packaging);
    }
}