using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class QuoteLineTransactionCategoryVocabulary : SimpleVocabulary
    {
        public QuoteLineTransactionCategoryVocabulary()
        {
            VocabularyName = "Quote Line Transaction Category";
            KeyPrefix = "commonDataModel.quotelinetransactioncategory";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.QuoteLineTransactionCategory;

            AddGroup("QuoteLineTransactionCategory Details for ProjectServiceAutomation", group =>
            {
			    QuoteLineTransactionCategoryId = group.Add(new VocabularyKey(nameof(QuoteLineTransactionCategoryId), "Quote Line Transaction Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QuoteLine = group.Add(new VocabularyKey(nameof(QuoteLine), "(Deprecated) Quote Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), "Transaction Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="QuoteLineId"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            ///Property <see cref="QuoteLineTransactionClassification"/> to Vocab 'QuoteLineTransactionClassification.cdm.json/QuoteLineTransactionClassification' with Property 'QuoteLineTransactionClassificationId'
            ///Property <see cref="TransactionCategory"/> to Vocab 'TransactionCategory.cdm.json/TransactionCategory' with Property 'TransactionCategoryId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey QuoteLine { get; private set; }
        public VocabularyKey QuoteLineTransactionCategoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
    }
}