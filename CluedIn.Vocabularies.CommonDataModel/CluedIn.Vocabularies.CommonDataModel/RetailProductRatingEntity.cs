using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailProductRatingEntityVocabulary : SimpleVocabulary
    {
        public RetailProductRatingEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailProductRatingEntity";
            KeyPrefix = "commonDataModel.retailproductratingentity";
            KeySeparator = ".";
            Grouping = "/RetailProductRatingEntity";

            AddGroup("Common Data Model RetailProductRatingEntity Details", group =>
            {
                ProductId = group.Add(new VocabularyKey(nameof(ProductId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MasterProductId = group.Add(new VocabularyKey(nameof(MasterProductId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChannelId = group.Add(new VocabularyKey(nameof(ChannelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Rating = group.Add(new VocabularyKey(nameof(Rating), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalRatings = group.Add(new VocabularyKey(nameof(TotalRatings), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProductId { get; private set; }
public VocabularyKey MasterProductId { get; private set; }
public VocabularyKey ChannelId { get; private set; }
public VocabularyKey Rating { get; private set; }
public VocabularyKey TotalRatings { get; private set; }


    }
}