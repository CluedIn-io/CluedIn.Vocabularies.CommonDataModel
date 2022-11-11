using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSLoadingDockManagementProfileEntityVocabulary : SimpleVocabulary
    {
        public WHSLoadingDockManagementProfileEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSLoadingDockManagementProfileEntity";
            KeyPrefix = "commonDataModel.whsloadingdockmanagementprofileentity";
            KeySeparator = ".";
            Grouping = "/WHSLoadingDockManagementProfileEntity";

            AddGroup("Common Data Model WHSLoadingDockManagementProfileEntity Details", group =>
            {
                WillWaveAllocateToEmptyDockLocationsOnly = group.Add(new VocabularyKey(nameof(WillWaveAllocateToEmptyDockLocationsOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfileDescription = group.Add(new VocabularyKey(nameof(ProfileDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DockLocationUniqueDocumentIndentificationType = group.Add(new VocabularyKey(nameof(DockLocationUniqueDocumentIndentificationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfileId = group.Add(new VocabularyKey(nameof(ProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WillWaveAllocateToEmptyDockLocationsOnly { get; private set; }
        public VocabularyKey ProfileDescription { get; private set; }
        public VocabularyKey DockLocationUniqueDocumentIndentificationType { get; private set; }
        public VocabularyKey ProfileId { get; private set; }


    }
}