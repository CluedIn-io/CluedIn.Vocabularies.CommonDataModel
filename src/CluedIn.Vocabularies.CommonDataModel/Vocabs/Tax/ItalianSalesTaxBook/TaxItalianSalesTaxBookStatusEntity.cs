using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxItalianSalesTaxBookStatusEntityVocabulary : SimpleVocabulary
    {
        public TaxItalianSalesTaxBookStatusEntityVocabulary()
        {
            VocabularyName = "Tax Italian Sales Tax Book Status Entity";
            KeyPrefix = "commonDataModel.taxitaliansalestaxbookstatusentity";
            KeySeparator = ".";
            Grouping = "/TaxItalianSalesTaxBookStatusEntity";

            AddGroup("TaxItalianSalesTaxBookStatusEntity Details", group =>
            {
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettlementPeriod = group.Add(new VocabularyKey(nameof(SettlementPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BookType = group.Add(new VocabularyKey(nameof(BookType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxBook = group.Add(new VocabularyKey(nameof(SalesTaxBook), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstPageNumber = group.Add(new VocabularyKey(nameof(FirstPageNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChangedTo = group.Add(new VocabularyKey(nameof(ChangedTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Page = group.Add(new VocabularyKey(nameof(Page), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastPageNumber = group.Add(new VocabularyKey(nameof(LastPageNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey SettlementPeriod { get; private set; }
        public VocabularyKey BookType { get; private set; }
        public VocabularyKey SalesTaxBook { get; private set; }
        public VocabularyKey FirstPageNumber { get; private set; }
        public VocabularyKey ChangedTo { get; private set; }
        public VocabularyKey Page { get; private set; }
        public VocabularyKey LastPageNumber { get; private set; }
    }
}