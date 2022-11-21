using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerAttributeValueEntityVocabulary : SimpleVocabulary
    {
        public CustomerAttributeValueEntityVocabulary()
        {
            VocabularyName = "Customer Attribute Value Entity";
            KeyPrefix = "commonDataModel.customerattributevalueentity";
            KeySeparator = ".";
            Grouping = "/CustomerAttributeValueEntity";

            AddGroup("CustomerAttributeValueEntity Details", group =>
            {
                InstanceRelationType = group.Add(new VocabularyKey(nameof(InstanceRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerDataAreaId = group.Add(new VocabularyKey(nameof(CustomerDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeTypeName = group.Add(new VocabularyKey(nameof(AttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeName = group.Add(new VocabularyKey(nameof(AttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BooleanValue = group.Add(new VocabularyKey(nameof(BooleanValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateTimeValue = group.Add(new VocabularyKey(nameof(DateTimeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DecimalValue = group.Add(new VocabularyKey(nameof(DecimalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntValue = group.Add(new VocabularyKey(nameof(IntValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TextValue = group.Add(new VocabularyKey(nameof(TextValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey InstanceRelationType { get; private set; }
        public VocabularyKey CustomerDataAreaId { get; private set; }
        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey AttributeTypeName { get; private set; }
        public VocabularyKey AttributeName { get; private set; }
        public VocabularyKey BooleanValue { get; private set; }
        public VocabularyKey DateTimeValue { get; private set; }
        public VocabularyKey DecimalValue { get; private set; }
        public VocabularyKey IntValue { get; private set; }
        public VocabularyKey TextValue { get; private set; }
    }
}