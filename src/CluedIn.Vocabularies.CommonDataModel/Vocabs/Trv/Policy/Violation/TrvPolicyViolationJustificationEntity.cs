using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvPolicyViolationJustificationEntityVocabulary : SimpleVocabulary
    {
        public TrvPolicyViolationJustificationEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvPolicyViolationJustificationEntity";
            KeyPrefix = "commonDataModel.trvpolicyviolationjustificationentity";
            KeySeparator = ".";
            Grouping = "/TrvPolicyViolationJustificationEntity";

            AddGroup("Common Data Model TrvPolicyViolationJustificationEntity Details", group =>
            {
                JustificationId = group.Add(new VocabularyKey(nameof(JustificationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Action = group.Add(new VocabularyKey(nameof(Action), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JustificationText = group.Add(new VocabularyKey(nameof(JustificationText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JustifyingWorker = group.Add(new VocabularyKey(nameof(JustifyingWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ViolatingRecord = group.Add(new VocabularyKey(nameof(ViolatingRecord), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ViolatingRecordId = group.Add(new VocabularyKey(nameof(ViolatingRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ViolationJustificationType = group.Add(new VocabularyKey(nameof(ViolationJustificationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JustificationId { get; private set; }
        public VocabularyKey Action { get; private set; }
        public VocabularyKey JustificationText { get; private set; }
        public VocabularyKey JustifyingWorker { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey ViolatingRecord { get; private set; }
        public VocabularyKey ViolatingRecordId { get; private set; }
        public VocabularyKey ViolationJustificationType { get; private set; }


    }
}