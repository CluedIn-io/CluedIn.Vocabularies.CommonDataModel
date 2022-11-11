using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjJournalTransEntityVocabulary : SimpleVocabulary
    {
        public ProjJournalTransEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjJournalTransEntity";
            KeyPrefix = "commonDataModel.projjournaltransentity";
            KeySeparator = ".";
            Grouping = "/ProjJournalTransEntity";

            AddGroup("Common Data Model ProjJournalTransEntity Details", group =>
            {
                ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPrice = group.Add(new VocabularyKey(nameof(CostPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartTime = group.Add(new VocabularyKey(nameof(StartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineProperty = group.Add(new VocabularyKey(nameof(LineProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeOfOperation = group.Add(new VocabularyKey(nameof(TypeOfOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceGroup = group.Add(new VocabularyKey(nameof(PriceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectDate = group.Add(new VocabularyKey(nameof(ProjectDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Cost = group.Add(new VocabularyKey(nameof(Cost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PercentageComplete = group.Add(new VocabularyKey(nameof(PercentageComplete), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSAWrkCtrId = group.Add(new VocabularyKey(nameof(PSAWrkCtrId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Hours = group.Add(new VocabularyKey(nameof(Hours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Role = group.Add(new VocabularyKey(nameof(Role), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReversingDate = group.Add(new VocabularyKey(nameof(ReversingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReversingEntry = group.Add(new VocabularyKey(nameof(ReversingEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndTime = group.Add(new VocabularyKey(nameof(EndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoucherDate = group.Add(new VocabularyKey(nameof(VoucherDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionID = group.Add(new VocabularyKey(nameof(TransactionID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalId = group.Add(new VocabularyKey(nameof(JournalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCompanyId = group.Add(new VocabularyKey(nameof(ResourceCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCategoryId = group.Add(new VocabularyKey(nameof(ResourceCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyId = group.Add(new VocabularyKey(nameof(CurrencyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActivityNumber { get; private set; }
        public VocabularyKey Category { get; private set; }
        public VocabularyKey CostPrice { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey LineProperty { get; private set; }
        public VocabularyKey TypeOfOperation { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey ProjectID { get; private set; }
        public VocabularyKey PriceGroup { get; private set; }
        public VocabularyKey ProjectDate { get; private set; }
        public VocabularyKey Cost { get; private set; }
        public VocabularyKey PercentageComplete { get; private set; }
        public VocabularyKey PSAWrkCtrId { get; private set; }
        public VocabularyKey Hours { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey Role { get; private set; }
        public VocabularyKey ReversingDate { get; private set; }
        public VocabularyKey ReversingEntry { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey ItemSalesTaxGroup { get; private set; }
        public VocabularyKey EndTime { get; private set; }
        public VocabularyKey VoucherDate { get; private set; }
        public VocabularyKey TransactionID { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey JournalId { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey ResourceCompanyId { get; private set; }
        public VocabularyKey ResourceCategoryId { get; private set; }
        public VocabularyKey CurrencyId { get; private set; }


    }
}