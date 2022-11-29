using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class AggregateKPIContextVocabulary : SimpleVocabulary
    {
        public AggregateKPIContextVocabulary()
        {
            VocabularyName = "Aggregate KPI Context";
            KeyPrefix = "commonDataModel.aggregatekpicontext.automotive";
            KeySeparator = ".";
            Grouping = "/AggregateKPIContext";

            AddGroup("AggregateKPIContext Details for Automotive", group =>
            {
			    AggregateKPIContextId = group.Add(new VocabularyKey(nameof(AggregateKPIContextId), "Aggregate KPI Context", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TargetValue = group.Add(new VocabularyKey(nameof(TargetValue), "Target Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AggregateKPIContextId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey TargetValue { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}