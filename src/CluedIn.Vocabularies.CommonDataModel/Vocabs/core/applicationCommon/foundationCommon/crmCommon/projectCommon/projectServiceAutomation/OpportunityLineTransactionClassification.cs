using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class OpportunityLineTransactionClassificationVocabulary : SimpleVocabulary
    {
        public OpportunityLineTransactionClassificationVocabulary()
        {
            VocabularyName = "Opportunity Line Transaction Classification";
            KeyPrefix = "commonDataModel.opportunitylinetransactionclassification";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.OpportunityLineTransactionClassification;

            AddGroup("OpportunityLineTransactionClassification Details for ProjectServiceAutomation", group =>
            {
                OpportunityLineTransactionClassificatioId = group.Add(new VocabularyKey(nameof(OpportunityLineTransactionClassificatioId), "Opportunity Line Transaction Classification", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Include = group.Add(new VocabularyKey(nameof(Include), "Map for Costs calculation?", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                OpportunityLine = group.Add(new VocabularyKey(nameof(OpportunityLine), "Opportunity Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="OpportunityLineTransactionClassificatioId"/> from Vocab 'OpportunityLineResourceCategory.cdm.json/OpportunityLineResourceCategory' with Property 'OpportunityLineTransactionClassification'
            ///Property <see cref="OpportunityLineTransactionClassificatioId"/> from Vocab 'OpportunityLineTransactionCategory.cdm.json/OpportunityLineTransactionCategory' with Property 'OpportunityLineTransactionClassification'
            #endregion
        }

        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Include { get; private set; }
        public VocabularyKey OpportunityLine { get; private set; }
        public VocabularyKey OpportunityLineTransactionClassificatioId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
    }
}