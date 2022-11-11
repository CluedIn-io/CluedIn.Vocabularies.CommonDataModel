using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ResourceRoleCharacteristicsEntityVocabulary : SimpleVocabulary
    {
        public ResourceRoleCharacteristicsEntityVocabulary()
        {
            VocabularyName = "ResourceRoleCharacteristicsEntity";
            KeyPrefix = "commonDataModel.resourcerolecharacteristicsentity";
            KeySeparator = ".";
            Grouping = "/ResourceRoleCharacteristicsEntity";

            AddGroup("ResourceRoleCharacteristicsEntity Details", group =>
            {
                CharacteristicId = group.Add(new VocabularyKey(nameof(CharacteristicId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CharacteristicRequirement = group.Add(new VocabularyKey(nameof(CharacteristicRequirement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CharacteristicSet = group.Add(new VocabularyKey(nameof(CharacteristicSet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoleId = group.Add(new VocabularyKey(nameof(RoleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Characteristic = group.Add(new VocabularyKey(nameof(Characteristic), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReqEntityType = group.Add(new VocabularyKey(nameof(ReqEntityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CharacteristicId { get; private set; }
        public VocabularyKey CharacteristicRequirement { get; private set; }
        public VocabularyKey CharacteristicSet { get; private set; }
        public VocabularyKey RoleId { get; private set; }
        public VocabularyKey Characteristic { get; private set; }
        public VocabularyKey ReqEntityType { get; private set; }


    }
}