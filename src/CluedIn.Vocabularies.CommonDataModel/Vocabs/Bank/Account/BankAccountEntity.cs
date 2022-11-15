using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankAccountEntityVocabulary : SimpleVocabulary
    {
        public BankAccountEntityVocabulary()
        {
            VocabularyName = "Bank Account Entity";
            KeyPrefix = "commonDataModel.bankaccountentity";
            KeySeparator = ".";
            Grouping = "/BankAccountEntity";

            AddGroup("BankAccountEntity Details", group =>
            {
                NonSufficientFundsJournalName = group.Add(new VocabularyKey(nameof(NonSufficientFundsJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccountId = group.Add(new VocabularyKey(nameof(BankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KanaName = group.Add(new VocabularyKey(nameof(KanaName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNumber = group.Add(new VocabularyKey(nameof(AccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveFrom = group.Add(new VocabularyKey(nameof(ActiveFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveTo = group.Add(new VocabularyKey(nameof(ActiveTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccountStatus = group.Add(new VocabularyKey(nameof(BankAccountStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClearingCode = group.Add(new VocabularyKey(nameof(ClearingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoutingNumberType = group.Add(new VocabularyKey(nameof(RoutingNumberType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyStatementName = group.Add(new VocabularyKey(nameof(CompanyStatementName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractPostAccount = group.Add(new VocabularyKey(nameof(ContractPostAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationName = group.Add(new VocabularyKey(nameof(DestinationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankGroupId = group.Add(new VocabularyKey(nameof(BankGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowTransactionsInAdditionalCurrencies = group.Add(new VocabularyKey(nameof(AllowTransactionsInAdditionalCurrencies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowedPennyDifferenceForReconciliation = group.Add(new VocabularyKey(nameof(AllowedPennyDifferenceForReconciliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableAdvancedBankReconciliation = group.Add(new VocabularyKey(nameof(EnableAdvancedBankReconciliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconciliationMatchingRuleSetRefRecId = group.Add(new VocabularyKey(nameof(ReconciliationMatchingRuleSetRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconciliationMatchingRuleSetId = group.Add(new VocabularyKey(nameof(ReconciliationMatchingRuleSetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseBankStatementsAsConfirmationOfElectronicPayments = group.Add(new VocabularyKey(nameof(UseBankStatementsAsConfirmationOfElectronicPayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconcileAfterStatementImport = group.Add(new VocabularyKey(nameof(ReconcileAfterStatementImport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortCode = group.Add(new VocabularyKey(nameof(SortCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankStatementFormatRefRecId = group.Add(new VocabularyKey(nameof(BankStatementFormatRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankStatementFormatId = group.Add(new VocabularyKey(nameof(BankStatementFormatId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementName = group.Add(new VocabularyKey(nameof(StatementName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Suffix = group.Add(new VocabularyKey(nameof(Suffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer = group.Add(new VocabularyKey(nameof(Drawer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactMobilePhone = group.Add(new VocabularyKey(nameof(ContactMobilePhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BanksIdentificationOfCompany = group.Add(new VocabularyKey(nameof(BanksIdentificationOfCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactName = group.Add(new VocabularyKey(nameof(ContactName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentFeeMainAccountId = group.Add(new VocabularyKey(nameof(CustomerPaymentFeeMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentFeeMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(CustomerPaymentFeeMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostCustomerPaymentFee = group.Add(new VocabularyKey(nameof(PostCustomerPaymentFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirectDebitId = group.Add(new VocabularyKey(nameof(DirectDebitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentDiscountingMaximum = group.Add(new VocabularyKey(nameof(PaymentDiscountingMaximum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactEmail = group.Add(new VocabularyKey(nameof(ContactEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeESRAccountNumber = group.Add(new VocabularyKey(nameof(FeeESRAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BESRIdNumber = group.Add(new VocabularyKey(nameof(BESRIdNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ESR = group.Add(new VocabularyKey(nameof(ESR), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IBAN = group.Add(new VocabularyKey(nameof(IBAN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceRemitFee = group.Add(new VocabularyKey(nameof(InvoiceRemitFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceRemitMainAccountId = group.Add(new VocabularyKey(nameof(InvoiceRemitMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceRemitMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(InvoiceRemitMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrenoteRequired = group.Add(new VocabularyKey(nameof(IsPrenoteRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankMainAccountId = group.Add(new VocabularyKey(nameof(BankMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(BankMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeJournalName = group.Add(new VocabularyKey(nameof(FeeJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonSufficientFundsChargesGroupId = group.Add(new VocabularyKey(nameof(NonSufficientFundsChargesGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditLimit = group.Add(new VocabularyKey(nameof(CreditLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPager = group.Add(new VocabularyKey(nameof(ContactPager), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPhoneNumber = group.Add(new VocabularyKey(nameof(ContactPhoneNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPhoneNumberExtension = group.Add(new VocabularyKey(nameof(ContactPhoneNumberExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrenoteResponseDays = group.Add(new VocabularyKey(nameof(PrenoteResponseDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoutingNumber = group.Add(new VocabularyKey(nameof(RoutingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionExpensesFee = group.Add(new VocabularyKey(nameof(CollectionExpensesFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountInterestsFee = group.Add(new VocabularyKey(nameof(DiscountInterestsFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionMainAccountId = group.Add(new VocabularyKey(nameof(CollectionMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(CollectionMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountMainAccountId = group.Add(new VocabularyKey(nameof(DiscountMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(DiscountMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFCNumber = group.Add(new VocabularyKey(nameof(RFCNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactSMS = group.Add(new VocabularyKey(nameof(ContactSMS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SWIFTCode = group.Add(new VocabularyKey(nameof(SWIFTCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactFaxNumber = group.Add(new VocabularyKey(nameof(ContactFaxNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactTelexNumber = group.Add(new VocabularyKey(nameof(ContactTelexNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactInternetAddress = group.Add(new VocabularyKey(nameof(ContactInternetAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullPrimaryAddress = group.Add(new VocabularyKey(nameof(FullPrimaryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountry = group.Add(new VocabularyKey(nameof(AddressCountry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryISOCode = group.Add(new VocabularyKey(nameof(AddressCountryISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositivePayFormatName = group.Add(new VocabularyKey(nameof(PositivePayFormatName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositivePayStartDate = group.Add(new VocabularyKey(nameof(PositivePayStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankTransactionType = group.Add(new VocabularyKey(nameof(BankTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankConstantSymbol = group.Add(new VocabularyKey(nameof(BankConstantSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankSpecificSymbol = group.Add(new VocabularyKey(nameof(BankSpecificSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ControlInternalNumber = group.Add(new VocabularyKey(nameof(ControlInternalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfileBillsRemitCollection_IT = group.Add(new VocabularyKey(nameof(PostingProfileBillsRemitCollection_IT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfileBillsRemitDiscount_IT = group.Add(new VocabularyKey(nameof(PostingProfileBillsRemitDiscount_IT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfileRemitNotes_IT = group.Add(new VocabularyKey(nameof(PostingProfileRemitNotes_IT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QRIBAN = group.Add(new VocabularyKey(nameof(QRIBAN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey NonSufficientFundsJournalName { get; private set; }
        public VocabularyKey BankAccountId { get; private set; }
        public VocabularyKey KanaName { get; private set; }
        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey ActiveFrom { get; private set; }
        public VocabularyKey ActiveTo { get; private set; }
        public VocabularyKey BankAccountStatus { get; private set; }
        public VocabularyKey ClearingCode { get; private set; }
        public VocabularyKey RoutingNumberType { get; private set; }
        public VocabularyKey CompanyStatementName { get; private set; }
        public VocabularyKey ContractPostAccount { get; private set; }
        public VocabularyKey DestinationName { get; private set; }
        public VocabularyKey BankGroupId { get; private set; }
        public VocabularyKey AllowTransactionsInAdditionalCurrencies { get; private set; }
        public VocabularyKey AllowedPennyDifferenceForReconciliation { get; private set; }
        public VocabularyKey EnableAdvancedBankReconciliation { get; private set; }
        public VocabularyKey ReconciliationMatchingRuleSetRefRecId { get; private set; }
        public VocabularyKey ReconciliationMatchingRuleSetId { get; private set; }
        public VocabularyKey UseBankStatementsAsConfirmationOfElectronicPayments { get; private set; }
        public VocabularyKey ReconcileAfterStatementImport { get; private set; }
        public VocabularyKey SortCode { get; private set; }
        public VocabularyKey BankStatementFormatRefRecId { get; private set; }
        public VocabularyKey BankStatementFormatId { get; private set; }
        public VocabularyKey StatementName { get; private set; }
        public VocabularyKey Suffix { get; private set; }
        public VocabularyKey Drawer { get; private set; }
        public VocabularyKey ContactMobilePhone { get; private set; }
        public VocabularyKey BanksIdentificationOfCompany { get; private set; }
        public VocabularyKey ContactName { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CustomerPaymentFeeMainAccountId { get; private set; }
        public VocabularyKey CustomerPaymentFeeMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey PostCustomerPaymentFee { get; private set; }
        public VocabularyKey DirectDebitId { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey PaymentDiscountingMaximum { get; private set; }
        public VocabularyKey ContactEmail { get; private set; }
        public VocabularyKey FeeESRAccountNumber { get; private set; }
        public VocabularyKey BESRIdNumber { get; private set; }
        public VocabularyKey ESR { get; private set; }
        public VocabularyKey IBAN { get; private set; }
        public VocabularyKey InvoiceRemitFee { get; private set; }
        public VocabularyKey InvoiceRemitMainAccountId { get; private set; }
        public VocabularyKey InvoiceRemitMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey IsPrenoteRequired { get; private set; }
        public VocabularyKey BankMainAccountId { get; private set; }
        public VocabularyKey BankMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey FeeJournalName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NonSufficientFundsChargesGroupId { get; private set; }
        public VocabularyKey CreditLimit { get; private set; }
        public VocabularyKey ContactPager { get; private set; }
        public VocabularyKey ContactPhoneNumber { get; private set; }
        public VocabularyKey ContactPhoneNumberExtension { get; private set; }
        public VocabularyKey PrenoteResponseDays { get; private set; }
        public VocabularyKey RoutingNumber { get; private set; }
        public VocabularyKey CollectionExpensesFee { get; private set; }
        public VocabularyKey DiscountInterestsFee { get; private set; }
        public VocabularyKey CollectionMainAccountId { get; private set; }
        public VocabularyKey CollectionMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey DiscountMainAccountId { get; private set; }
        public VocabularyKey DiscountMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey RFCNumber { get; private set; }
        public VocabularyKey ContactSMS { get; private set; }
        public VocabularyKey SWIFTCode { get; private set; }
        public VocabularyKey ContactFaxNumber { get; private set; }
        public VocabularyKey ContactTelexNumber { get; private set; }
        public VocabularyKey ContactInternetAddress { get; private set; }
        public VocabularyKey FullPrimaryAddress { get; private set; }
        public VocabularyKey AddressLocationId { get; private set; }
        public VocabularyKey AddressDescription { get; private set; }
        public VocabularyKey AddressCountry { get; private set; }
        public VocabularyKey AddressCountryISOCode { get; private set; }
        public VocabularyKey AddressState { get; private set; }
        public VocabularyKey AddressCounty { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressStreet { get; private set; }
        public VocabularyKey AddressZipCode { get; private set; }
        public VocabularyKey AddressDistrictName { get; private set; }
        public VocabularyKey AddressLatitude { get; private set; }
        public VocabularyKey AddressLongitude { get; private set; }
        public VocabularyKey AddressValidTo { get; private set; }
        public VocabularyKey AddressValidFrom { get; private set; }
        public VocabularyKey AddressTimeZone { get; private set; }
        public VocabularyKey PositivePayFormatName { get; private set; }
        public VocabularyKey PositivePayStartDate { get; private set; }
        public VocabularyKey BankTransactionType { get; private set; }
        public VocabularyKey BankConstantSymbol { get; private set; }
        public VocabularyKey BankSpecificSymbol { get; private set; }
        public VocabularyKey ControlInternalNumber { get; private set; }
        public VocabularyKey PostingProfileBillsRemitCollection_IT { get; private set; }
        public VocabularyKey PostingProfileBillsRemitDiscount_IT { get; private set; }
        public VocabularyKey PostingProfileRemitNotes_IT { get; private set; }
        public VocabularyKey QRIBAN { get; private set; }
    }
}