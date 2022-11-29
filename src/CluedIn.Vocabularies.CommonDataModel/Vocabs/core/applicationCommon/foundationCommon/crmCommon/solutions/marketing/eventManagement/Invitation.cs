using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.EventManagement
{
    public class InvitationVocabulary : SimpleVocabulary
    {
        public InvitationVocabulary()
        {
            VocabularyName = "Invitation";
            KeyPrefix = "commonDataModel.invitation.eventmanagement";
            KeySeparator = ".";
            Grouping = "/Invitation";

            AddGroup("Invitation Details for EventManagement", group =>
            {
			    EventPortalInvitation = group.Add(new VocabularyKey(nameof(EventPortalInvitation), "Event Portal Invitation", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EventPortalInvitation { get; private set; }
    }
}