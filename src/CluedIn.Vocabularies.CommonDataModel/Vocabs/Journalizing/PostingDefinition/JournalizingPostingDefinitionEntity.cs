using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JournalizingPostingDefinitionEntityVocabulary : SimpleVocabulary
    {
        public JournalizingPostingDefinitionEntityVocabulary()
        {
            VocabularyName = "Common Data Model JournalizingPostingDefinitionEntity";
            KeyPrefix = "commonDataModel.journalizingpostingdefinitionentity";
            KeySeparator = ".";
            Grouping = "/JournalizingPostingDefinitionEntity";

            AddGroup("Common Data Model JournalizingPostingDefinitionEntity Details", group =>
            {
                PostingDefinition = group.Add(new VocabularyKey(nameof(PostingDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionDescription = group.Add(new VocabularyKey(nameof(VersionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingDefinitionId = group.Add(new VocabularyKey(nameof(PostingDefinitionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Module = group.Add(new VocabularyKey(nameof(Module), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalizingDefinitionVersion = group.Add(new VocabularyKey(nameof(JournalizingDefinitionVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PostingDefinition { get; private set; }
        public VocabularyKey VersionDescription { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey PostingDefinitionId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Module { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey JournalizingDefinitionVersion { get; private set; }


    }
}