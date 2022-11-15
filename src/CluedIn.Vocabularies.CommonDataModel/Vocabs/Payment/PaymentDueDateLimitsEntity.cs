using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentDueDateLimitsEntityVocabulary : SimpleVocabulary
    {
        public PaymentDueDateLimitsEntityVocabulary()
        {
            VocabularyName = "Payment Due Date Limits Entity";
            KeyPrefix = "commonDataModel.paymentduedatelimitsentity";
            KeySeparator = ".";
            Grouping = "/PaymentDueDateLimitsEntity";

            AddGroup("PaymentDueDateLimitsEntity Details", group =>
            {
                DueDateLimit = group.Add(new VocabularyKey(nameof(DueDateLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodInterval = group.Add(new VocabularyKey(nameof(PeriodInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfUnits = group.Add(new VocabularyKey(nameof(NumberOfUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DueDateLimit { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PeriodInterval { get; private set; }
        public VocabularyKey NumberOfUnits { get; private set; }
    }
}