using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInternalOrganizationProductAttributeMetadataEntityVocabulary : SimpleVocabulary
    {
        public RetailInternalOrganizationProductAttributeMetadataEntityVocabulary()
        {
            VocabularyName = "Retail Internal Organization Product Attribute Metadata Entity";
            KeyPrefix = "commonDataModel.retailinternalorganizationproductattributemetadataentity";
            KeySeparator = ".";
            Grouping = "/RetailInternalOrganizationProductAttributeMetadataEntity";

            AddGroup("RetailInternalOrganizationProductAttributeMetadataEntity Details", group =>
            {
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationName = group.Add(new VocabularyKey(nameof(OrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeName = group.Add(new VocabularyKey(nameof(AttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeTypeName = group.Add(new VocabularyKey(nameof(AttributeTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttributeRelationType = group.Add(new VocabularyKey(nameof(AttributeRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRequired = group.Add(new VocabularyKey(nameof(IsRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeyName = group.Add(new VocabularyKey(nameof(KeyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                XmlMetadata = group.Add(new VocabularyKey(nameof(XmlMetadata), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                XmlMetadataVersionNumber = group.Add(new VocabularyKey(nameof(XmlMetadataVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey OrganizationName { get; private set; }
        public VocabularyKey AttributeName { get; private set; }
        public VocabularyKey AttributeTypeName { get; private set; }
        public VocabularyKey AttributeRelationType { get; private set; }
        public VocabularyKey IsRequired { get; private set; }
        public VocabularyKey KeyName { get; private set; }
        public VocabularyKey XmlMetadata { get; private set; }
        public VocabularyKey XmlMetadataVersionNumber { get; private set; }
    }
}