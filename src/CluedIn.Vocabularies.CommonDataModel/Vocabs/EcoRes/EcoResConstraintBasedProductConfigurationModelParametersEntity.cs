using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResConstraintBasedProductConfigurationModelParametersEntityVocabulary : SimpleVocabulary
    {
        public EcoResConstraintBasedProductConfigurationModelParametersEntityVocabulary()
        {
            VocabularyName = "Eco Res Constraint Based Product Configuration Model Parameters Entity";
            KeyPrefix = "commonDataModel.ecoresconstraintbasedproductconfigurationmodelparametersentity";
            KeySeparator = ".";
            Grouping = "/EcoResConstraintBasedProductConfigurationModelParametersEntity";

            AddGroup("EcoResConstraintBasedProductConfigurationModelParametersEntity Details", group =>
            {
                SingletonKey = group.Add(new VocabularyKey(nameof(SingletonKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProductConfigurationId = group.Add(new VocabularyKey(nameof(DefaultProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProductConfigurationPriceModelCurrencyCode = group.Add(new VocabularyKey(nameof(DefaultProductConfigurationPriceModelCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfigurationDocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(ConfigurationDocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfigurationDocumentAttachmentTypeLegalEntityId = group.Add(new VocabularyKey(nameof(ConfigurationDocumentAttachmentTypeLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderLineProductLookupMethod = group.Add(new VocabularyKey(nameof(OrderLineProductLookupMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsConfigurationFormCachingConfigurationModels = group.Add(new VocabularyKey(nameof(IsConfigurationFormCachingConfigurationModels), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillOrderLineHavePriceBreakdownAttached = group.Add(new VocabularyKey(nameof(WillOrderLineHavePriceBreakdownAttached), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderLinePriceBreakdownDocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(OrderLinePriceBreakdownDocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderLinePriceBreakdownDocumentAttachmentTypeLegalEntityId = group.Add(new VocabularyKey(nameof(OrderLinePriceBreakdownDocumentAttachmentTypeLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SingletonKey { get; private set; }
        public VocabularyKey DefaultProductConfigurationId { get; private set; }
        public VocabularyKey DefaultProductConfigurationPriceModelCurrencyCode { get; private set; }
        public VocabularyKey ConfigurationDocumentAttachmentTypeCode { get; private set; }
        public VocabularyKey ConfigurationDocumentAttachmentTypeLegalEntityId { get; private set; }
        public VocabularyKey OrderLineProductLookupMethod { get; private set; }
        public VocabularyKey IsConfigurationFormCachingConfigurationModels { get; private set; }
        public VocabularyKey WillOrderLineHavePriceBreakdownAttached { get; private set; }
        public VocabularyKey OrderLinePriceBreakdownDocumentAttachmentTypeCode { get; private set; }
        public VocabularyKey OrderLinePriceBreakdownDocumentAttachmentTypeLegalEntityId { get; private set; }
    }
}