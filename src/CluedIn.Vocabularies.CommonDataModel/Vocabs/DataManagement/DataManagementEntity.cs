using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DataManagementEntityVocabulary : SimpleVocabulary
    {
        public DataManagementEntityVocabulary()
        {
            VocabularyName = "Common Data Model DataManagementEntity";
            KeyPrefix = "commonDataModel.datamanagemententity";
            KeySeparator = ".";
            Grouping = "/DataManagementEntity";

            AddGroup("Common Data Model DataManagementEntity Details", group =>
            {
                EntityName = group.Add(new VocabularyKey(nameof(EntityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StagingTableName = group.Add(new VocabularyKey(nameof(StagingTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TargetName = group.Add(new VocabularyKey(nameof(TargetName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Modules = group.Add(new VocabularyKey(nameof(Modules), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tags = group.Add(new VocabularyKey(nameof(Tags), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsShared = group.Add(new VocabularyKey(nameof(IsShared), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionCodes = group.Add(new VocabularyKey(nameof(CountryRegionCodes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfigurationKeyName = group.Add(new VocabularyKey(nameof(ConfigurationKeyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityKey = group.Add(new VocabularyKey(nameof(EntityKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecVersionValue = group.Add(new VocabularyKey(nameof(RecVersionValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChangeTrackingType = group.Add(new VocabularyKey(nameof(ChangeTrackingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey EntityName { get; private set; }
        public VocabularyKey StagingTableName { get; private set; }
        public VocabularyKey TargetName { get; private set; }
        public VocabularyKey Category { get; private set; }
        public VocabularyKey Modules { get; private set; }
        public VocabularyKey Tags { get; private set; }
        public VocabularyKey IsShared { get; private set; }
        public VocabularyKey CountryRegionCodes { get; private set; }
        public VocabularyKey ConfigurationKeyName { get; private set; }
        public VocabularyKey EntityKey { get; private set; }
        public VocabularyKey RecVersionValue { get; private set; }
        public VocabularyKey ChangeTrackingType { get; private set; }


    }
}