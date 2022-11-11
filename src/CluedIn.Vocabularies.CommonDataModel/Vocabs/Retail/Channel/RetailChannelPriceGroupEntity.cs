using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailChannelPriceGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailChannelPriceGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailChannelPriceGroupEntity";
            KeyPrefix = "commonDataModel.retailchannelpricegroupentity";
            KeySeparator = ".";
            Grouping = "/RetailChannelPriceGroupEntity";

            AddGroup("Common Data Model RetailChannelPriceGroupEntity Details", group =>
            {
                GroupCode = group.Add(new VocabularyKey(nameof(GroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelId = group.Add(new VocabularyKey(nameof(RetailChannelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupCode { get; private set; }
        public VocabularyKey RetailChannelId { get; private set; }


    }
}