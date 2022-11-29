using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class WebRoleVocabulary : SimpleVocabulary
    {
        public WebRoleVocabulary()
        {
            VocabularyName = "Web Role";
            KeyPrefix = "commonDataModel.webrole.portals";
            KeySeparator = ".";
            Grouping = "/WebRole";

            AddGroup("WebRole Details for Portals", group =>
            {
			    WebRoleId = group.Add(new VocabularyKey(nameof(WebRoleId), "Web Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AuthenticatedUsersRole = group.Add(new VocabularyKey(nameof(AuthenticatedUsersRole), "Authenticated Users Role", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AnonymousUsersRole = group.Add(new VocabularyKey(nameof(AnonymousUsersRole), "Anonymous Users Role", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Key = group.Add(new VocabularyKey(nameof(Key), "Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey WebRoleId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AuthenticatedUsersRole { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey AnonymousUsersRole { get; private set; }
        public VocabularyKey Key { get; private set; }
    }
}