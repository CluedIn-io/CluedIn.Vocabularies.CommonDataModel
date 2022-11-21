using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSAllowedContainerTypeGroupEntityVocabulary : SimpleVocabulary
    {
        public WHSAllowedContainerTypeGroupEntityVocabulary()
        {
            VocabularyName = "WHS Allowed Container Type Group Entity";
            KeyPrefix = "commonDataModel.whsallowedcontainertypegroupentity";
            KeySeparator = ".";
            Grouping = "/WHSAllowedContainerTypeGroupEntity";

            AddGroup("WHSAllowedContainerTypeGroupEntity Details", group =>
            {
                AllowedContainerTypeGroupName = group.Add(new VocabularyKey(nameof(AllowedContainerTypeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreUnspecifiedContainerTypesAllowed = group.Add(new VocabularyKey(nameof(AreUnspecifiedContainerTypesAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AllowedContainerTypeGroupName { get; private set; }
        public VocabularyKey AreUnspecifiedContainerTypesAllowed { get; private set; }
    }
}