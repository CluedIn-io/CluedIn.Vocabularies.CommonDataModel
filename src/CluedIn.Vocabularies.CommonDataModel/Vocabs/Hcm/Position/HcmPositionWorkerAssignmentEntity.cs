using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPositionWorkerAssignmentEntityVocabulary : SimpleVocabulary
    {
        public HcmPositionWorkerAssignmentEntityVocabulary()
        {
            VocabularyName = "Hcm Position Worker Assignment Entity";
            KeyPrefix = "commonDataModel.hcmpositionworkerassignmententity";
            KeySeparator = ".";
            Grouping = "/HcmPositionWorkerAssignmentEntity";

            AddGroup("HcmPositionWorkerAssignmentEntity Details", group =>
            {
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCodeId = group.Add(new VocabularyKey(nameof(ReasonCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimaryPosition = group.Add(new VocabularyKey(nameof(IsPrimaryPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
        public VocabularyKey ReasonCodeId { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey IsPrimaryPosition { get; private set; }
    }
}