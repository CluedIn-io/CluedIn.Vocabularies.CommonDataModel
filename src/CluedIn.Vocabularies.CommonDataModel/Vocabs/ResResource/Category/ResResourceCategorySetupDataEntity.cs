using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ResResourceCategorySetupDataEntityVocabulary : SimpleVocabulary
    {
        public ResResourceCategorySetupDataEntityVocabulary()
        {
            VocabularyName = "Common Data Model ResResourceCategorySetupDataEntity";
            KeyPrefix = "commonDataModel.resresourcecategorysetupdataentity";
            KeySeparator = ".";
            Grouping = "/ResResourceCategorySetupDataEntity";

            AddGroup("Common Data Model ResResourceCategorySetupDataEntity Details", group =>
            {
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCategory = group.Add(new VocabularyKey(nameof(ResourceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoleId = group.Add(new VocabularyKey(nameof(RoleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceName = group.Add(new VocabularyKey(nameof(ResourceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCompanyId = group.Add(new VocabularyKey(nameof(ResourceCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Resource { get; private set; }
        public VocabularyKey ResourceCategory { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey RoleId { get; private set; }
        public VocabularyKey ResourceName { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey ResourceCompanyId { get; private set; }


    }
}