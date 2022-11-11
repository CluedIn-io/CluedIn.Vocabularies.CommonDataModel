using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollAccrualPlanEntityVocabulary : SimpleVocabulary
    {
        public PayrollAccrualPlanEntityVocabulary()
        {
            VocabularyName = "PayrollAccrualPlanEntity";
            KeyPrefix = "commonDataModel.payrollaccrualplanentity";
            KeySeparator = ".";
            Grouping = "/PayrollAccrualPlanEntity";

            AddGroup("PayrollAccrualPlanEntity Details", group =>
            {
                AccrualId = group.Add(new VocabularyKey(nameof(AccrualId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CanCarryForward = group.Add(new VocabularyKey(nameof(CanCarryForward), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIncludedInAccrual = group.Add(new VocabularyKey(nameof(IsIncludedInAccrual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartingDate = group.Add(new VocabularyKey(nameof(StartingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrualMethod = group.Add(new VocabularyKey(nameof(AccrualMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomAccrualDate = group.Add(new VocabularyKey(nameof(CustomAccrualDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Frequency = group.Add(new VocabularyKey(nameof(Frequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerAccrualDateMethod = group.Add(new VocabularyKey(nameof(WorkerAccrualDateMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculationFrequency = group.Add(new VocabularyKey(nameof(CalculationFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccrualId { get; private set; }
        public VocabularyKey CanCarryForward { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsIncludedInAccrual { get; private set; }
        public VocabularyKey StartingDate { get; private set; }
        public VocabularyKey AccrualMethod { get; private set; }
        public VocabularyKey CustomAccrualDate { get; private set; }
        public VocabularyKey Frequency { get; private set; }
        public VocabularyKey WorkerAccrualDateMethod { get; private set; }
        public VocabularyKey CalculationFrequency { get; private set; }


    }
}