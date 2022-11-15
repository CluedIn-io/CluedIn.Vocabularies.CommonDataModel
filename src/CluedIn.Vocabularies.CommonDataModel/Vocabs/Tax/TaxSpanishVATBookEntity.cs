using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxSpanishVATBookEntityVocabulary : SimpleVocabulary
    {
        public TaxSpanishVATBookEntityVocabulary()
        {
            VocabularyName = "Tax Spanish VAT Book Entity";
            KeyPrefix = "commonDataModel.taxspanishvatbookentity";
            KeySeparator = ".";
            Grouping = "/TaxSpanishVATBookEntity";

            AddGroup("TaxSpanishVATBookEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceTable = group.Add(new VocabularyKey(nameof(NumberSequenceTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATBook = group.Add(new VocabularyKey(nameof(VATBook), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATBookType = group.Add(new VocabularyKey(nameof(VATBookType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxCode = group.Add(new VocabularyKey(nameof(SalesTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EquivalenceChargeSalesTaxCode = group.Add(new VocabularyKey(nameof(EquivalenceChargeSalesTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsNonDeductibleVAT = group.Add(new VocabularyKey(nameof(IsNonDeductibleVAT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReverseCharge = group.Add(new VocabularyKey(nameof(IsReverseCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceScope = group.Add(new VocabularyKey(nameof(NumberSequenceScope), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey NumberSequenceTable { get; private set; }
        public VocabularyKey VATBook { get; private set; }
        public VocabularyKey VATBookType { get; private set; }
        public VocabularyKey NumberSequenceCode { get; private set; }
        public VocabularyKey SalesTaxCode { get; private set; }
        public VocabularyKey EquivalenceChargeSalesTaxCode { get; private set; }
        public VocabularyKey IsNonDeductibleVAT { get; private set; }
        public VocabularyKey IsReverseCharge { get; private set; }
        public VocabularyKey NumberSequenceScope { get; private set; }
    }
}