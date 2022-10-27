using Gifts.Extensions;

namespace Gifts.Models.EasterGift;

public class ChocolateEasterBunny : IGift
{
    public string Type { get => "Chocolate Easter bunny"; }
    public string Occassion { get => "Easter"; }

    public string GiftSet(IPostcard postcard, IPackaging packaging) 
    {
        return this.GetGiftSet(postcard, packaging);
    }
}