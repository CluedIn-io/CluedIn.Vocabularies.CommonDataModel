using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ActualDataExportVocabulary : SimpleVocabulary
    {
        public ActualDataExportVocabulary()
        {
            VocabularyName = "Actual Data Export";
            KeyPrefix = "commonDataModel.actualdataexport.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/ActualDataExport";

            AddGroup("ActualDataExport Details for ProjectServiceAutomation", group =>
            {
			    DataExportId = group.Add(new VocabularyKey(nameof(DataExportId), "Actual Data Export", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DataToken = group.Add(new VocabularyKey(nameof(DataToken), "Data Token", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityName = group.Add(new VocabularyKey(nameof(EntityName), "Entity Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExportedRecordCount = group.Add(new VocabularyKey(nameof(ExportedRecordCount), "Exported Record Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ExportStatus = group.Add(new VocabularyKey(nameof(ExportStatus), "Export Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedEntityData = group.Add(new VocabularyKey(nameof(LinkedEntityData), "Linked Entity Data", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PagingData = group.Add(new VocabularyKey(nameof(PagingData), "Paging Data", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DataExportId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey DataToken { get; private set; }
        public VocabularyKey EntityName { get; private set; }
        public VocabularyKey ExportedRecordCount { get; private set; }
        public VocabularyKey ExportStatus { get; private set; }
        public VocabularyKey LinkedEntityData { get; private set; }
        public VocabularyKey PagingData { get; private set; }
    }
}