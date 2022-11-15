using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorInvoiceSubLineEntityVocabulary : SimpleVocabulary
    {
        public VendorInvoiceSubLineEntityVocabulary()
        {
            VocabularyName = "Vendor Invoice Sub Line Entity";
            KeyPrefix = "commonDataModel.vendorinvoicesublineentity";
            KeySeparator = ".";
            Grouping = "/VendorInvoiceSubLineEntity";

            AddGroup("VendorInvoiceSubLineEntity Details", group =>
            {
                ProductReceiptNumber = group.Add(new VocabularyKey(nameof(ProductReceiptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceLineReference = group.Add(new VocabularyKey(nameof(InvoiceLineReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseQuantity = group.Add(new VocabularyKey(nameof(PurchaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrder = group.Add(new VocabularyKey(nameof(PurchaseOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceLineNumber = group.Add(new VocabularyKey(nameof(InvoiceLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProductReceiptNumber { get; private set; }
        public VocabularyKey InvoiceLineReference { get; private set; }
        public VocabularyKey PurchaseQuantity { get; private set; }
        public VocabularyKey PurchaseOrder { get; private set; }
        public VocabularyKey InvoiceLineNumber { get; private set; }
    }
}