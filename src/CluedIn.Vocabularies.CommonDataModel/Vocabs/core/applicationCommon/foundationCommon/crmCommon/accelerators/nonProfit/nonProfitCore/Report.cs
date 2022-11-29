using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class ReportVocabulary : SimpleVocabulary
    {
        public ReportVocabulary()
        {
            VocabularyName = "Report";
            KeyPrefix = "commonDataModel.report.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Report";

            AddGroup("Report Details for NonProfitCore", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DueDate = group.Add(new VocabularyKey(nameof(DueDate), "Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReportId = group.Add(new VocabularyKey(nameof(ReportId), "Report", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Report Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubmittedDate = group.Add(new VocabularyKey(nameof(SubmittedDate), "Submitted Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReportId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SubmittedDate { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}