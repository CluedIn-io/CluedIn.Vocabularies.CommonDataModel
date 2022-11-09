using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailMixAndMatchLineGroupsEntityVocabulary : SimpleVocabulary
    {
        public RetailMixAndMatchLineGroupsEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailMixAndMatchLineGroupsEntity";
            KeyPrefix = "commonDataModel.retailmixandmatchlinegroupsentity";
            KeySeparator = ".";
            Grouping = "/RetailMixAndMatchLineGroupsEntity";

            AddGroup("Common Data Model RetailMixAndMatchLineGroupsEntity Details", group =>
            {
                DiscountLineColor = group.Add(new VocabularyKey(nameof(DiscountLineColor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MixAndMatchOfferId = group.Add(new VocabularyKey(nameof(MixAndMatchOfferId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MixAndMatchLineGroup = group.Add(new VocabularyKey(nameof(MixAndMatchLineGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberOfItemsNeeded = group.Add(new VocabularyKey(nameof(NumberOfItemsNeeded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DiscountLineColor { get; private set; }
public VocabularyKey MixAndMatchOfferId { get; private set; }
public VocabularyKey MixAndMatchLineGroup { get; private set; }
public VocabularyKey NumberOfItemsNeeded { get; private set; }


    }
}