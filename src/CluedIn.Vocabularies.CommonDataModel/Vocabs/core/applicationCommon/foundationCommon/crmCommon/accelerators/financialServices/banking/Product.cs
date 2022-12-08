using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Banking
{
    public class ProductVocabulary : SimpleVocabulary
    {
        public ProductVocabulary()
        {
            VocabularyName = "Product";
            KeyPrefix = "commonDataModel.product.banking";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Product;

            AddGroup("Product Details for Banking", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Entity Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="BranchId"/> to Vocab 'Branch.cdm.json/Branch' with Property 'BranchId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="LimitId"/> to Vocab 'Limit.cdm.json/Limit' with Property 'LimitId'
            ///Property <see cref="ProductFamilyId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/foundationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="DefaultUoMId"/> to Vocab '/core/applicationCommon/foundationCommon/Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="DefaultUoMScheduleId"/> to Vocab '/core/applicationCommon/foundationCommon/UnitGroup.cdm.json/UnitGroup' with Property 'UoMScheduleId'
            ///Property <see cref="ParentProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="PriceLevelId"/> to Vocab '/core/applicationCommon/foundationCommon/PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="ParentProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="AssociatedProduct"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="SubstitutedProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="FinancialProductId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'DefaultChargeAccountId'
            ///Property <see cref="ProductId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'InterestedProductId'
            ///Property <see cref="FinancialProductId"/> from Vocab 'Collateral.cdm.json/Collateral' with Property 'FinancialProductId'
            ///Property <see cref="ProductId"/> from Vocab 'FinancialProduct.cdm.json/FinancialProduct' with Property 'ProductFamilyId'
            ///Property <see cref="ProductId"/> from Vocab 'FinancialProduct.cdm.json/FinancialProduct' with Property 'ProductId'
            ///Property <see cref="FinancialProductId"/> from Vocab 'Syndicates.cdm.json/Syndicates' with Property 'LoanId'
            ///Property <see cref="ProductId"/> from Vocab 'Limit.cdm.json/Limit' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab 'RequestedFacility.cdm.json/RequestedFacility' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab 'Opportunity.cdm.json/Opportunity' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab 'Product.cdm.json/Product' with Property 'ParentProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/PriceListItem.cdm.json/PriceListItem' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/Product.cdm.json/Product' with Property 'ParentProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/ProductAssociation.cdm.json/ProductAssociation' with Property 'AssociatedProduct'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/ProductAssociation.cdm.json/ProductAssociation' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/ProductRelationship.cdm.json/ProductRelationship' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/ProductRelationship.cdm.json/ProductRelationship' with Property 'SubstitutedProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/Property.cdm.json/Property' with Property 'RegardingObjectId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/PropertyAssociation.cdm.json/PropertyAssociation' with Property 'RegardingObjectId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/CompetitorProduct.cdm.json/CompetitorProduct' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/InvoiceProduct.cdm.json/InvoiceProduct' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/LeadProduct.cdm.json/LeadProduct' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityProduct.cdm.json/OpportunityProduct' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderProduct.cdm.json/OrderProduct' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/PriceListItem.cdm.json/PriceListItem' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/ProductSalesLiterature.cdm.json/ProductSalesLiterature' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteProduct.cdm.json/QuoteProduct' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/Case.cdm.json/Case' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/ContractLine.cdm.json/ContractLine' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/EntitlementProduct.cdm.json/EntitlementProduct' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Case.cdm.json/Case' with Property 'ProductId'
            ///Property <see cref="ProductId"/> from Vocab '/core/applicationCommon/foundationCommon/productInsights/Signal.cdm.json/Signal' with Property 'ProductId'
            #endregion
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}