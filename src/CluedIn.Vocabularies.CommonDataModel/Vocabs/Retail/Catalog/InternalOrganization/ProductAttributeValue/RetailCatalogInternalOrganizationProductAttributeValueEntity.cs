using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCatalogInternalOrganizationProductAttributeValueEntityVocabulary : SimpleVocabulary
    {
        public RetailCatalogInternalOrganizationProductAttributeValueEntityVocabulary()
        {
            VocabularyName = "RetailCatalogInternalOrganizationProductAttributeValueEntity";
            KeyPrefix = "commonDataModel.retailcataloginternalorganizationproductattributevalueentity";
            KeySeparator = ".";
            Grouping = "/RetailCatalogInternalOrganizationProductAttributeValueEntity";

            AddGroup("RetailCatalogInternalOrganizationProductAttributeValueEntity Details", group =>
            {
                CatalogNumber = group.Add(new VocabularyKey(nameof(CatalogNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayProductNumber = group.Add(new VocabularyKey(nameof(DisplayProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                InternalOrganizationRecId = group.Add(new VocabularyKey(nameof(InternalOrganizationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EcoResAttributeRecId = group.Add(new VocabularyKey(nameof(EcoResAttributeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataType = group.Add(new VocabularyKey(nameof(DataType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CatalogNumber { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey DisplayProductNumber { get; private set; }
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
        public VocabularyKey InternalOrganizationRecId { get; private set; }
        public VocabularyKey EcoResAttributeRecId { get; private set; }
        public VocabularyKey DataType { get; private set; }


    }
}