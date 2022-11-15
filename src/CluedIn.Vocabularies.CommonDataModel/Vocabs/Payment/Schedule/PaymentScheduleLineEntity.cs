using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentScheduleLineEntityVocabulary : SimpleVocabulary
    {
        public PaymentScheduleLineEntityVocabulary()
        {
            VocabularyName = "Payment Schedule Line Entity";
            KeyPrefix = "commonDataModel.paymentschedulelineentity";
            KeySeparator = ".";
            Grouping = "/PaymentScheduleLineEntity";

            AddGroup("PaymentScheduleLineEntity Details", group =>
            {
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsShippingLine = group.Add(new VocabularyKey(nameof(IsShippingLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentScheduleName = group.Add(new VocabularyKey(nameof(PaymentScheduleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PercentOrAmount = group.Add(new VocabularyKey(nameof(PercentOrAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodsAfterDueDate = group.Add(new VocabularyKey(nameof(PeriodsAfterDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PercentOrAmountValue = group.Add(new VocabularyKey(nameof(PercentOrAmountValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey IsShippingLine { get; private set; }
        public VocabularyKey PaymentScheduleName { get; private set; }
        public VocabularyKey PercentOrAmount { get; private set; }
        public VocabularyKey PeriodsAfterDueDate { get; private set; }
        public VocabularyKey PercentOrAmountValue { get; private set; }
    }
}