using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailAssortmentLookupChannelGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailAssortmentLookupChannelGroupEntityVocabulary()
        {
            VocabularyName = "Retail Assortment Lookup Channel Group Entity";
            KeyPrefix = "commonDataModel.retailassortmentlookupchannelgroupentity";
            KeySeparator = ".";
            Grouping = "/RetailAssortmentLookupChannelGroupEntity";

            AddGroup("RetailAssortmentLookupChannelGroupEntity Details", group =>
            {
                AssortmentId = group.Add(new VocabularyKey(nameof(AssortmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelId = group.Add(new VocabularyKey(nameof(RetailChannelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AssortmentId { get; private set; }
        public VocabularyKey RetailChannelId { get; private set; }
    }
}