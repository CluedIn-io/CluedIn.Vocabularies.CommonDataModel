using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class QuoteLineAnalyticsBreakdownVocabulary : SimpleVocabulary
    {
        public QuoteLineAnalyticsBreakdownVocabulary()
        {
            VocabularyName = "Quote Line Analytics Breakdown";
            KeyPrefix = "commonDataModel.quotelineanalyticsbreakdown";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.QuoteLineAnalyticsBreakdown;

            AddGroup("QuoteLineAnalyticsBreakdown Details for ProjectServiceAutomation", group =>
            {
			    QuoteLineAnalyticsBreakdownId = group.Add(new VocabularyKey(nameof(QuoteLineAnalyticsBreakdownId), "Quote Line Analytics Breakdown", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDateTime = group.Add(new VocabularyKey(nameof(EndDateTime), "End Date Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Price = group.Add(new VocabularyKey(nameof(Price), "Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PriceBase = group.Add(new VocabularyKey(nameof(PriceBase), "Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), "Start Date Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), "Transaction Class", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionTypeCode = group.Add(new VocabularyKey(nameof(TransactionTypeCode), "Transaction Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ResourceCategory"/> to Vocab 'BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="Quote"/> to Vocab 'Quote.cdm.json/Quote' with Property 'QuoteId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="QuoteLineDetail"/> to Vocab 'QuoteLineTransaction.cdm.json/QuoteLineTransaction' with Property 'QuoteLineTransactionId'
            ///Property <see cref="QuoteLineScheduleOfValue"/> to Vocab 'QuoteLineScheduleOfValue.cdm.json/QuoteLineScheduleOfValue' with Property 'QuoteLineScheduleOfValueId'
            ///Property <see cref="TransactionCategory"/> to Vocab 'TransactionCategory.cdm.json/TransactionCategory' with Property 'TransactionCategoryId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey Amount { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey EndDateTime { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey PriceBase { get; private set; }
        public VocabularyKey QuoteLineAnalyticsBreakdownId { get; private set; }
        public VocabularyKey StartDateTime { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
        public VocabularyKey TransactionTypeCode { get; private set; }
    }
}