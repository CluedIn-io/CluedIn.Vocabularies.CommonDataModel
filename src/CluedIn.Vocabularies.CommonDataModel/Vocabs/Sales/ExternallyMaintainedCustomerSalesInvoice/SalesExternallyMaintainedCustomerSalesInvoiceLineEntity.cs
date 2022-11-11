using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesExternallyMaintainedCustomerSalesInvoiceLineEntityVocabulary : SimpleVocabulary
    {
        public SalesExternallyMaintainedCustomerSalesInvoiceLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesExternallyMaintainedCustomerSalesInvoiceLineEntity";
            KeyPrefix = "commonDataModel.salesexternallymaintainedcustomersalesinvoicelineentity";
            KeySeparator = ".";
            Grouping = "/SalesExternallyMaintainedCustomerSalesInvoiceLineEntity";

            AddGroup("Common Data Model SalesExternallyMaintainedCustomerSalesInvoiceLineEntity Details", group =>
            {
                ConfirmedShippingDate = group.Add(new VocabularyKey(nameof(ConfirmedShippingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoicedQuantity = group.Add(new VocabularyKey(nameof(InvoicedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceNumber = group.Add(new VocabularyKey(nameof(InvoiceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineCreationSequenceNumber = group.Add(new VocabularyKey(nameof(LineCreationSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineTotalChargeAmount = group.Add(new VocabularyKey(nameof(LineTotalChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineTotalDiscountAmount = group.Add(new VocabularyKey(nameof(LineTotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineTotalTaxAmount = group.Add(new VocabularyKey(nameof(LineTotalTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrice = group.Add(new VocabularyKey(nameof(SalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerVoucher = group.Add(new VocabularyKey(nameof(LedgerVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ConfirmedShippingDate { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey InvoicedQuantity { get; private set; }
        public VocabularyKey InvoiceNumber { get; private set; }
        public VocabularyKey LineAmount { get; private set; }
        public VocabularyKey LineCreationSequenceNumber { get; private set; }
        public VocabularyKey LineTotalChargeAmount { get; private set; }
        public VocabularyKey LineTotalDiscountAmount { get; private set; }
        public VocabularyKey LineTotalTaxAmount { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey SalesPrice { get; private set; }
        public VocabularyKey SalesUnitSymbol { get; private set; }
        public VocabularyKey LedgerVoucher { get; private set; }


    }
}