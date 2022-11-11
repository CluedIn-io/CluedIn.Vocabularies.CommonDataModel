using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjBeginningBalanceOnAccEntityVocabulary : SimpleVocabulary
    {
        public ProjBeginningBalanceOnAccEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjBeginningBalanceOnAccEntity";
            KeyPrefix = "commonDataModel.projbeginningbalanceonaccentity";
            KeySeparator = ".";
            Grouping = "/ProjBeginningBalanceOnAccEntity";

            AddGroup("Common Data Model ProjBeginningBalanceOnAccEntity Details", group =>
            {
                JournalId = group.Add(new VocabularyKey(nameof(JournalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalDescription = group.Add(new VocabularyKey(nameof(JournalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalType = group.Add(new VocabularyKey(nameof(JournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalDetailSummary = group.Add(new VocabularyKey(nameof(JournalDetailSummary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectDate = group.Add(new VocabularyKey(nameof(ProjectDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesCurrency = group.Add(new VocabularyKey(nameof(SalesCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Revenue = group.Add(new VocabularyKey(nameof(Revenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractId = group.Add(new VocabularyKey(nameof(ContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherDate = group.Add(new VocabularyKey(nameof(VoucherDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherNumberSequenceTable = group.Add(new VocabularyKey(nameof(VoucherNumberSequenceTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundingSourceId = group.Add(new VocabularyKey(nameof(FundingSourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherChange = group.Add(new VocabularyKey(nameof(VoucherChange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherDraw = group.Add(new VocabularyKey(nameof(VoucherDraw), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjFundingSource = group.Add(new VocabularyKey(nameof(ProjFundingSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JournalId { get; private set; }
        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey JournalDescription { get; private set; }
        public VocabularyKey JournalType { get; private set; }
        public VocabularyKey JournalDetailSummary { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ProjectDate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey SalesCurrency { get; private set; }
        public VocabularyKey Revenue { get; private set; }
        public VocabularyKey ContractId { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey ItemSalesTaxGroup { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey VoucherDate { get; private set; }
        public VocabularyKey VoucherNumberSequenceTable { get; private set; }
        public VocabularyKey FundingSourceId { get; private set; }
        public VocabularyKey VoucherChange { get; private set; }
        public VocabularyKey VoucherDraw { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey ProjFundingSource { get; private set; }


    }
}