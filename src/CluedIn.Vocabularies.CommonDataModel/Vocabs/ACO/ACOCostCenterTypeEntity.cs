using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ACOCostCenterTypeEntityVocabulary : SimpleVocabulary
    {
        public ACOCostCenterTypeEntityVocabulary()
        {
            VocabularyName = "ACOCostCenterTypeEntity";
            KeyPrefix = "commonDataModel.acocostcentertypeentity";
            KeySeparator = ".";
            Grouping = "/ACOCostCenterTypeEntity";

            AddGroup("ACOCostCenterTypeEntity Details", group =>
            {
                CostType = group.Add(new VocabularyKey(nameof(CostType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttributeValue = group.Add(new VocabularyKey(nameof(DimensionAttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityInstance = group.Add(new VocabularyKey(nameof(EntityInstance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CostType { get; private set; }
        public VocabularyKey DimensionAttributeValue { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey EntityInstance { get; private set; }
        public VocabularyKey Key { get; private set; }


    }
}