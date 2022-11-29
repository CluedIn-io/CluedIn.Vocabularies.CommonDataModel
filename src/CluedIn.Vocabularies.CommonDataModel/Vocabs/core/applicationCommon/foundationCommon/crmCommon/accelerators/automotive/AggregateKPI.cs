using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class AggregateKPIVocabulary : SimpleVocabulary
    {
        public AggregateKPIVocabulary()
        {
            VocabularyName = "Aggregate KPI";
            KeyPrefix = "commonDataModel.aggregatekpi.automotive";
            KeySeparator = ".";
            Grouping = "/AggregateKPI";

            AddGroup("AggregateKPI Details for Automotive", group =>
            {
			    AggregateKPIId = group.Add(new VocabularyKey(nameof(AggregateKPIId), "Aggregate KPI", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FormulaDescription = group.Add(new VocabularyKey(nameof(FormulaDescription), "Formula Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MeasurementType = group.Add(new VocabularyKey(nameof(MeasurementType), "Measurement Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UsageDescription = group.Add(new VocabularyKey(nameof(UsageDescription), "Usage Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AggregateKPIId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey FormulaDescription { get; private set; }
        public VocabularyKey MeasurementType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey UsageDescription { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}