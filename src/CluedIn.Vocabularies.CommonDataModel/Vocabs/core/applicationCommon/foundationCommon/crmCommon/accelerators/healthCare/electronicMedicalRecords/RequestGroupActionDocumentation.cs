using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class RequestGroupActionDocumentationVocabulary : SimpleVocabulary
    {
        public RequestGroupActionDocumentationVocabulary()
        {
            VocabularyName = "Request Group Action Documentation";
            KeyPrefix = "commonDataModel.requestgroupactiondocumentation.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/RequestGroupActionDocumentation";

            AddGroup("RequestGroupActionDocumentation Details for ElectronicMedicalRecords", group =>
            {
			    DocumentationCitation = group.Add(new VocabularyKey(nameof(DocumentationCitation), "Documentation Citation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DocumentationDisplay = group.Add(new VocabularyKey(nameof(DocumentationDisplay), "Documentation Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DocumentationType = group.Add(new VocabularyKey(nameof(DocumentationType), "Documentation Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DocumentationUrl = group.Add(new VocabularyKey(nameof(DocumentationUrl), "Documentation Url", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestGroupActionDocumentId = group.Add(new VocabularyKey(nameof(RequestGroupActionDocumentId), "Request Group Action Document", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Resource = group.Add(new VocabularyKey(nameof(Resource), "Resource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DocumentationCitation { get; private set; }
        public VocabularyKey DocumentationDisplay { get; private set; }
        public VocabularyKey DocumentationType { get; private set; }
        public VocabularyKey DocumentationUrl { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequestGroupActionDocumentId { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}