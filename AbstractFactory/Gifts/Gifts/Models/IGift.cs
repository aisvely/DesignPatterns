namespace Gifts.Models;

public interface IGift
{
    public string Type { get; }
    public string Occassion { get; }
    string GiftSet(IPostcard postcard, IPackaging packaging);
}