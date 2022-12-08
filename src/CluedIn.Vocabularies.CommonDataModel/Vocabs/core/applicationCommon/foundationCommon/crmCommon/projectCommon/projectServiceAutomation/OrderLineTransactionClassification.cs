using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectServiceAutomation
{
    public class OrderLineTransactionClassificationVocabulary : SimpleVocabulary
    {
        public OrderLineTransactionClassificationVocabulary()
        {
            VocabularyName = "Order Line Transaction Classification";
            KeyPrefix = "commonDataModel.orderlinetransactionclassification.projectserviceautomation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.OrderLineTransactionClassification;

            AddGroup("OrderLineTransactionClassification Details for ProjectServiceAutomation", group =>
            {
			    OrderLineTransactionClassificationId = group.Add(new VocabularyKey(nameof(OrderLineTransactionClassificationId), "Project Contract Line Transaction Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractLine = group.Add(new VocabularyKey(nameof(ContractLine), "(Deprecated) Contract Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Include = group.Add(new VocabularyKey(nameof(Include), "Map for Costs calculation?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), "Transaction Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
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
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="OrderLineTransactionClassificationId"/> from Vocab 'OrderLineResourceCategory.cdm.json/OrderLineResourceCategory' with Property 'ContractLineTransactionClassification'
            ///Property <see cref="OrderLineTransactionClassificationId"/> from Vocab 'OrderLineTransactionCategory.cdm.json/OrderLineTransactionCategory' with Property 'ContractLineTransactionClassification'
            #endregion
        }

        public VocabularyKey OrderLineTransactionClassificationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey ContractLine { get; private set; }
        public VocabularyKey Include { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
    }
}