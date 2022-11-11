using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollPayPeriodEntityVocabulary : SimpleVocabulary
    {
        public PayrollPayPeriodEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollPayPeriodEntity";
            KeyPrefix = "commonDataModel.payrollpayperiodentity";
            KeySeparator = ".";
            Grouping = "/PayrollPayPeriodEntity";

            AddGroup("Common Data Model PayrollPayPeriodEntity Details", group =>
            {
                DefaultPaymentDate = group.Add(new VocabularyKey(nameof(DefaultPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comments = group.Add(new VocabularyKey(nameof(Comments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayCycle = group.Add(new VocabularyKey(nameof(PayCycle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodEndDate = group.Add(new VocabularyKey(nameof(PeriodEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodStartDate = group.Add(new VocabularyKey(nameof(PeriodStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayCycleId = group.Add(new VocabularyKey(nameof(PayCycleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DefaultPaymentDate { get; private set; }
        public VocabularyKey Comments { get; private set; }
        public VocabularyKey PayCycle { get; private set; }
        public VocabularyKey PeriodEndDate { get; private set; }
        public VocabularyKey PeriodStartDate { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey PayCycleId { get; private set; }


    }
}