using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class DocketVocabulary : SimpleVocabulary
    {
        public DocketVocabulary()
        {
            VocabularyName = "Docket";
            KeyPrefix = "commonDataModel.docket.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Docket";

            AddGroup("Docket Details for NonProfitCore", group =>
            {
			    DocketId = group.Add(new VocabularyKey(nameof(DocketId), "Docket", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InternalDueDate = group.Add(new VocabularyKey(nameof(InternalDueDate), "Internal Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SummaryDescription = group.Add(new VocabularyKey(nameof(SummaryDescription), "Summary Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DocketId { get; private set; }
        public VocabularyKey InternalDueDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SummaryDescription { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}