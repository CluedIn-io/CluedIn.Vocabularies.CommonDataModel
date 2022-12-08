using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.FoundationCommon
{
    public class PriceListVocabulary : SimpleVocabulary
    {
        public PriceListVocabulary()
        {
            VocabularyName = "Price List";
            KeyPrefix = "commonDataModel.pricelist.foundationcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PriceList;

            AddGroup("PriceList Details for FoundationCommon", group =>
            {
			    PriceLevelId = group.Add(new VocabularyKey(nameof(PriceLevelId), "Price List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BeginDate = group.Add(new VocabularyKey(nameof(BeginDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FreightTermsCode = group.Add(new VocabularyKey(nameof(FreightTermsCode), "Freight Terms", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PaymentMethodCode = group.Add(new VocabularyKey(nameof(PaymentMethodCode), "Payment Method ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ShippingMethodCode = group.Add(new VocabularyKey(nameof(ShippingMethodCode), "Shipping Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="PriceLevelId"/> to Vocab 'PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="PriceLevelId"/> to Vocab 'PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="UoMId"/> to Vocab 'Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="UoMScheduleId"/> to Vocab 'UnitGroup.cdm.json/UnitGroup' with Property 'UoMScheduleId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="TimeUnit"/> to Vocab 'Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="UoMId"/> to Vocab 'Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="UoMScheduleId"/> to Vocab 'UnitGroup.cdm.json/UnitGroup' with Property 'UoMScheduleId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="PriceLevelId"/> from Vocab 'Account.cdm.json/Account' with Property 'DefaultPriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'DefaultPriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'PriceListItem.cdm.json/PriceListItem' with Property 'PriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'Product.cdm.json/Product' with Property 'PriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/Account.cdm.json/Account' with Property 'DefaultPriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/Campaign.cdm.json/Campaign' with Property 'PriceListId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/Contact.cdm.json/Contact' with Property 'DefaultPriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/Account.cdm.json/Account' with Property 'DefaultPriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/Contact.cdm.json/Contact' with Property 'DefaultPriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/Opportunity.cdm.json/Opportunity' with Property 'PriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/Product.cdm.json/Product' with Property 'PriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/accelerators/nonProfit/nonProfitForSales/Campaign.cdm.json/Campaign' with Property 'PriceListId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/accelerators/nonProfit/nonProfitForSales/Opportunity.cdm.json/Opportunity' with Property 'PriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/accelerators/nonProfit/nonProfitIati/Campaign.cdm.json/Campaign' with Property 'PriceListId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/accelerators/nonProfit/nonProfitIati/Opportunity.cdm.json/Opportunity' with Property 'PriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/sales/Invoice.cdm.json/Invoice' with Property 'PriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/sales/Opportunity.cdm.json/Opportunity' with Property 'PriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/sales/Order.cdm.json/Order' with Property 'PriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/sales/PriceListItem.cdm.json/PriceListItem' with Property 'PriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/sales/Quote.cdm.json/Quote' with Property 'PriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'DefaultPriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/solutions/marketing/eventManagement/Account.cdm.json/Account' with Property 'DefaultPriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/solutions/portals/Account.cdm.json/Account' with Property 'DefaultPriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/solutions/portals/Contact.cdm.json/Contact' with Property 'DefaultPriceLevelId'
            ///Property <see cref="PriceLevelId"/> from Vocab 'crmCommon/solutions/portals/Opportunity.cdm.json/Opportunity' with Property 'PriceLevelId'
            #endregion
        }

        public VocabularyKey PriceLevelId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey BeginDate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey FreightTermsCode { get; private set; }
        public VocabularyKey PaymentMethodCode { get; private set; }
        public VocabularyKey ShippingMethodCode { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}