using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FreeTextInvoiceHeaderEntityVocabulary : SimpleVocabulary
    {
        public FreeTextInvoiceHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model FreeTextInvoiceHeaderEntity";
            KeyPrefix = "commonDataModel.freetextinvoiceheaderentity";
            KeySeparator = ".";
            Grouping = "/FreeTextInvoiceHeaderEntity";

            AddGroup("Common Data Model FreeTextInvoiceHeaderEntity Details", group =>
            {
                InvoiceIdentifier = group.Add(new VocabularyKey(nameof(InvoiceIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreeTextNumber = group.Add(new VocabularyKey(nameof(FreeTextNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceId = group.Add(new VocabularyKey(nameof(InvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdjustingInvoiceDate = group.Add(new VocabularyKey(nameof(AdjustingInvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CentralBankPurposeCode = group.Add(new VocabularyKey(nameof(CentralBankPurposeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CentralBankPurposeText = group.Add(new VocabularyKey(nameof(CentralBankPurposeText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsBaseDate = group.Add(new VocabularyKey(nameof(PaymentTermsBaseDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsBaseDays = group.Add(new VocabularyKey(nameof(PaymentTermsBaseDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountDate = group.Add(new VocabularyKey(nameof(CashDiscountDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountPercentage = group.Add(new VocabularyKey(nameof(CashDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComplimentedInvoiceId = group.Add(new VocabularyKey(nameof(ComplimentedInvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionReasonCode = group.Add(new VocabularyKey(nameof(CorrectionReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashFlowForecast = group.Add(new VocabularyKey(nameof(CashFlowForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccountId = group.Add(new VocabularyKey(nameof(BankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingClassificationId = group.Add(new VocabularyKey(nameof(BillingClassificationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerReference = group.Add(new VocabularyKey(nameof(CustomerReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirectDebitMandateId = group.Add(new VocabularyKey(nameof(DirectDebitMandateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPostedViaIntercompany = group.Add(new VocabularyKey(nameof(IsPostedViaIntercompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAccount = group.Add(new VocabularyKey(nameof(InvoiceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceName = group.Add(new VocabularyKey(nameof(InvoiceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                numberSequenceGroup = group.Add(new VocabularyKey(nameof(numberSequenceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOneTimeCustomer = group.Add(new VocabularyKey(nameof(IsOneTimeCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentSchedule = group.Add(new VocabularyKey(nameof(PaymentSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MethodOfPayment = group.Add(new VocabularyKey(nameof(MethodOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRequisition = group.Add(new VocabularyKey(nameof(CustomerRequisition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupId = group.Add(new VocabularyKey(nameof(SalesTaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxItemGroupId = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EInvoiceAccountCode = group.Add(new VocabularyKey(nameof(EInvoiceAccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EInvoiceIsLineSpecific = group.Add(new VocabularyKey(nameof(EInvoiceIsLineSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiroType = group.Add(new VocabularyKey(nameof(GiroType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLumpSumRecoveryTextPrinted = group.Add(new VocabularyKey(nameof(IsLumpSumRecoveryTextPrinted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerGroup = group.Add(new VocabularyKey(nameof(CustomerGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirectDebitMandateReference = group.Add(new VocabularyKey(nameof(DirectDebitMandateReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesDate = group.Add(new VocabularyKey(nameof(SalesDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VatDueDate = group.Add(new VocabularyKey(nameof(VatDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingClassification = group.Add(new VocabularyKey(nameof(BillingClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InclTax = group.Add(new VocabularyKey(nameof(InclTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostponedVAT = group.Add(new VocabularyKey(nameof(PostponedVAT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComplementaryFiscalDocumentType = group.Add(new VocabularyKey(nameof(ComplementaryFiscalDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                TransportationDocumentLineId = group.Add(new VocabularyKey(nameof(TransportationDocumentLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalInvoiceId = group.Add(new VocabularyKey(nameof(ExternalInvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsigneeAccount = group.Add(new VocabularyKey(nameof(ConsigneeAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsignorAccount = group.Add(new VocabularyKey(nameof(ConsignorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCorrection = group.Add(new VocabularyKey(nameof(IsCorrection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectedFactureDate = group.Add(new VocabularyKey(nameof(CorrectedFactureDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectedFactureExternalId = group.Add(new VocabularyKey(nameof(CorrectedFactureExternalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectedInvoiceDate = group.Add(new VocabularyKey(nameof(CorrectedInvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectedInvoiceId = group.Add(new VocabularyKey(nameof(CorrectedInvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectedPeriod = group.Add(new VocabularyKey(nameof(CorrectedPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionType = group.Add(new VocabularyKey(nameof(CorrectionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonRealRevenue = group.Add(new VocabularyKey(nameof(NonRealRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATOnPayment = group.Add(new VocabularyKey(nameof(VATOnPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceOriginCode = group.Add(new VocabularyKey(nameof(InvoiceOriginCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InvoiceIdentifier { get; private set; }
        public VocabularyKey FreeTextNumber { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey InvoiceId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey AdjustingInvoiceDate { get; private set; }
        public VocabularyKey CentralBankPurposeCode { get; private set; }
        public VocabularyKey CentralBankPurposeText { get; private set; }
        public VocabularyKey PaymentTermsBaseDate { get; private set; }
        public VocabularyKey PaymentTermsBaseDays { get; private set; }
        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey CashDiscountDate { get; private set; }
        public VocabularyKey CashDiscountPercentage { get; private set; }
        public VocabularyKey ComplimentedInvoiceId { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey CorrectionReasonCode { get; private set; }
        public VocabularyKey CashFlowForecast { get; private set; }
        public VocabularyKey BankAccountId { get; private set; }
        public VocabularyKey BillingClassificationId { get; private set; }
        public VocabularyKey CustomerReference { get; private set; }
        public VocabularyKey DirectDebitMandateId { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey IsPostedViaIntercompany { get; private set; }
        public VocabularyKey InvoiceAccount { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey InvoiceName { get; private set; }
        public VocabularyKey numberSequenceGroup { get; private set; }
        public VocabularyKey IsOneTimeCustomer { get; private set; }
        public VocabularyKey TermsOfPayment { get; private set; }
        public VocabularyKey PaymentSchedule { get; private set; }
        public VocabularyKey MethodOfPayment { get; private set; }
        public VocabularyKey IsPosted { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey CustomerRequisition { get; private set; }
        public VocabularyKey SalesTaxGroupId { get; private set; }
        public VocabularyKey SalesTaxItemGroupId { get; private set; }
        public VocabularyKey EInvoiceAccountCode { get; private set; }
        public VocabularyKey EInvoiceIsLineSpecific { get; private set; }
        public VocabularyKey GiroType { get; private set; }
        public VocabularyKey IsLumpSumRecoveryTextPrinted { get; private set; }
        public VocabularyKey CustomerGroup { get; private set; }
        public VocabularyKey DirectDebitMandateReference { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey SalesDate { get; private set; }
        public VocabularyKey VatDueDate { get; private set; }
        public VocabularyKey BillingClassification { get; private set; }
        public VocabularyKey InclTax { get; private set; }
        public VocabularyKey PostponedVAT { get; private set; }
        public VocabularyKey ComplementaryFiscalDocumentType { get; private set; }
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
        public VocabularyKey TransportationDocumentLineId { get; private set; }
        public VocabularyKey ExternalInvoiceId { get; private set; }
        public VocabularyKey ConsigneeAccount { get; private set; }
        public VocabularyKey ConsignorAccount { get; private set; }
        public VocabularyKey IsCorrection { get; private set; }
        public VocabularyKey CorrectedFactureDate { get; private set; }
        public VocabularyKey CorrectedFactureExternalId { get; private set; }
        public VocabularyKey CorrectedInvoiceDate { get; private set; }
        public VocabularyKey CorrectedInvoiceId { get; private set; }
        public VocabularyKey CorrectedPeriod { get; private set; }
        public VocabularyKey CorrectionType { get; private set; }
        public VocabularyKey NonRealRevenue { get; private set; }
        public VocabularyKey VATOnPayment { get; private set; }
        public VocabularyKey InvoiceOriginCode { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }


    }
}