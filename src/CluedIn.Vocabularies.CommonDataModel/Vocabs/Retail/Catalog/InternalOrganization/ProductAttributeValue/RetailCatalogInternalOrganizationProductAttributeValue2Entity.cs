using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCatalogInternalOrganizationProductAttributeValue2EntityVocabulary : SimpleVocabulary
    {
        public RetailCatalogInternalOrganizationProductAttributeValue2EntityVocabulary()
        {
            VocabularyName = "RetailCatalogInternalOrganizationProductAttributeValue2Entity";
            KeyPrefix = "commonDataModel.retailcataloginternalorganizationproductattributevalue2entity";
            KeySeparator = ".";
            Grouping = "/RetailCatalogInternalOrganizationProductAttributeValue2Entity";

            AddGroup("RetailCatalogInternalOrganizationProductAttributeValue2Entity Details", group =>
            {
                CatalogNumber = group.Add(new VocabularyKey(nameof(CatalogNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalOrganizationPartyNumber = group.Add(new VocabularyKey(nameof(InternalOrganizationPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayProductNumber = group.Add(new VocabularyKey(nameof(DisplayProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeTypeName = group.Add(new VocabularyKey(nameof(AttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeName = group.Add(new VocabularyKey(nameof(AttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TextValue = group.Add(new VocabularyKey(nameof(TextValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyValue = group.Add(new VocabularyKey(nameof(CurrencyValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateTimeValue = group.Add(new VocabularyKey(nameof(DateTimeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DecimalValue = group.Add(new VocabularyKey(nameof(DecimalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DecimalUnitOfMeasureSymbol = group.Add(new VocabularyKey(nameof(DecimalUnitOfMeasureSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegerValue = group.Add(new VocabularyKey(nameof(IntegerValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegerUnitOfMeasureSymbol = group.Add(new VocabularyKey(nameof(IntegerUnitOfMeasureSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BooleanValue = group.Add(new VocabularyKey(nameof(BooleanValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CatalogNumber { get; private set; }
        public VocabularyKey InternalOrganizationPartyNumber { get; private set; }
        public VocabularyKey DisplayProductNumber { get; private set; }
        public VocabularyKey AttributeTypeName { get; private set; }
        public VocabularyKey AttributeName { get; private set; }
        public VocabularyKey TextValue { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CurrencyValue { get; private set; }
        public VocabularyKey DateTimeValue { get; private set; }
        public VocabularyKey DecimalValue { get; private set; }
        public VocabularyKey DecimalUnitOfMeasureSymbol { get; private set; }
        public VocabularyKey IntegerValue { get; private set; }
        public VocabularyKey IntegerUnitOfMeasureSymbol { get; private set; }
        public VocabularyKey BooleanValue { get; private set; }


    }
}