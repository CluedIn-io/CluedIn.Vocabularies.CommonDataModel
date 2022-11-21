using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectTaskEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectTaskEntityVocabulary()
        {
            VocabularyName = "Proj Project Task Entity";
            KeyPrefix = "commonDataModel.projprojecttaskentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectTaskEntity";

            AddGroup("ProjProjectTaskEntity Details", group =>
            {
                TaskElementId = group.Add(new VocabularyKey(nameof(TaskElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskHierarchyId = group.Add(new VocabularyKey(nameof(TaskHierarchyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskOutlineLevel = group.Add(new VocabularyKey(nameof(TaskOutlineLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskName = group.Add(new VocabularyKey(nameof(TaskName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentTaskElementId = group.Add(new VocabularyKey(nameof(ParentTaskElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskNumberRecordId = group.Add(new VocabularyKey(nameof(TaskNumberRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskDisplaySequence = group.Add(new VocabularyKey(nameof(TaskDisplaySequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskId = group.Add(new VocabularyKey(nameof(TaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskTimeType = group.Add(new VocabularyKey(nameof(TaskTimeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskStatus = group.Add(new VocabularyKey(nameof(TaskStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskOwningCompany = group.Add(new VocabularyKey(nameof(TaskOwningCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskSubject = group.Add(new VocabularyKey(nameof(TaskSubject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TaskElementId { get; private set; }
        public VocabularyKey TaskHierarchyId { get; private set; }
        public VocabularyKey TaskOutlineLevel { get; private set; }
        public VocabularyKey TaskName { get; private set; }
        public VocabularyKey ParentTaskElementId { get; private set; }
        public VocabularyKey TaskNumberRecordId { get; private set; }
        public VocabularyKey TaskDisplaySequence { get; private set; }
        public VocabularyKey TaskId { get; private set; }
        public VocabularyKey TaskTimeType { get; private set; }
        public VocabularyKey TaskStatus { get; private set; }
        public VocabularyKey TaskOwningCompany { get; private set; }
        public VocabularyKey TaskSubject { get; private set; }
    }
}