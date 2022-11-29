using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class AggregateKPIMeasurementVocabulary : SimpleVocabulary
    {
        public AggregateKPIMeasurementVocabulary()
        {
            VocabularyName = "Aggregate KPI Measurement";
            KeyPrefix = "commonDataModel.aggregatekpimeasurement.automotive";
            KeySeparator = ".";
            Grouping = "/AggregateKPIMeasurement";

            AddGroup("AggregateKPIMeasurement Details for Automotive", group =>
            {
			    AggregateId = group.Add(new VocabularyKey(nameof(AggregateId), "Aggregate KPI Measurement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Count = group.Add(new VocabularyKey(nameof(Count), "Count", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Max = group.Add(new VocabularyKey(nameof(Max), "Max", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Mean = group.Add(new VocabularyKey(nameof(Mean), "Mean", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    MeasuredOn = group.Add(new VocabularyKey(nameof(MeasuredOn), "Measured On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Min = group.Add(new VocabularyKey(nameof(Min), "Min", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StdDev = group.Add(new VocabularyKey(nameof(StdDev), "StdDev", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    TargetValue = group.Add(new VocabularyKey(nameof(TargetValue), "Target Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Value Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AggregateId { get; private set; }
        public VocabularyKey Count { get; private set; }
        public VocabularyKey Max { get; private set; }
        public VocabularyKey Mean { get; private set; }
        public VocabularyKey MeasuredOn { get; private set; }
        public VocabularyKey Min { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StdDev { get; private set; }
        public VocabularyKey TargetValue { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}