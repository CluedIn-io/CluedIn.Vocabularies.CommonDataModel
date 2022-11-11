using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectContractHeaderEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectContractHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjProjectContractHeaderEntity";
            KeyPrefix = "commonDataModel.projprojectcontractheaderentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectContractHeaderEntity";

            AddGroup("Common Data Model ProjProjectContractHeaderEntity Details", group =>
            {
                BankAccountId = group.Add(new VocabularyKey(nameof(BankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CentralBankPurposeCode = group.Add(new VocabularyKey(nameof(CentralBankPurposeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CentralBankPurposeText = group.Add(new VocabularyKey(nameof(CentralBankPurposeText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesCurrencyCode = group.Add(new VocabularyKey(nameof(SalesCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRequisitionNumber = group.Add(new VocabularyKey(nameof(CustomerRequisitionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomersOrderReference = group.Add(new VocabularyKey(nameof(CustomersOrderReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EInvoiceDimensionAccountCode = group.Add(new VocabularyKey(nameof(EInvoiceDimensionAccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsEInvoiceDimensionAccountCodeSpecifiedPerLine = group.Add(new VocabularyKey(nameof(IsEInvoiceDimensionAccountCodeSpecifiedPerLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceFrequency = group.Add(new VocabularyKey(nameof(InvoiceFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiroTypeProjInvoice = group.Add(new VocabularyKey(nameof(GiroTypeProjInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndividualBufferDays = group.Add(new VocabularyKey(nameof(IndividualBufferDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatAdditionalValue = group.Add(new VocabularyKey(nameof(IntrastatAdditionalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ListCode = group.Add(new VocabularyKey(nameof(ListCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentScheduleName = group.Add(new VocabularyKey(nameof(PaymentScheduleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPostingProfileId = group.Add(new VocabularyKey(nameof(CustomerPostingProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetPrice = group.Add(new VocabularyKey(nameof(NetPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectContractId = group.Add(new VocabularyKey(nameof(ProjectContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsContractSalesCurrencyCodeLocked = group.Add(new VocabularyKey(nameof(IsContractSalesCurrencyCodeLocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceCustomerGroupCode = group.Add(new VocabularyKey(nameof(PriceCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesResponsibleRecId = group.Add(new VocabularyKey(nameof(SalesResponsibleRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsServiceDeliveryAddressBased = group.Add(new VocabularyKey(nameof(IsServiceDeliveryAddressBased), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransactionCode = group.Add(new VocabularyKey(nameof(IntrastatTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(SalesResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegrationSourceDataId = group.Add(new VocabularyKey(nameof(IntegrationSourceDataId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BankAccountId { get; private set; }
        public VocabularyKey CentralBankPurposeCode { get; private set; }
        public VocabularyKey CentralBankPurposeText { get; private set; }
        public VocabularyKey CashDiscountCode { get; private set; }
        public VocabularyKey SalesCurrencyCode { get; private set; }
        public VocabularyKey CustomerRequisitionNumber { get; private set; }
        public VocabularyKey CustomersOrderReference { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey EInvoiceDimensionAccountCode { get; private set; }
        public VocabularyKey IsEInvoiceDimensionAccountCodeSpecifiedPerLine { get; private set; }
        public VocabularyKey InvoiceFrequency { get; private set; }
        public VocabularyKey GiroTypeProjInvoice { get; private set; }
        public VocabularyKey IndividualBufferDays { get; private set; }
        public VocabularyKey IntrastatAdditionalValue { get; private set; }
        public VocabularyKey ListCode { get; private set; }
        public VocabularyKey TermsOfPayment { get; private set; }
        public VocabularyKey PaymentScheduleName { get; private set; }
        public VocabularyKey CustomerPostingProfileId { get; private set; }
        public VocabularyKey NetPrice { get; private set; }
        public VocabularyKey ProjectContractId { get; private set; }
        public VocabularyKey IsContractSalesCurrencyCodeLocked { get; private set; }
        public VocabularyKey PriceCustomerGroupCode { get; private set; }
        public VocabularyKey SalesResponsibleRecId { get; private set; }
        public VocabularyKey SalesTaxGroupCode { get; private set; }
        public VocabularyKey IsServiceDeliveryAddressBased { get; private set; }
        public VocabularyKey IntrastatTransactionCode { get; private set; }
        public VocabularyKey SalesResponsiblePersonnelNumber { get; private set; }
        public VocabularyKey IntegrationSourceDataId { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }


    }
}