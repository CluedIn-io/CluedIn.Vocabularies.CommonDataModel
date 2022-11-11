using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductAttributeEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductAttributeEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductAttributeEntity";
            KeyPrefix = "commonDataModel.ecoresproductattributeentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductAttributeEntity";

            AddGroup("Common Data Model EcoResProductAttributeEntity Details", group =>
            {
                ProductAttributeTypeName = group.Add(new VocabularyKey(nameof(ProductAttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeName = group.Add(new VocabularyKey(nameof(AttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeDescription = group.Add(new VocabularyKey(nameof(AttributeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCurrencyCode = group.Add(new VocabularyKey(nameof(DefaultCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCurrencyValue = group.Add(new VocabularyKey(nameof(DefaultCurrencyValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBooleanValue = group.Add(new VocabularyKey(nameof(DefaultBooleanValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDateTimeValue = group.Add(new VocabularyKey(nameof(DefaultDateTimeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDecimalValue = group.Add(new VocabularyKey(nameof(DefaultDecimalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultIntegerValue = group.Add(new VocabularyKey(nameof(DefaultIntegerValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultTextValue = group.Add(new VocabularyKey(nameof(DefaultTextValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FriendlyAttributeName = group.Add(new VocabularyKey(nameof(FriendlyAttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeHelpText = group.Add(new VocabularyKey(nameof(AttributeHelpText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductAttributeTypeName { get; private set; }
        public VocabularyKey AttributeName { get; private set; }
        public VocabularyKey AttributeDescription { get; private set; }
        public VocabularyKey DefaultCurrencyCode { get; private set; }
        public VocabularyKey DefaultCurrencyValue { get; private set; }
        public VocabularyKey DefaultBooleanValue { get; private set; }
        public VocabularyKey DefaultDateTimeValue { get; private set; }
        public VocabularyKey DefaultDecimalValue { get; private set; }
        public VocabularyKey DefaultIntegerValue { get; private set; }
        public VocabularyKey DefaultTextValue { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey FriendlyAttributeName { get; private set; }
        public VocabularyKey AttributeHelpText { get; private set; }


    }
}