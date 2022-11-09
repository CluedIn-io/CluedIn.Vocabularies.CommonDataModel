using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConsignmentLegalEntityInventoryOwnerEntityVocabulary : SimpleVocabulary
    {
        public ConsignmentLegalEntityInventoryOwnerEntityVocabulary()
        {
            VocabularyName = "Common Data Model ConsignmentLegalEntityInventoryOwnerEntity";
            KeyPrefix = "commonDataModel.consignmentlegalentityinventoryownerentity";
            KeySeparator = ".";
            Grouping = "/ConsignmentLegalEntityInventoryOwnerEntity";

            AddGroup("Common Data Model ConsignmentLegalEntityInventoryOwnerEntity Details", group =>
            {
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey InventoryOwnerId { get; private set; }
public VocabularyKey LegalEntityId { get; private set; }


    }
}