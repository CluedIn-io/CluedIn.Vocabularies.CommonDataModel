using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSContainerGroupEntityVocabulary : SimpleVocabulary
    {
        public WHSContainerGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSContainerGroupEntity";
            KeyPrefix = "commonDataModel.whscontainergroupentity";
            KeySeparator = ".";
            Grouping = "/WHSContainerGroupEntity";

            AddGroup("Common Data Model WHSContainerGroupEntity Details", group =>
            {
                ContainerGroupDescription = group.Add(new VocabularyKey(nameof(ContainerGroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerGroupId = group.Add(new VocabularyKey(nameof(ContainerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ContainerGroupDescription { get; private set; }
        public VocabularyKey ContainerGroupId { get; private set; }


    }
}