using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSItemDefaultInventoryStatusEntityVocabulary : SimpleVocabulary
    {
        public WHSItemDefaultInventoryStatusEntityVocabulary()
        {
            VocabularyName = "WHS Item Default Inventory Status Entity";
            KeyPrefix = "commonDataModel.whsitemdefaultinventorystatusentity";
            KeySeparator = ".";
            Grouping = "/WHSItemDefaultInventoryStatusEntity";

            AddGroup("WHSItemDefaultInventoryStatusEntity Details", group =>
            {
                AccountNumber = group.Add(new VocabularyKey(nameof(AccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryStatusId = group.Add(new VocabularyKey(nameof(DefaultInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModuleCode = group.Add(new VocabularyKey(nameof(ModuleCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey DefaultInventoryStatusId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ModuleCode { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
    }
}