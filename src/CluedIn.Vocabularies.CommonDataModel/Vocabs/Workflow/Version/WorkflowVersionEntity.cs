using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowVersionEntityVocabulary : SimpleVocabulary
    {
        public WorkflowVersionEntityVocabulary()
        {
            VocabularyName = "WorkflowVersionEntity";
            KeyPrefix = "commonDataModel.workflowversionentity";
            KeySeparator = ".";
            Grouping = "/WorkflowVersionEntity";

            AddGroup("WorkflowVersionEntity Details", group =>
            {
                ActivationConditionId = group.Add(new VocabularyKey(nameof(ActivationConditionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivationConditionType = group.Add(new VocabularyKey(nameof(ActivationConditionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowId = group.Add(new VocabularyKey(nameof(WorkflowId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Owner = group.Add(new VocabularyKey(nameof(Owner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Valid = group.Add(new VocabularyKey(nameof(Valid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionIdBuild = group.Add(new VocabularyKey(nameof(VersionIdBuild), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionIdMajor = group.Add(new VocabularyKey(nameof(VersionIdMajor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionIdMinor = group.Add(new VocabularyKey(nameof(VersionIdMinor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionIdRevision = group.Add(new VocabularyKey(nameof(VersionIdRevision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowTable = group.Add(new VocabularyKey(nameof(WorkflowTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailTemplateId = group.Add(new VocabularyKey(nameof(EmailTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociationType = group.Add(new VocabularyKey(nameof(AssociationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataArea = group.Add(new VocabularyKey(nameof(DataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentTableName = group.Add(new VocabularyKey(nameof(DocumentTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Module = group.Add(new VocabularyKey(nameof(Module), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowNumber = group.Add(new VocabularyKey(nameof(WorkflowNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowTypeName = group.Add(new VocabularyKey(nameof(WorkflowTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionId = group.Add(new VocabularyKey(nameof(VersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActivationConditionId { get; private set; }
        public VocabularyKey ActivationConditionType { get; private set; }
        public VocabularyKey WorkflowId { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey Owner { get; private set; }
        public VocabularyKey Valid { get; private set; }
        public VocabularyKey VersionIdBuild { get; private set; }
        public VocabularyKey VersionIdMajor { get; private set; }
        public VocabularyKey VersionIdMinor { get; private set; }
        public VocabularyKey VersionIdRevision { get; private set; }
        public VocabularyKey WorkflowTable { get; private set; }
        public VocabularyKey EmailTemplateId { get; private set; }
        public VocabularyKey AssociationType { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey DataArea { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey DocumentTableName { get; private set; }
        public VocabularyKey Module { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey WorkflowNumber { get; private set; }
        public VocabularyKey WorkflowTypeName { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey VersionId { get; private set; }


    }
}