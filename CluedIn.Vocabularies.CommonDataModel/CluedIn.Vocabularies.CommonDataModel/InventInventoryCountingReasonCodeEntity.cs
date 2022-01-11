using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryCountingReasonCodeEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryCountingReasonCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventInventoryCountingReasonCodeEntity";
            KeyPrefix = "commonDataModel.inventinventorycountingreasoncodeentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryCountingReasonCodeEntity";

            AddGroup("Common Data Model InventInventoryCountingReasonCodeEntity Details", group =>
            {
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ReasonCode { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}