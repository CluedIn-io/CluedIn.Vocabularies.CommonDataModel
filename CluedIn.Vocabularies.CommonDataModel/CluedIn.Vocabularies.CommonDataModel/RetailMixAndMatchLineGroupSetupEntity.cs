using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailMixAndMatchLineGroupSetupEntityVocabulary : SimpleVocabulary
    {
        public RetailMixAndMatchLineGroupSetupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailMixAndMatchLineGroupSetupEntity";
            KeyPrefix = "commonDataModel.retailmixandmatchlinegroupsetupentity";
            KeySeparator = ".";
            Grouping = "/RetailMixAndMatchLineGroupSetupEntity";

            AddGroup("Common Data Model RetailMixAndMatchLineGroupSetupEntity Details", group =>
            {
                discountLineColorId = group.Add(new VocabularyKey(nameof(discountLineColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
mixAndMatchLineGroup = group.Add(new VocabularyKey(nameof(mixAndMatchLineGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
numberOfItemsNeeded = group.Add(new VocabularyKey(nameof(numberOfItemsNeeded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey discountLineColorId { get; private set; }
public VocabularyKey mixAndMatchLineGroup { get; private set; }
public VocabularyKey numberOfItemsNeeded { get; private set; }


    }
}