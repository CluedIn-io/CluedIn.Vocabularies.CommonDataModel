using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class InvitationVocabulary : SimpleVocabulary
    {
        public InvitationVocabulary()
        {
            VocabularyName = "Invitation";
            KeyPrefix = "commonDataModel.invitation.portals";
            KeySeparator = ".";
            Grouping = "/Invitation";

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
        }

        public VocabularyKey InvitationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ExpiryDate { get; private set; }
        public VocabularyKey InvitationCode { get; private set; }
        public VocabularyKey MaximumRedemptions { get; private set; }
        public VocabularyKey Redemptions { get; private set; }
        public VocabularyKey RedemptionWorkflow { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}