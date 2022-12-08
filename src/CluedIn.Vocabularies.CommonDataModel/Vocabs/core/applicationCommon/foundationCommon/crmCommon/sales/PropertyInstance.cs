using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Sales
{
    public class PropertyInstanceVocabulary : SimpleVocabulary
    {
        public PropertyInstanceVocabulary()
        {
            VocabularyName = "Property Instance";
            KeyPrefix = "commonDataModel.propertyinstance.sales";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PropertyInstance;

            AddGroup("PropertyInstance Details for Sales", group =>
            {
			                 
            });
            
            #region Incoming Relationships
            ///Property <see cref="RegardingObjectId"/> to Vocab 'InvoiceProduct.cdm.json/InvoiceProduct' with Property 'InvoiceDetailId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'OpportunityProduct.cdm.json/OpportunityProduct' with Property 'OpportunityProductId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="DynamicPropertyInstanceid"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="DynamicPropertyInstanceid"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="DynamicPropertyId"/> to Vocab '/core/applicationCommon/foundationCommon/Property.cdm.json/Property' with Property 'DynamicPropertyId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        
    }
}