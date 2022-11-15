using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConsignmentVendorInventoryOwnerEntityVocabulary : SimpleVocabulary
    {
        public ConsignmentVendorInventoryOwnerEntityVocabulary()
        {
            VocabularyName = "Consignment Vendor Inventory Owner Entity";
            KeyPrefix = "commonDataModel.consignmentvendorinventoryownerentity";
            KeySeparator = ".";
            Grouping = "/ConsignmentVendorInventoryOwnerEntity";

            AddGroup("ConsignmentVendorInventoryOwnerEntity Details", group =>
            {
                InventoryOwnerId = group.Add(new VocabularyKey(nameof(InventoryOwnerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey InventoryOwnerId { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
    }
}