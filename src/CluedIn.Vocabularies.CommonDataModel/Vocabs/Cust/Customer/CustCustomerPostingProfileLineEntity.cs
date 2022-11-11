using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCustomerPostingProfileLineEntityVocabulary : SimpleVocabulary
    {
        public CustCustomerPostingProfileLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustCustomerPostingProfileLineEntity";
            KeyPrefix = "commonDataModel.custcustomerpostingprofilelineentity";
            KeySeparator = ".";
            Grouping = "/CustCustomerPostingProfileLineEntity";

            AddGroup("Common Data Model CustCustomerPostingProfileLineEntity Details", group =>
            {
                LiabilitiesForDiscountMainAccountId = group.Add(new VocabularyKey(nameof(LiabilitiesForDiscountMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SummaryMainAccountId = group.Add(new VocabularyKey(nameof(SummaryMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxPrepaymentsMainAccountId = group.Add(new VocabularyKey(nameof(SalesTaxPrepaymentsMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteOffMainAccountId = group.Add(new VocabularyKey(nameof(WriteOffMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndorseMainAccountId = group.Add(new VocabularyKey(nameof(EndorseMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustInterest = group.Add(new VocabularyKey(nameof(CustInterest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountOrGroupNumber = group.Add(new VocabularyKey(nameof(AccountOrGroupNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestCode = group.Add(new VocabularyKey(nameof(InterestCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionLetterSequence = group.Add(new VocabularyKey(nameof(CollectionLetterSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LiabilitiesForDiscountMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(LiabilitiesForDiscountMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SummaryMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(SummaryMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxPrepaymentsMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(SalesTaxPrepaymentsMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteOffMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(WriteOffMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndorseMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(EndorseMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FineAccount = group.Add(new VocabularyKey(nameof(FineAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialInterestAccount = group.Add(new VocabularyKey(nameof(FinancialInterestAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxTransferAccount = group.Add(new VocabularyKey(nameof(TaxTransferAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FineAccountDisplayValue = group.Add(new VocabularyKey(nameof(FineAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialInterestAccountDisplayValue = group.Add(new VocabularyKey(nameof(FinancialInterestAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxTransferAccountDisplayValue = group.Add(new VocabularyKey(nameof(TaxTransferAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExportSale = group.Add(new VocabularyKey(nameof(ExportSale), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExportSaleDisplayValue = group.Add(new VocabularyKey(nameof(ExportSaleDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettleAccount = group.Add(new VocabularyKey(nameof(SettleAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettleAccountDisplayValue = group.Add(new VocabularyKey(nameof(SettleAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyName = group.Add(new VocabularyKey(nameof(HierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyType = group.Add(new VocabularyKey(nameof(HierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyStatus = group.Add(new VocabularyKey(nameof(HierarchyStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LiabilitiesForDiscountMainAccountId { get; private set; }
        public VocabularyKey SummaryMainAccountId { get; private set; }
        public VocabularyKey SalesTaxPrepaymentsMainAccountId { get; private set; }
        public VocabularyKey WriteOffMainAccountId { get; private set; }
        public VocabularyKey EndorseMainAccountId { get; private set; }
        public VocabularyKey CustInterest { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey AccountOrGroupNumber { get; private set; }
        public VocabularyKey InterestCode { get; private set; }
        public VocabularyKey CollectionLetterSequence { get; private set; }
        public VocabularyKey LiabilitiesForDiscountMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey SummaryMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey SalesTaxPrepaymentsMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey WriteOffMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey EndorseMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey FineAccount { get; private set; }
        public VocabularyKey FinancialInterestAccount { get; private set; }
        public VocabularyKey TaxTransferAccount { get; private set; }
        public VocabularyKey FineAccountDisplayValue { get; private set; }
        public VocabularyKey FinancialInterestAccountDisplayValue { get; private set; }
        public VocabularyKey TaxTransferAccountDisplayValue { get; private set; }
        public VocabularyKey ExportSale { get; private set; }
        public VocabularyKey ExportSaleDisplayValue { get; private set; }
        public VocabularyKey SettleAccount { get; private set; }
        public VocabularyKey SettleAccountDisplayValue { get; private set; }
        public VocabularyKey HierarchyName { get; private set; }
        public VocabularyKey HierarchyType { get; private set; }
        public VocabularyKey HierarchyStatus { get; private set; }


    }
}