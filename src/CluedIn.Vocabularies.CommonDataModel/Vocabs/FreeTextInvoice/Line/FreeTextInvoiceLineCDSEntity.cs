using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FreeTextInvoiceLineCDSEntityVocabulary : SimpleVocabulary
    {
        public FreeTextInvoiceLineCDSEntityVocabulary()
        {
            VocabularyName = "Common Data Model FreeTextInvoiceLineCDSEntity";
            KeyPrefix = "commonDataModel.freetextinvoicelinecdsentity";
            KeySeparator = ".";
            Grouping = "/FreeTextInvoiceLineCDSEntity";

            AddGroup("Common Data Model FreeTextInvoiceLineCDSEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalInvoiceId = group.Add(new VocabularyKey(nameof(ExternalInvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceText = group.Add(new VocabularyKey(nameof(InvoiceText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupId = group.Add(new VocabularyKey(nameof(SalesTaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxItemGroupId = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPrice = group.Add(new VocabularyKey(nameof(UnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExternalInvoiceId { get; private set; }
        public VocabularyKey InvoiceText { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey MainAccountDisplayValue { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey SalesTaxGroupId { get; private set; }
        public VocabularyKey SalesTaxItemGroupId { get; private set; }
        public VocabularyKey TransactionCurrencyAmount { get; private set; }
        public VocabularyKey UnitPrice { get; private set; }


    }
}