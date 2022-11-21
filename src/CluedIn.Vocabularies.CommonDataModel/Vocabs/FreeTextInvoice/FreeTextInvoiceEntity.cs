using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FreeTextInvoiceEntityVocabulary : SimpleVocabulary
    {
        public FreeTextInvoiceEntityVocabulary()
        {
            VocabularyName = "Free Text Invoice Entity";
            KeyPrefix = "commonDataModel.freetextinvoiceentity";
            KeySeparator = ".";
            Grouping = "/FreeTextInvoiceEntity";

            AddGroup("FreeTextInvoiceEntity Details", group =>
            {
                FreeTextNumber = group.Add(new VocabularyKey(nameof(FreeTextNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAccount = group.Add(new VocabularyKey(nameof(InvoiceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MethodOfPayment = group.Add(new VocabularyKey(nameof(MethodOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountDate = group.Add(new VocabularyKey(nameof(CashDiscountDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPrice = group.Add(new VocabularyKey(nameof(UnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountCur = group.Add(new VocabularyKey(nameof(AmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxItemGroup = group.Add(new VocabularyKey(nameof(SalesTaxItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirectDebitMandateId = group.Add(new VocabularyKey(nameof(DirectDebitMandateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerReference = group.Add(new VocabularyKey(nameof(CustomerReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRequisition = group.Add(new VocabularyKey(nameof(CustomerRequisition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceId = group.Add(new VocabularyKey(nameof(InvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingClassification = group.Add(new VocabularyKey(nameof(BillingClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingCode = group.Add(new VocabularyKey(nameof(BillingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EInvoiceAccountCode = group.Add(new VocabularyKey(nameof(EInvoiceAccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EInvoiceIsLineSpecific = group.Add(new VocabularyKey(nameof(EInvoiceIsLineSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiroType = group.Add(new VocabularyKey(nameof(GiroType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLumpSumRecoveryTextPrinted = group.Add(new VocabularyKey(nameof(IsLumpSumRecoveryTextPrinted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NGPCode = group.Add(new VocabularyKey(nameof(NGPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PropertyNumber = group.Add(new VocabularyKey(nameof(PropertyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InclTax = group.Add(new VocabularyKey(nameof(InclTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostponedVAT = group.Add(new VocabularyKey(nameof(PostponedVAT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryDate = group.Add(new VocabularyKey(nameof(DeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercentage = group.Add(new VocabularyKey(nameof(DiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPTableRecId = group.Add(new VocabularyKey(nameof(CFOPTableRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFPSCode = group.Add(new VocabularyKey(nameof(CFPSCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFinalUser = group.Add(new VocabularyKey(nameof(IsFinalUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentFineCode = group.Add(new VocabularyKey(nameof(CustomerPaymentFineCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentTypeRecId = group.Add(new VocabularyKey(nameof(FiscalDocumentTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentRecId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentFinancialInterestCode = group.Add(new VocabularyKey(nameof(CustomerPaymentFinancialInterestCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalOperationPresenceType = group.Add(new VocabularyKey(nameof(FiscalOperationPresenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPurchOperationTypeRecId = group.Add(new VocabularyKey(nameof(SalesPurchOperationTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsServiceDeliveryAddressBased = group.Add(new VocabularyKey(nameof(IsServiceDeliveryAddressBased), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPCode = group.Add(new VocabularyKey(nameof(CFOPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentTypeId = group.Add(new VocabularyKey(nameof(FiscalDocumentTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentOperationTypeId = group.Add(new VocabularyKey(nameof(FiscalDocumentOperationTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComplementaryFiscalDocumentType = group.Add(new VocabularyKey(nameof(ComplementaryFiscalDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationDocumentLineId = group.Add(new VocabularyKey(nameof(TransportationDocumentLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceTxt = group.Add(new VocabularyKey(nameof(InvoiceTxt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsigneeAccount = group.Add(new VocabularyKey(nameof(ConsigneeAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsignorAccount = group.Add(new VocabularyKey(nameof(ConsignorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCorrection = group.Add(new VocabularyKey(nameof(IsCorrection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectedFactureDate = group.Add(new VocabularyKey(nameof(CorrectedFactureDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectedFactureExternalId = group.Add(new VocabularyKey(nameof(CorrectedFactureExternalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectedInvoiceDate = group.Add(new VocabularyKey(nameof(CorrectedInvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectedInvoiceId = group.Add(new VocabularyKey(nameof(CorrectedInvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectedPeriod = group.Add(new VocabularyKey(nameof(CorrectedPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionType = group.Add(new VocabularyKey(nameof(CorrectionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATOnPayment = group.Add(new VocabularyKey(nameof(VATOnPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonRealRevenue = group.Add(new VocabularyKey(nameof(NonRealRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeaderDefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(HeaderDefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateOfVATRegister = group.Add(new VocabularyKey(nameof(DateOfVATRegister), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesDate = group.Add(new VocabularyKey(nameof(SalesDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntentLetterId_IT = group.Add(new VocabularyKey(nameof(IntentLetterId_IT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FreeTextNumber { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey InvoiceAccount { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey MethodOfPayment { get; private set; }
        public VocabularyKey TermsOfPayment { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey CashDiscountDate { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LedgerDimension { get; private set; }
        public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey UnitPrice { get; private set; }
        public VocabularyKey AmountCur { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey SalesTaxItemGroup { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey DirectDebitMandateId { get; private set; }
        public VocabularyKey CustomerReference { get; private set; }
        public VocabularyKey CustomerRequisition { get; private set; }
        public VocabularyKey InvoiceId { get; private set; }
        public VocabularyKey BillingClassification { get; private set; }
        public VocabularyKey BillingCode { get; private set; }
        public VocabularyKey EInvoiceAccountCode { get; private set; }
        public VocabularyKey EInvoiceIsLineSpecific { get; private set; }
        public VocabularyKey GiroType { get; private set; }
        public VocabularyKey IsLumpSumRecoveryTextPrinted { get; private set; }
        public VocabularyKey NGPCode { get; private set; }
        public VocabularyKey PropertyNumber { get; private set; }
        public VocabularyKey InclTax { get; private set; }
        public VocabularyKey PostponedVAT { get; private set; }
        public VocabularyKey DeliveryDate { get; private set; }
        public VocabularyKey DiscountPercentage { get; private set; }
        public VocabularyKey CFOPTableRecId { get; private set; }
        public VocabularyKey CFPSCode { get; private set; }
        public VocabularyKey IsFinalUser { get; private set; }
        public VocabularyKey CustomerPaymentFineCode { get; private set; }
        public VocabularyKey FiscalDocumentTypeRecId { get; private set; }
        public VocabularyKey FiscalEstablishmentRecId { get; private set; }
        public VocabularyKey CustomerPaymentFinancialInterestCode { get; private set; }
        public VocabularyKey FiscalOperationPresenceType { get; private set; }
        public VocabularyKey SalesPurchOperationTypeRecId { get; private set; }
        public VocabularyKey IsServiceDeliveryAddressBased { get; private set; }
        public VocabularyKey CFOPCode { get; private set; }
        public VocabularyKey FiscalDocumentTypeId { get; private set; }
        public VocabularyKey FiscalEstablishmentId { get; private set; }
        public VocabularyKey FiscalDocumentOperationTypeId { get; private set; }
        public VocabularyKey ComplementaryFiscalDocumentType { get; private set; }
        public VocabularyKey TransportationDocumentLineId { get; private set; }
        public VocabularyKey InvoiceTxt { get; private set; }
        public VocabularyKey ConsigneeAccount { get; private set; }
        public VocabularyKey ConsignorAccount { get; private set; }
        public VocabularyKey IsCorrection { get; private set; }
        public VocabularyKey CorrectedFactureDate { get; private set; }
        public VocabularyKey CorrectedFactureExternalId { get; private set; }
        public VocabularyKey CorrectedInvoiceDate { get; private set; }
        public VocabularyKey CorrectedInvoiceId { get; private set; }
        public VocabularyKey CorrectedPeriod { get; private set; }
        public VocabularyKey CorrectionType { get; private set; }
        public VocabularyKey VATOnPayment { get; private set; }
        public VocabularyKey NonRealRevenue { get; private set; }
        public VocabularyKey HeaderDefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey DateOfVATRegister { get; private set; }
        public VocabularyKey SalesDate { get; private set; }
        public VocabularyKey IntentLetterId_IT { get; private set; }
    }
}