using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimensionAttributeActivationEntityVocabulary : SimpleVocabulary
    {
        public DimensionAttributeActivationEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimensionAttributeActivationEntity";
            KeyPrefix = "commonDataModel.dimensionattributeactivationentity";
            KeySeparator = ".";
            Grouping = "/DimensionAttributeActivationEntity";

            AddGroup("Common Data Model DimensionAttributeActivationEntity Details", group =>
            {
                DoActivate = group.Add(new VocabularyKey(nameof(DoActivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoCopyValues = group.Add(new VocabularyKey(nameof(DoCopyValues), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DoActivate { get; private set; }
        public VocabularyKey DoCopyValues { get; private set; }


    }
}