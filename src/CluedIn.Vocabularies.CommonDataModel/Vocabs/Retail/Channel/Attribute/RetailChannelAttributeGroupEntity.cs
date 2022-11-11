using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailChannelAttributeGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailChannelAttributeGroupEntityVocabulary()
        {
            VocabularyName = "RetailChannelAttributeGroupEntity";
            KeyPrefix = "commonDataModel.retailchannelattributegroupentity";
            KeySeparator = ".";
            Grouping = "/RetailChannelAttributeGroupEntity";

            AddGroup("RetailChannelAttributeGroupEntity Details", group =>
            {
                AttributeGroup = group.Add(new VocabularyKey(nameof(AttributeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeModifier = group.Add(new VocabularyKey(nameof(AttributeModifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeGroupName = group.Add(new VocabularyKey(nameof(AttributeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMOperatingUnitNumber = group.Add(new VocabularyKey(nameof(OMOperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMOperatingUnitID = group.Add(new VocabularyKey(nameof(OMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeAppliesToModifier = group.Add(new VocabularyKey(nameof(AttributeAppliesToModifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AttributeGroup { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey AttributeModifier { get; private set; }
        public VocabularyKey AttributeGroupName { get; private set; }
        public VocabularyKey OMOperatingUnitNumber { get; private set; }
        public VocabularyKey OMOperatingUnitID { get; private set; }
        public VocabularyKey AttributeAppliesToModifier { get; private set; }


    }
}