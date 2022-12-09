using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class OrderLineTransactionCategoryVocabulary : SimpleVocabulary
    {
        public OrderLineTransactionCategoryVocabulary()
        {
            VocabularyName = "Order Line Transaction Category";
            KeyPrefix = "commonDataModel.orderlinetransactioncategory";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.OrderLineTransactionCategory;

            AddGroup("OrderLineTransactionCategory Details for ProjectServiceAutomation", group =>
            {
			    OrderLineTransactionCategoryId = group.Add(new VocabularyKey(nameof(OrderLineTransactionCategoryId), "Project Contract Line Transaction Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractLine = group.Add(new VocabularyKey(nameof(ContractLine), "(Deprecated) Project Contract Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
            ///Property <see cref="ContractLineId"/> to Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="ContractLineTransactionClassification"/> to Vocab 'OrderLineTransactionClassification.cdm.json/OrderLineTransactionClassification' with Property 'OrderLineTransactionClassificationId'
            ///Property <see cref="TransactionCategory"/> to Vocab 'TransactionCategory.cdm.json/TransactionCategory' with Property 'TransactionCategoryId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey ContractLine { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey OrderLineTransactionCategoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
    }
}