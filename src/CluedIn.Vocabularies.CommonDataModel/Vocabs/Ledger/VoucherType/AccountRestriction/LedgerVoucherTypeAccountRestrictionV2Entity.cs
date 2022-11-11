using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerVoucherTypeAccountRestrictionV2EntityVocabulary : SimpleVocabulary
    {
        public LedgerVoucherTypeAccountRestrictionV2EntityVocabulary()
        {
            VocabularyName = "LedgerVoucherTypeAccountRestrictionV2Entity";
            KeyPrefix = "commonDataModel.ledgervouchertypeaccountrestrictionv2entity";
            KeySeparator = ".";
            Grouping = "/LedgerVoucherTypeAccountRestrictionV2Entity";

            AddGroup("LedgerVoucherTypeAccountRestrictionV2Entity Details", group =>
            {
                DefaultApproverRecId = group.Add(new VocabularyKey(nameof(DefaultApproverRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPreparedByWorkerRecId = group.Add(new VocabularyKey(nameof(DefaultPreparedByWorkerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultType = group.Add(new VocabularyKey(nameof(IsDefaultType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherType = group.Add(new VocabularyKey(nameof(VoucherType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerPrintLayoutGroupRecId = group.Add(new VocabularyKey(nameof(LedgerPrintLayoutGroupRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherTypeNumber = group.Add(new VocabularyKey(nameof(VoucherTypeNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceTableRecId = group.Add(new VocabularyKey(nameof(NumberSequenceTableRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultApprovedBy = group.Add(new VocabularyKey(nameof(DefaultApprovedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultedPreparedBy = group.Add(new VocabularyKey(nameof(DefaultedPreparedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerPrintLayoutGroup = group.Add(new VocabularyKey(nameof(LedgerPrintLayoutGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceScope = group.Add(new VocabularyKey(nameof(NumberSequenceScope), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RestrictionType = group.Add(new VocabularyKey(nameof(RestrictionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotNullableLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(NotNullableLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DefaultApproverRecId { get; private set; }
        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey DefaultPreparedByWorkerRecId { get; private set; }
        public VocabularyKey IsDefaultType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey VoucherType { get; private set; }
        public VocabularyKey LedgerPrintLayoutGroupRecId { get; private set; }
        public VocabularyKey VoucherTypeNumber { get; private set; }
        public VocabularyKey NumberSequenceTableRecId { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey DefaultApprovedBy { get; private set; }
        public VocabularyKey DefaultedPreparedBy { get; private set; }
        public VocabularyKey LedgerPrintLayoutGroup { get; private set; }
        public VocabularyKey NumberSequenceCode { get; private set; }
        public VocabularyKey NumberSequenceScope { get; private set; }
        public VocabularyKey AccountRelation { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey LedgerDimension { get; private set; }
        public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey RestrictionType { get; private set; }
        public VocabularyKey NotNullableLedgerDimensionDisplayValue { get; private set; }


    }
}