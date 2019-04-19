using EPiServer.Core;

namespace AlloySite20190419.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
