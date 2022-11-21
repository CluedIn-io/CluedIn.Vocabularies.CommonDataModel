using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendInvoicePriceToleranceEntityVocabulary : SimpleVocabulary
    {
        public VendInvoicePriceToleranceEntityVocabulary()
        {
            VocabularyName = "Vend Invoice Price Tolerance Entity";
            KeyPrefix = "commonDataModel.vendinvoicepricetoleranceentity";
            KeySeparator = ".";
            Grouping = "/VendInvoicePriceToleranceEntity";

            AddGroup("VendInvoicePriceToleranceEntity Details", group =>
            {
                PriceToleranceItemNumber = group.Add(new VocabularyKey(nameof(PriceToleranceItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceToleranceItemGroup = group.Add(new VocabularyKey(nameof(PriceToleranceItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceToleranceAccountNumber = group.Add(new VocabularyKey(nameof(PriceToleranceAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceToleranceAccountGroup = group.Add(new VocabularyKey(nameof(PriceToleranceAccountGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PercentTolerance = group.Add(new VocabularyKey(nameof(PercentTolerance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PriceToleranceItemNumber { get; private set; }
        public VocabularyKey PriceToleranceItemGroup { get; private set; }
        public VocabularyKey PriceToleranceAccountNumber { get; private set; }
        public VocabularyKey PriceToleranceAccountGroup { get; private set; }
        public VocabularyKey PercentTolerance { get; private set; }
        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey AccountRelation { get; private set; }
        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
    }
}