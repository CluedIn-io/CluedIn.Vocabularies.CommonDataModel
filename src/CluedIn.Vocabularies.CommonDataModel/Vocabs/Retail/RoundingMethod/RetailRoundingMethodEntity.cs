using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailRoundingMethodEntityVocabulary : SimpleVocabulary
    {
        public RetailRoundingMethodEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailRoundingMethodEntity";
            KeyPrefix = "commonDataModel.retailroundingmethodentity";
            KeySeparator = ".";
            Grouping = "/RetailRoundingMethodEntity";

            AddGroup("Common Data Model RetailRoundingMethodEntity Details", group =>
            {
                AmountAddedAfter = group.Add(new VocabularyKey(nameof(AmountAddedAfter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountAddedBefore = group.Add(new VocabularyKey(nameof(AmountAddedBefore), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Minimum = group.Add(new VocabularyKey(nameof(Minimum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Precision = group.Add(new VocabularyKey(nameof(Precision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoundingMethodId = group.Add(new VocabularyKey(nameof(RoundingMethodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoundingType = group.Add(new VocabularyKey(nameof(RoundingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AmountAddedAfter { get; private set; }
public VocabularyKey AmountAddedBefore { get; private set; }
public VocabularyKey Minimum { get; private set; }
public VocabularyKey Precision { get; private set; }
public VocabularyKey RoundingMethodId { get; private set; }
public VocabularyKey RoundingType { get; private set; }


    }
}