using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxItalianSalesTaxBookEntityVocabulary : SimpleVocabulary
    {
        public TaxItalianSalesTaxBookEntityVocabulary()
        {
            VocabularyName = "Tax Italian Sales Tax Book Entity";
            KeyPrefix = "commonDataModel.taxitaliansalestaxbookentity";
            KeySeparator = ".";
            Grouping = "/TaxItalianSalesTaxBookEntity";

            AddGroup("TaxItalianSalesTaxBookEntity Details", group =>
            {
                ATECOFINCode = group.Add(new VocabularyKey(nameof(ATECOFINCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintSummaryAndPayment = group.Add(new VocabularyKey(nameof(PrintSummaryAndPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EUSales = group.Add(new VocabularyKey(nameof(EUSales), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxBook = group.Add(new VocabularyKey(nameof(SalesTaxBook), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxBookType = group.Add(new VocabularyKey(nameof(SalesTaxBookType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettlementPeriod = group.Add(new VocabularyKey(nameof(SettlementPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ATECOFINCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PrintSummaryAndPayment { get; private set; }
        public VocabularyKey EUSales { get; private set; }
        public VocabularyKey SalesTaxBook { get; private set; }
        public VocabularyKey SalesTaxBookType { get; private set; }
        public VocabularyKey SettlementPeriod { get; private set; }
    }
}