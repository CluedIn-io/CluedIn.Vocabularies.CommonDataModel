using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailAssortmentLookupChannelGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailAssortmentLookupChannelGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailAssortmentLookupChannelGroupEntity";
            KeyPrefix = "commonDataModel.retailassortmentlookupchannelgroupentity";
            KeySeparator = ".";
            Grouping = "/RetailAssortmentLookupChannelGroupEntity";

            AddGroup("Common Data Model RetailAssortmentLookupChannelGroupEntity Details", group =>
            {
                AssortmentId = group.Add(new VocabularyKey(nameof(AssortmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailChannelId = group.Add(new VocabularyKey(nameof(RetailChannelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AssortmentId { get; private set; }
public VocabularyKey RetailChannelId { get; private set; }


    }
}