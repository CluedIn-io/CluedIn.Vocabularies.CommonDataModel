using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DataManagementDefinitionGroupEntityVocabulary : SimpleVocabulary
    {
        public DataManagementDefinitionGroupEntityVocabulary()
        {
            VocabularyName = "Data Management Definition Group Entity";
            KeyPrefix = "commonDataModel.datamanagementdefinitiongroupentity";
            KeySeparator = ".";
            Grouping = "/DataManagementDefinitionGroupEntity";

            AddGroup("DataManagementDefinitionGroupEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationType = group.Add(new VocabularyKey(nameof(OperationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategory = group.Add(new VocabularyKey(nameof(ProjectCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GenerateDataPackage = group.Add(new VocabularyKey(nameof(GenerateDataPackage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TruncateEntityData = group.Add(new VocabularyKey(nameof(TruncateEntityData), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey OperationType { get; private set; }
        public VocabularyKey ProjectCategory { get; private set; }
        public VocabularyKey GenerateDataPackage { get; private set; }
        public VocabularyKey TruncateEntityData { get; private set; }
    }
}