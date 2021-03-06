using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConsignmentVendorInventoryOwnerEntityVocabulary : SimpleVocabulary
    {
        public ConsignmentVendorInventoryOwnerEntityVocabulary()
        {
            VocabularyName = "Common Data Model ConsignmentVendorInventoryOwnerEntity";
            KeyPrefix = "commonDataModel.consignmentvendorinventoryownerentity";
            KeySeparator = ".";
            Grouping = "/ConsignmentVendorInventoryOwnerEntity";

            AddGroup("Common Data Model ConsignmentVendorInventoryOwnerEntity Details", group =>
            {
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey InventoryOwnerId { get; private set; }
public VocabularyKey VendorAccountNumber { get; private set; }


    }
}