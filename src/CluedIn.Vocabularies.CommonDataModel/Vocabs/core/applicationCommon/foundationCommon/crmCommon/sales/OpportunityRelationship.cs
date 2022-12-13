using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class OpportunityRelationshipVocabulary : SimpleVocabulary
    {
        public OpportunityRelationshipVocabulary()
        {
            VocabularyName = "Opportunity Relationship";
            KeyPrefix = "commonDataModel.opportunityrelationship";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.OpportunityRelationship;

            AddGroup("OpportunityRelationship Details for Sales", group =>
            {
                CustomerOpportunityRoleId = group.Add(new VocabularyKey(nameof(CustomerOpportunityRoleId), "Opportunity Relationship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpportunityRoleId = group.Add(new VocabularyKey(nameof(OpportunityRoleId), "Customer Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpportunityStateCode = group.Add(new VocabularyKey(nameof(OpportunityStateCode), "Opportunity Status", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OpportunityStatusCode = group.Add(new VocabularyKey(nameof(OpportunityStatusCode), "Opportunity Status Reason", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Account.cdm.json/Account' with Property 'AccountId'
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey CustomerOpportunityRoleId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey OpportunityRoleId { get; private set; }
        public VocabularyKey OpportunityStateCode { get; private set; }
        public VocabularyKey OpportunityStatusCode { get; private set; }
    }
}