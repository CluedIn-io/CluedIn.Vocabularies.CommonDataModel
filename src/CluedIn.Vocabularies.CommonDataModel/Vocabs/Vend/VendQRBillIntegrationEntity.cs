using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendQRBillIntegrationEntityVocabulary : SimpleVocabulary
    {
        public VendQRBillIntegrationEntityVocabulary()
        {
            VocabularyName = "Vend QR Bill Integration Entity";
            KeyPrefix = "commonDataModel.vendqrbillintegrationentity";
            KeySeparator = ".";
            Grouping = "/VendQRBillIntegrationEntity";

            AddGroup("VendQRBillIntegrationEntity Details", group =>
            {
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountInTransactionCurrency = group.Add(new VocabularyKey(nameof(AmountInTransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymId = group.Add(new VocabularyKey(nameof(PaymId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRCreditorIBAN = group.Add(new VocabularyKey(nameof(QRCreditorIBAN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRCreditorName = group.Add(new VocabularyKey(nameof(QRCreditorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRAlternativeParameter1 = group.Add(new VocabularyKey(nameof(QRAlternativeParameter1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRAlternativeParameter2 = group.Add(new VocabularyKey(nameof(QRAlternativeParameter2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRAmount = group.Add(new VocabularyKey(nameof(QRAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRCreditorAddrLine1 = group.Add(new VocabularyKey(nameof(QRCreditorAddrLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRCreditorAddrLine2 = group.Add(new VocabularyKey(nameof(QRCreditorAddrLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRBillInformation = group.Add(new VocabularyKey(nameof(QRBillInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRCreditorAddressType = group.Add(new VocabularyKey(nameof(QRCreditorAddressType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRCreditorAddrStreet = group.Add(new VocabularyKey(nameof(QRCreditorAddrStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRCreditorBuildingNumber = group.Add(new VocabularyKey(nameof(QRCreditorBuildingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRCreditorCountry = group.Add(new VocabularyKey(nameof(QRCreditorCountry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRCreditorPostalCode = group.Add(new VocabularyKey(nameof(QRCreditorPostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRCreditorTown = group.Add(new VocabularyKey(nameof(QRCreditorTown), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRCurrency = group.Add(new VocabularyKey(nameof(QRCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRReference = group.Add(new VocabularyKey(nameof(QRReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRReferenceType = group.Add(new VocabularyKey(nameof(QRReferenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRUnstructuredMessage = group.Add(new VocabularyKey(nameof(QRUnstructuredMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportExecutionId = group.Add(new VocabularyKey(nameof(ImportExecutionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscCode = group.Add(new VocabularyKey(nameof(CashDiscCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceId = group.Add(new VocabularyKey(nameof(InvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATNumber = group.Add(new VocabularyKey(nameof(VATNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroup = group.Add(new VocabularyKey(nameof(TaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxItemGroup = group.Add(new VocabularyKey(nameof(TaxItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorBankAccount = group.Add(new VocabularyKey(nameof(VendorBankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey VendorAccount { get; private set; }
        public VocabularyKey AmountInTransactionCurrency { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey PaymId { get; private set; }
        public VocabularyKey QRCreditorIBAN { get; private set; }
        public VocabularyKey QRCreditorName { get; private set; }
        public VocabularyKey QRAlternativeParameter1 { get; private set; }
        public VocabularyKey QRAlternativeParameter2 { get; private set; }
        public VocabularyKey QRAmount { get; private set; }
        public VocabularyKey QRCreditorAddrLine1 { get; private set; }
        public VocabularyKey QRCreditorAddrLine2 { get; private set; }
        public VocabularyKey QRBillInformation { get; private set; }
        public VocabularyKey QRCreditorAddressType { get; private set; }
        public VocabularyKey QRCreditorAddrStreet { get; private set; }
        public VocabularyKey QRCreditorBuildingNumber { get; private set; }
        public VocabularyKey QRCreditorCountry { get; private set; }
        public VocabularyKey QRCreditorPostalCode { get; private set; }
        public VocabularyKey QRCreditorTown { get; private set; }
        public VocabularyKey QRCurrency { get; private set; }
        public VocabularyKey QRReference { get; private set; }
        public VocabularyKey QRReferenceType { get; private set; }
        public VocabularyKey QRUnstructuredMessage { get; private set; }
        public VocabularyKey ImportExecutionId { get; private set; }
        public VocabularyKey CashDiscCode { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey InvoiceId { get; private set; }
        public VocabularyKey VATNumber { get; private set; }
        public VocabularyKey TaxGroup { get; private set; }
        public VocabularyKey TaxItemGroup { get; private set; }
        public VocabularyKey VendorBankAccount { get; private set; }
    }
}