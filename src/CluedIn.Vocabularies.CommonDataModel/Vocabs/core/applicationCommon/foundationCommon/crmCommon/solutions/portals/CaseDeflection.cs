using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class CaseDeflectionVocabulary : SimpleVocabulary
    {
        public CaseDeflectionVocabulary()
        {
            VocabularyName = "Case Deflection";
            KeyPrefix = "commonDataModel.casedeflection.portals";
            KeySeparator = ".";
            Grouping = "/CaseDeflection";

            AddGroup("CaseDeflection Details for Portals", group =>
            {
			    CaseDeflectionId = group.Add(new VocabularyKey(nameof(CaseDeflectionId), "Case Deflection", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CaseTitle = group.Add(new VocabularyKey(nameof(CaseTitle), "Case Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CaseDeflectionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CaseTitle { get; private set; }
    }
}