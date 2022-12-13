using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ProductAssociationVocabulary : SimpleVocabulary
    {
        public ProductAssociationVocabulary()
        {
            VocabularyName = "Product Association";
            KeyPrefix = "commonDataModel.productassociation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ProductAssociation;

            AddGroup("ProductAssociation Details for FoundationCommon", group =>
            {
                ProductAssociationId = group.Add(new VocabularyKey(nameof(ProductAssociationId), "Product Association ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                ProductIsRequired = group.Add(new VocabularyKey(nameof(ProductIsRequired), "Required", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PropertyCustomizationStatus = group.Add(new VocabularyKey(nameof(PropertyCustomizationStatus), "Property Customization", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="AssociatedProduct"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="UoMId"/> to Vocab 'Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="ProductAssociationId"/> from Vocab 'Property.cdm.json/Property' with Property 'RegardingObjectId'
            ///Property <see cref="ProductAssociationId"/> from Vocab 'PropertyAssociation.cdm.json/PropertyAssociation' with Property 'RegardingObjectId'
            ///Property <see cref="ProductAssociationId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/InvoiceProduct.cdm.json/InvoiceProduct' with Property 'ProductAssociationId'
            ///Property <see cref="ProductAssociationId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/OpportunityProduct.cdm.json/OpportunityProduct' with Property 'ProductAssociationId'
            ///Property <see cref="ProductAssociationId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/OrderProduct.cdm.json/OrderProduct' with Property 'ProductAssociationId'
            ///Property <see cref="ProductAssociationId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/QuoteProduct.cdm.json/QuoteProduct' with Property 'ProductAssociationId'
            ///Property <see cref="ProductAssociationId"/> from Vocab 'crmCommon/sales/InvoiceProduct.cdm.json/InvoiceProduct' with Property 'ProductAssociationId'
            ///Property <see cref="ProductAssociationId"/> from Vocab 'crmCommon/sales/OpportunityProduct.cdm.json/OpportunityProduct' with Property 'ProductAssociationId'
            ///Property <see cref="ProductAssociationId"/> from Vocab 'crmCommon/sales/OrderProduct.cdm.json/OrderProduct' with Property 'ProductAssociationId'
            ///Property <see cref="ProductAssociationId"/> from Vocab 'crmCommon/sales/QuoteProduct.cdm.json/QuoteProduct' with Property 'ProductAssociationId'
            #endregion
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey ProductAssociationId { get; private set; }
        public VocabularyKey ProductIsRequired { get; private set; }
        public VocabularyKey PropertyCustomizationStatus { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}