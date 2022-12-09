using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class InvitationVocabulary : SimpleVocabulary
    {
        public InvitationVocabulary()
        {
            VocabularyName = "Invitation";
            KeyPrefix = "commonDataModel.invitation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Invitation;

            AddGroup("Invitation Details for EventManagement", group =>
            {
			    EventPortalInvitation = group.Add(new VocabularyKey(nameof(EventPortalInvitation), "Event Portal Invitation", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Invitation Details for Portals", group =>
            {
			    InvitationId = group.Add(new VocabularyKey(nameof(InvitationId), "Invitation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpiryDate = group.Add(new VocabularyKey(nameof(ExpiryDate), "Expiry Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InvitationCode = group.Add(new VocabularyKey(nameof(InvitationCode), "Invitation Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MaximumRedemptions = group.Add(new VocabularyKey(nameof(MaximumRedemptions), "Maximum Redemptions", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Redemptions = group.Add(new VocabularyKey(nameof(Redemptions), "Redemptions", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RedemptionWorkflow = group.Add(new VocabularyKey(nameof(RedemptionWorkflow), "Redemption Workflow", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="AssignToAccount"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="AssignToAccount"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="InviteContact"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="InviterContact"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="RedeemedContact"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Website"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/Website.cdm.json/Website' with Property 'WebsiteId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey EventPortalInvitation { get; private set; }
        public VocabularyKey ExpiryDate { get; private set; }
        public VocabularyKey InvitationCode { get; private set; }
        public VocabularyKey InvitationId { get; private set; }
        public VocabularyKey MaximumRedemptions { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Redemptions { get; private set; }
        public VocabularyKey RedemptionWorkflow { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}