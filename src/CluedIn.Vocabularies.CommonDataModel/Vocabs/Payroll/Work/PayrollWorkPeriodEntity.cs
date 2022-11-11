using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkPeriodEntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkPeriodEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollWorkPeriodEntity";
            KeyPrefix = "commonDataModel.payrollworkperiodentity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkPeriodEntity";

            AddGroup("Common Data Model PayrollWorkPeriodEntity Details", group =>
            {
                Comments = group.Add(new VocabularyKey(nameof(Comments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodEndDate = group.Add(new VocabularyKey(nameof(PeriodEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodStartDate = group.Add(new VocabularyKey(nameof(PeriodStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkCycle = group.Add(new VocabularyKey(nameof(WorkCycle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkCycleId = group.Add(new VocabularyKey(nameof(WorkCycleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Comments { get; private set; }
        public VocabularyKey PeriodEndDate { get; private set; }
        public VocabularyKey PeriodStartDate { get; private set; }
        public VocabularyKey WorkCycle { get; private set; }
        public VocabularyKey WorkCycleId { get; private set; }


    }
}