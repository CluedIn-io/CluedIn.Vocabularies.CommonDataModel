using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class ResultVocabulary : SimpleVocabulary
    {
        public ResultVocabulary()
        {
            VocabularyName = "Result";
            KeyPrefix = "commonDataModel.result.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Result";

            AddGroup("Result Details for NonProfitCore", group =>
            {
			    AggregationStatus = group.Add(new VocabularyKey(nameof(AggregationStatus), "Aggregation Status", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResultId = group.Add(new VocabularyKey(nameof(ResultId), "Result", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResultType = group.Add(new VocabularyKey(nameof(ResultType), "Result Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AggregationStatus { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ResultId { get; private set; }
        public VocabularyKey ResultType { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}