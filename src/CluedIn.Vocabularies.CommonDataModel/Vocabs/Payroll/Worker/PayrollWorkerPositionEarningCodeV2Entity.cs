using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkerPositionEarningCodeV2EntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkerPositionEarningCodeV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollWorkerPositionEarningCodeV2Entity";
            KeyPrefix = "commonDataModel.payrollworkerpositionearningcodev2entity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkerPositionEarningCodeV2Entity";

            AddGroup("Common Data Model PayrollWorkerPositionEarningCodeV2Entity Details", group =>
            {
                Frequency = group.Add(new VocabularyKey(nameof(Frequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FrequencyId = group.Add(new VocabularyKey(nameof(FrequencyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Frequency { get; private set; }
        public VocabularyKey EarningCode { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey EarningCodeId { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey FrequencyId { get; private set; }


    }
}