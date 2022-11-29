using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CustomerInsights
{
    public class MeasureDefinitionVocabulary : SimpleVocabulary
    {
        public MeasureDefinitionVocabulary()
        {
            VocabularyName = "Measure Definition";
            KeyPrefix = "commonDataModel.measuredefinition.customerinsights";
            KeySeparator = ".";
            Grouping = "/MeasureDefinition";

            AddGroup("MeasureDefinition Details for CustomerInsights", group =>
            {
			    LastEvaluationDate = group.Add(new VocabularyKey(nameof(LastEvaluationDate), "Last Evaluation Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MeasureDefinitionId = group.Add(new VocabularyKey(nameof(MeasureDefinitionId), "Measure Definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MeasureName = group.Add(new VocabularyKey(nameof(MeasureName), "Measure Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MeasureQuery = group.Add(new VocabularyKey(nameof(MeasureQuery), "Measure Query", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MeasureSubType = group.Add(new VocabularyKey(nameof(MeasureSubType), "Measure SubType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MeasureType = group.Add(new VocabularyKey(nameof(MeasureType), "Measure Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Version = group.Add(new VocabularyKey(nameof(Version), "Version", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey LastEvaluationDate { get; private set; }
        public VocabularyKey MeasureDefinitionId { get; private set; }
        public VocabularyKey MeasureName { get; private set; }
        public VocabularyKey MeasureQuery { get; private set; }
        public VocabularyKey MeasureSubType { get; private set; }
        public VocabularyKey MeasureType { get; private set; }
        public VocabularyKey Version { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}