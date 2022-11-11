using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerPaymentMethodEntityVocabulary : SimpleVocabulary
    {
        public CustomerPaymentMethodEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustomerPaymentMethodEntity";
            KeyPrefix = "commonDataModel.customerpaymentmethodentity";
            KeySeparator = ".";
            Grouping = "/CustomerPaymentMethodEntity";

            AddGroup("Common Data Model CustomerPaymentMethodEntity Details", group =>
            {
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankTransactionType = group.Add(new VocabularyKey(nameof(BankTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExportFormatClassId = group.Add(new VocabularyKey(nameof(ExportFormatClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportFormatClassId = group.Add(new VocabularyKey(nameof(ImportFormatClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceFormatClassId = group.Add(new VocabularyKey(nameof(RemittanceFormatClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnFormatClassId = group.Add(new VocabularyKey(nameof(ReturnFormatClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountGracePeriodDays = group.Add(new VocabularyKey(nameof(DiscountGracePeriodDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExportBillOfExchangeDuringInvoicePosting = group.Add(new VocabularyKey(nameof(ExportBillOfExchangeDuringInvoicePosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BridgingPostingEnabled = group.Add(new VocabularyKey(nameof(BridgingPostingEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BridgingPostingAccount = group.Add(new VocabularyKey(nameof(BridgingPostingAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSEPA = group.Add(new VocabularyKey(nameof(IsSEPA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastFileNumber = group.Add(new VocabularyKey(nameof(LastFileNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastFileDate = group.Add(new VocabularyKey(nameof(LastFileDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastFileNumberToday = group.Add(new VocabularyKey(nameof(LastFileNumberToday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentAccount = group.Add(new VocabularyKey(nameof(PaymentAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentType = group.Add(new VocabularyKey(nameof(PaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentJournalName = group.Add(new VocabularyKey(nameof(PaymentJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateAndDrawBillOfExchangeDuringInvoicePosting = group.Add(new VocabularyKey(nameof(CreateAndDrawBillOfExchangeDuringInvoicePosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentStatus = group.Add(new VocabularyKey(nameof(PaymentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SumByPeriod = group.Add(new VocabularyKey(nameof(SumByPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnablePostdatedCheckClearingPosting = group.Add(new VocabularyKey(nameof(EnablePostdatedCheckClearingPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillOfExchangeDraftType = group.Add(new VocabularyKey(nameof(BillOfExchangeDraftType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BridgingPostingAccountDisplayValue = group.Add(new VocabularyKey(nameof(BridgingPostingAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentAccountDisplayValue = group.Add(new VocabularyKey(nameof(PaymentAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExportFormatClassName = group.Add(new VocabularyKey(nameof(ExportFormatClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportFormatClassName = group.Add(new VocabularyKey(nameof(ImportFormatClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceFormatClassName = group.Add(new VocabularyKey(nameof(RemittanceFormatClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnFormatClassName = group.Add(new VocabularyKey(nameof(ReturnFormatClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateTransactionTypeIsBank = group.Add(new VocabularyKey(nameof(ValidateTransactionTypeIsBank), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateOffsetTransactionTypeIsBank = group.Add(new VocabularyKey(nameof(ValidateOffsetTransactionTypeIsBank), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateCheckNumberIsMandatory = group.Add(new VocabularyKey(nameof(ValidateCheckNumberIsMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidatePaymentReferenceIsMandatory = group.Add(new VocabularyKey(nameof(ValidatePaymentReferenceIsMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateDepositSlipIsMandatory = group.Add(new VocabularyKey(nameof(ValidateDepositSlipIsMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributePaymentAccountEnabled = group.Add(new VocabularyKey(nameof(AttributePaymentAccountEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeThirdPartyBankEnabled = group.Add(new VocabularyKey(nameof(AttributeThirdPartyBankEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributePaymentIdEnabled = group.Add(new VocabularyKey(nameof(AttributePaymentIdEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeBelgianStructuredPaymentIdEnabled = group.Add(new VocabularyKey(nameof(AttributeBelgianStructuredPaymentIdEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseGERConfiguration = group.Add(new VocabularyKey(nameof(UseGERConfiguration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SATPaymentType = group.Add(new VocabularyKey(nameof(SATPaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERFormatMapping = group.Add(new VocabularyKey(nameof(ERFormatMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERSolution = group.Add(new VocabularyKey(nameof(ERSolution), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERProvider = group.Add(new VocabularyKey(nameof(ERProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionControl = group.Add(new VocabularyKey(nameof(DimensionControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttributeSet = group.Add(new VocabularyKey(nameof(DimensionAttributeSet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttributeDisplayValue = group.Add(new VocabularyKey(nameof(DimensionAttributeDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DescriptionPrimaryMethodPayment = group.Add(new VocabularyKey(nameof(DescriptionPrimaryMethodPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExportLayoutGroupId = group.Add(new VocabularyKey(nameof(ExportLayoutGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnLayoutGroupId = group.Add(new VocabularyKey(nameof(ReturnLayoutGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryMethodPayment = group.Add(new VocabularyKey(nameof(PrimaryMethodPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ERModelMappingTable = group.Add(new VocabularyKey(nameof(ERModelMappingTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirectDebit = group.Add(new VocabularyKey(nameof(DirectDebit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SplitPayment = group.Add(new VocabularyKey(nameof(SplitPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfileBillsRemitCollection = group.Add(new VocabularyKey(nameof(PostingProfileBillsRemitCollection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfileBillsRemitDiscount = group.Add(new VocabularyKey(nameof(PostingProfileBillsRemitDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey BankTransactionType { get; private set; }
        public VocabularyKey ExportFormatClassId { get; private set; }
        public VocabularyKey ImportFormatClassId { get; private set; }
        public VocabularyKey RemittanceFormatClassId { get; private set; }
        public VocabularyKey ReturnFormatClassId { get; private set; }
        public VocabularyKey DiscountGracePeriodDays { get; private set; }
        public VocabularyKey ExportBillOfExchangeDuringInvoicePosting { get; private set; }
        public VocabularyKey BridgingPostingEnabled { get; private set; }
        public VocabularyKey BridgingPostingAccount { get; private set; }
        public VocabularyKey IsSEPA { get; private set; }
        public VocabularyKey LastFileNumber { get; private set; }
        public VocabularyKey LastFileDate { get; private set; }
        public VocabularyKey LastFileNumberToday { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PaymentAccount { get; private set; }
        public VocabularyKey PaymentType { get; private set; }
        public VocabularyKey PaymentJournalName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CreateAndDrawBillOfExchangeDuringInvoicePosting { get; private set; }
        public VocabularyKey PaymentStatus { get; private set; }
        public VocabularyKey SumByPeriod { get; private set; }
        public VocabularyKey EnablePostdatedCheckClearingPosting { get; private set; }
        public VocabularyKey BillOfExchangeDraftType { get; private set; }
        public VocabularyKey BridgingPostingAccountDisplayValue { get; private set; }
        public VocabularyKey PaymentAccountDisplayValue { get; private set; }
        public VocabularyKey ExportFormatClassName { get; private set; }
        public VocabularyKey ImportFormatClassName { get; private set; }
        public VocabularyKey RemittanceFormatClassName { get; private set; }
        public VocabularyKey ReturnFormatClassName { get; private set; }
        public VocabularyKey ValidateTransactionTypeIsBank { get; private set; }
        public VocabularyKey ValidateOffsetTransactionTypeIsBank { get; private set; }
        public VocabularyKey ValidateCheckNumberIsMandatory { get; private set; }
        public VocabularyKey ValidatePaymentReferenceIsMandatory { get; private set; }
        public VocabularyKey ValidateDepositSlipIsMandatory { get; private set; }
        public VocabularyKey AttributePaymentAccountEnabled { get; private set; }
        public VocabularyKey AttributeThirdPartyBankEnabled { get; private set; }
        public VocabularyKey AttributePaymentIdEnabled { get; private set; }
        public VocabularyKey AttributeBelgianStructuredPaymentIdEnabled { get; private set; }
        public VocabularyKey UseGERConfiguration { get; private set; }
        public VocabularyKey SATPaymentType { get; private set; }
        public VocabularyKey ERFormatMapping { get; private set; }
        public VocabularyKey ERSolution { get; private set; }
        public VocabularyKey ERProvider { get; private set; }
        public VocabularyKey DimensionControl { get; private set; }
        public VocabularyKey DimensionAttributeSet { get; private set; }
        public VocabularyKey DimensionAttributeDisplayValue { get; private set; }
        public VocabularyKey DescriptionPrimaryMethodPayment { get; private set; }
        public VocabularyKey ExportLayoutGroupId { get; private set; }
        public VocabularyKey ReturnLayoutGroupId { get; private set; }
        public VocabularyKey PrimaryMethodPayment { get; private set; }
        public VocabularyKey ERModelMappingTable { get; private set; }
        public VocabularyKey DirectDebit { get; private set; }
        public VocabularyKey SplitPayment { get; private set; }
        public VocabularyKey PostingProfileBillsRemitCollection { get; private set; }
        public VocabularyKey PostingProfileBillsRemitDiscount { get; private set; }


    }
}