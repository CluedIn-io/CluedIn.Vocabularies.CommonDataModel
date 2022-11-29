using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Marketing
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact.marketing";
            KeySeparator = ".";
            Grouping = "/Contact";

            AddGroup("Contact Details for Marketing", group =>
            {
			    RememberMe = group.Add(new VocabularyKey(nameof(RememberMe), "Remember me", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), "Insights", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PortalInvitationCode = group.Add(new VocabularyKey(nameof(PortalInvitationCode), "Portal Invitation Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PortalInvitationURL = group.Add(new VocabularyKey(nameof(PortalInvitationURL), "Portal Invitation URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RememberMe { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey PortalInvitationCode { get; private set; }
        public VocabularyKey PortalInvitationURL { get; private set; }
    }
}