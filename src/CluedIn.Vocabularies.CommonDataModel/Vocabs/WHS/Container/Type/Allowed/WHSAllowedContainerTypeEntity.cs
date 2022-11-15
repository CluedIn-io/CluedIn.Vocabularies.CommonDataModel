using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSAllowedContainerTypeEntityVocabulary : SimpleVocabulary
    {
        public WHSAllowedContainerTypeEntityVocabulary()
        {
            VocabularyName = "WHS Allowed Container Type Entity";
            KeyPrefix = "commonDataModel.whsallowedcontainertypeentity";
            KeySeparator = ".";
            Grouping = "/WHSAllowedContainerTypeEntity";

            AddGroup("WHSAllowedContainerTypeEntity Details", group =>
            {
                AllowedContainerTypeId = group.Add(new VocabularyKey(nameof(AllowedContainerTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowedContainerTypeGroupName = group.Add(new VocabularyKey(nameof(AllowedContainerTypeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AllowedContainerTypeId { get; private set; }
        public VocabularyKey AllowedContainerTypeGroupName { get; private set; }
    }
}