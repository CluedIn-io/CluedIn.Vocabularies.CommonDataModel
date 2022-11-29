using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class PortalLanguageVocabulary : SimpleVocabulary
    {
        public PortalLanguageVocabulary()
        {
            VocabularyName = "Portal Language";
            KeyPrefix = "commonDataModel.portallanguage.portals";
            KeySeparator = ".";
            Grouping = "/PortalLanguage";

            AddGroup("PortalLanguage Details for Portals", group =>
            {
			    PortalLanguageId = group.Add(new VocabularyKey(nameof(PortalLanguageId), "Portal Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LanguageCode = group.Add(new VocabularyKey(nameof(LanguageCode), "Language Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SystemLanguage = group.Add(new VocabularyKey(nameof(SystemLanguage), "System Language", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PortalDisplayName = group.Add(new VocabularyKey(nameof(PortalDisplayName), "Portal Display Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Lcid = group.Add(new VocabularyKey(nameof(Lcid), "LCID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey PortalLanguageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey LanguageCode { get; private set; }
        public VocabularyKey SystemLanguage { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PortalDisplayName { get; private set; }
        public VocabularyKey Lcid { get; private set; }
    }
}