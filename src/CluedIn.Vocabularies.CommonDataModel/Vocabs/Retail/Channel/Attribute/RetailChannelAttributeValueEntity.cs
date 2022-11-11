using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailChannelAttributeValueEntityVocabulary : SimpleVocabulary
    {
        public RetailChannelAttributeValueEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailChannelAttributeValueEntity";
            KeyPrefix = "commonDataModel.retailchannelattributevalueentity";
            KeySeparator = ".";
            Grouping = "/RetailChannelAttributeValueEntity";

            AddGroup("Common Data Model RetailChannelAttributeValueEntity Details", group =>
            {
                RetailChannelId = group.Add(new VocabularyKey(nameof(RetailChannelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeGroupName = group.Add(new VocabularyKey(nameof(AttributeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeName = group.Add(new VocabularyKey(nameof(AttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeTypeName = group.Add(new VocabularyKey(nameof(AttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TextValue = group.Add(new VocabularyKey(nameof(TextValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyValue = group.Add(new VocabularyKey(nameof(CurrencyValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateTimeValue = group.Add(new VocabularyKey(nameof(DateTimeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DecimalValue = group.Add(new VocabularyKey(nameof(DecimalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegerValue = group.Add(new VocabularyKey(nameof(IntegerValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BooleanValue = group.Add(new VocabularyKey(nameof(BooleanValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RetailChannelId { get; private set; }
        public VocabularyKey AttributeGroupName { get; private set; }
        public VocabularyKey AttributeName { get; private set; }
        public VocabularyKey AttributeTypeName { get; private set; }
        public VocabularyKey TextValue { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CurrencyValue { get; private set; }
        public VocabularyKey DateTimeValue { get; private set; }
        public VocabularyKey DecimalValue { get; private set; }
        public VocabularyKey IntegerValue { get; private set; }
        public VocabularyKey BooleanValue { get; private set; }


    }
}