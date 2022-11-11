using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimensionAliasEntityVocabulary : SimpleVocabulary
    {
        public DimensionAliasEntityVocabulary()
        {
            VocabularyName = "DimensionAliasEntity";
            KeyPrefix = "commonDataModel.dimensionaliasentity";
            KeySeparator = ".";
            Grouping = "/DimensionAliasEntity";

            AddGroup("DimensionAliasEntity Details", group =>
            {
                AliasType = group.Add(new VocabularyKey(nameof(AliasType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttribute = group.Add(new VocabularyKey(nameof(DimensionAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttributeValueCombination = group.Add(new VocabularyKey(nameof(DimensionAttributeValueCombination), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserGroupInfo = group.Add(new VocabularyKey(nameof(UserGroupInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserInfo = group.Add(new VocabularyKey(nameof(UserInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttributeName = group.Add(new VocabularyKey(nameof(DimensionAttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttributeValueCombinationDisplayValue = group.Add(new VocabularyKey(nameof(DimensionAttributeValueCombinationDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttributeValueCombinationAccountStructure = group.Add(new VocabularyKey(nameof(DimensionAttributeValueCombinationAccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AliasType { get; private set; }
        public VocabularyKey DimensionAttribute { get; private set; }
        public VocabularyKey DimensionAttributeValueCombination { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey UserGroupInfo { get; private set; }
        public VocabularyKey UserInfo { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey DimensionAttributeName { get; private set; }
        public VocabularyKey DimensionAttributeValueCombinationDisplayValue { get; private set; }
        public VocabularyKey DimensionAttributeValueCombinationAccountStructure { get; private set; }


    }
}