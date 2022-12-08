using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Sales
{
    public class PriceListItemVocabulary : SimpleVocabulary
    {
        public PriceListItemVocabulary()
        {
            VocabularyName = "Price List Item";
            KeyPrefix = "commonDataModel.pricelistitem.sales";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PriceListItem;

            AddGroup("PriceListItem Details for Sales", group =>
            {
			                 
            });
            
            #region Incoming Relationships
            ///Property <see cref="DiscountTypeId"/> to Vocab 'DiscountList.cdm.json/DiscountList' with Property 'DiscountTypeId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="PriceLevelId"/> to Vocab '/core/applicationCommon/foundationCommon/PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="ProductId"/> to Vocab '/core/applicationCommon/foundationCommon/Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="UoMId"/> to Vocab '/core/applicationCommon/foundationCommon/Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="UoMScheduleId"/> to Vocab '/core/applicationCommon/foundationCommon/UnitGroup.cdm.json/UnitGroup' with Property 'UoMScheduleId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        
    }
}