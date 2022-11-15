using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryTagCountingJournalNameEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryTagCountingJournalNameEntityVocabulary()
        {
            VocabularyName = "Invent Inventory Tag Counting Journal Name Entity";
            KeyPrefix = "commonDataModel.inventinventorytagcountingjournalnameentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryTagCountingJournalNameEntity";

            AddGroup("InventInventoryTagCountingJournalNameEntity Details", group =>
            {
                JournalNameId = group.Add(new VocabularyKey(nameof(JournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultJournalDescription = group.Add(new VocabularyKey(nameof(DefaultJournalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPostingDeleteLinesByDefault = group.Add(new VocabularyKey(nameof(WillPostingDeleteLinesByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPrivateUserGroupId = group.Add(new VocabularyKey(nameof(DefaultPrivateUserGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPostingSummationLevel = group.Add(new VocabularyKey(nameof(DefaultPostingSummationLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultVoucherNumberAllocationRule = group.Add(new VocabularyKey(nameof(DefaultVoucherNumberAllocationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultVoucherNumberSelectionRule = group.Add(new VocabularyKey(nameof(DefaultVoucherNumberSelectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultVoucherNumberSequenceRecId = group.Add(new VocabularyKey(nameof(DefaultVoucherNumberSequenceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultVoucherNumberSequenceCode = group.Add(new VocabularyKey(nameof(DefaultVoucherNumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceTable_NumberSequenceScope = group.Add(new VocabularyKey(nameof(NumberSequenceTable_NumberSequenceScope), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultVoucherNumberSequenceDataArea = group.Add(new VocabularyKey(nameof(DefaultVoucherNumberSequenceDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey JournalNameId { get; private set; }
        public VocabularyKey DefaultJournalDescription { get; private set; }
        public VocabularyKey WillPostingDeleteLinesByDefault { get; private set; }
        public VocabularyKey DefaultPrivateUserGroupId { get; private set; }
        public VocabularyKey DefaultPostingSummationLevel { get; private set; }
        public VocabularyKey DefaultVoucherNumberAllocationRule { get; private set; }
        public VocabularyKey DefaultVoucherNumberSelectionRule { get; private set; }
        public VocabularyKey DefaultVoucherNumberSequenceRecId { get; private set; }
        public VocabularyKey DefaultVoucherNumberSequenceCode { get; private set; }
        public VocabularyKey NumberSequenceTable_NumberSequenceScope { get; private set; }
        public VocabularyKey DefaultVoucherNumberSequenceDataArea { get; private set; }
    }
}