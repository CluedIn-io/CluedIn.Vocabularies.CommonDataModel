using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorPostingProfileLineEntityVocabulary : SimpleVocabulary
    {
        public VendorPostingProfileLineEntityVocabulary()
        {
            VocabularyName = "Vendor Posting Profile Line Entity";
            KeyPrefix = "commonDataModel.vendorpostingprofilelineentity";
            KeySeparator = ".";
            Grouping = "/VendorPostingProfileLineEntity";

            AddGroup("VendorPostingProfileLineEntity Details", group =>
            {
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettleAccount = group.Add(new VocabularyKey(nameof(SettleAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountGroupNumber = group.Add(new VocabularyKey(nameof(AccountGroupNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArrivalAccount = group.Add(new VocabularyKey(nameof(ArrivalAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SummaryAccount = group.Add(new VocabularyKey(nameof(SummaryAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxPrepaymentsAccount = group.Add(new VocabularyKey(nameof(SalesTaxPrepaymentsAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettleAccountDisplayValue = group.Add(new VocabularyKey(nameof(SettleAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArrivalAccountDisplayValue = group.Add(new VocabularyKey(nameof(ArrivalAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SummaryAccountDisplayValue = group.Add(new VocabularyKey(nameof(SummaryAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxPrepaymentsAccountDisplayValue = group.Add(new VocabularyKey(nameof(SalesTaxPrepaymentsAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FineAccount = group.Add(new VocabularyKey(nameof(FineAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialInterestAccount = group.Add(new VocabularyKey(nameof(FinancialInterestAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxTransferAccount = group.Add(new VocabularyKey(nameof(TaxTransferAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FineAccountDisplayValue = group.Add(new VocabularyKey(nameof(FineAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialInterestAccountDisplayValue = group.Add(new VocabularyKey(nameof(FinancialInterestAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxTransferAccountDisplayValue = group.Add(new VocabularyKey(nameof(TaxTransferAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyName = group.Add(new VocabularyKey(nameof(HierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyStatus = group.Add(new VocabularyKey(nameof(HierarchyStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyType = group.Add(new VocabularyKey(nameof(HierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey SettleAccount { get; private set; }
        public VocabularyKey AccountGroupNumber { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey ArrivalAccount { get; private set; }
        public VocabularyKey OffsetAccount { get; private set; }
        public VocabularyKey SummaryAccount { get; private set; }
        public VocabularyKey SalesTaxPrepaymentsAccount { get; private set; }
        public VocabularyKey SettleAccountDisplayValue { get; private set; }
        public VocabularyKey ArrivalAccountDisplayValue { get; private set; }
        public VocabularyKey OffsetAccountDisplayValue { get; private set; }
        public VocabularyKey SummaryAccountDisplayValue { get; private set; }
        public VocabularyKey SalesTaxPrepaymentsAccountDisplayValue { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey FineAccount { get; private set; }
        public VocabularyKey FinancialInterestAccount { get; private set; }
        public VocabularyKey TaxTransferAccount { get; private set; }
        public VocabularyKey FineAccountDisplayValue { get; private set; }
        public VocabularyKey FinancialInterestAccountDisplayValue { get; private set; }
        public VocabularyKey TaxTransferAccountDisplayValue { get; private set; }
        public VocabularyKey HierarchyName { get; private set; }
        public VocabularyKey HierarchyStatus { get; private set; }
        public VocabularyKey HierarchyType { get; private set; }
    }
}