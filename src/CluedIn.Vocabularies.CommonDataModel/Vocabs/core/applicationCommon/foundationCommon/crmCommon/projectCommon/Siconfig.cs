using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectCommon
{
    public class SiconfigVocabulary : SimpleVocabulary
    {
        public SiconfigVocabulary()
        {
            VocabularyName = "Siconfig";
            KeyPrefix = "commonDataModel.siconfig.projectcommon";
            KeySeparator = ".";
            Grouping = "/Siconfig";

            AddGroup("Siconfig Details for ProjectCommon", group =>
            {
			    SiConfigId = group.Add(new VocabularyKey(nameof(SiConfigId), "siconfig", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Version = group.Add(new VocabularyKey(nameof(Version), "Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SiConfigId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Version { get; private set; }
    }
}