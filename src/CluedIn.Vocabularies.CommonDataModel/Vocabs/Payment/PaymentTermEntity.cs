using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentTermEntityVocabulary : SimpleVocabulary
    {
        public PaymentTermEntityVocabulary()
        {
            VocabularyName = "Payment Term Entity";
            KeyPrefix = "commonDataModel.paymenttermentity";
            KeySeparator = ".";
            Grouping = "/PaymentTermEntity";

            AddGroup("PaymentTermEntity Details", group =>
            {
                AdditionalMonthsForCutoffDate = group.Add(new VocabularyKey(nameof(AdditionalMonthsForCutoffDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCashPayment = group.Add(new VocabularyKey(nameof(IsCashPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashPaymentMainAccountId = group.Add(new VocabularyKey(nameof(CashPaymentMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditCardCreditCheckType = group.Add(new VocabularyKey(nameof(CreditCardCreditCheckType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditCardPaymentType = group.Add(new VocabularyKey(nameof(CreditCardPaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerDueDateUpdatePolicy = group.Add(new VocabularyKey(nameof(CustomerDueDateUpdatePolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CutoffDayOfMonth = group.Add(new VocabularyKey(nameof(CutoffDayOfMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultPaymentTerm = group.Add(new VocabularyKey(nameof(IsDefaultPaymentTerm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfDays = group.Add(new VocabularyKey(nameof(NumberOfDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfMonths = group.Add(new VocabularyKey(nameof(NumberOfMonths), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentDayName = group.Add(new VocabularyKey(nameof(PaymentDayName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentMethodType = group.Add(new VocabularyKey(nameof(PaymentMethodType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentScheduleName = group.Add(new VocabularyKey(nameof(PaymentScheduleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCertifiedCompanyCheck = group.Add(new VocabularyKey(nameof(IsCertifiedCompanyCheck), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorDueDateUpdatePolicy = group.Add(new VocabularyKey(nameof(VendorDueDateUpdatePolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashPaymentMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(CashPaymentMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostOffsettingAR = group.Add(new VocabularyKey(nameof(PostOffsettingAR), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AdditionalMonthsForCutoffDate { get; private set; }
        public VocabularyKey IsCashPayment { get; private set; }
        public VocabularyKey CashPaymentMainAccountId { get; private set; }
        public VocabularyKey CreditCardCreditCheckType { get; private set; }
        public VocabularyKey CreditCardPaymentType { get; private set; }
        public VocabularyKey CustomerDueDateUpdatePolicy { get; private set; }
        public VocabularyKey CutoffDayOfMonth { get; private set; }
        public VocabularyKey IsDefaultPaymentTerm { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey NumberOfDays { get; private set; }
        public VocabularyKey NumberOfMonths { get; private set; }
        public VocabularyKey PaymentDayName { get; private set; }
        public VocabularyKey PaymentMethodType { get; private set; }
        public VocabularyKey PaymentScheduleName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey IsCertifiedCompanyCheck { get; private set; }
        public VocabularyKey VendorDueDateUpdatePolicy { get; private set; }
        public VocabularyKey CashPaymentMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey PostOffsettingAR { get; private set; }
    }
}