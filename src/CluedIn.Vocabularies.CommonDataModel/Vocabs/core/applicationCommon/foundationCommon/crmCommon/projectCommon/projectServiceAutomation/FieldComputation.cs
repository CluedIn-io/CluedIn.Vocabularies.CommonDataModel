using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class FieldComputationVocabulary : SimpleVocabulary
    {
        public FieldComputationVocabulary()
        {
            VocabularyName = "Field Computation";
            KeyPrefix = "commonDataModel.fieldcomputation.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/FieldComputation";

            AddGroup("FieldComputation Details for ProjectServiceAutomation", group =>
            {
			    FieldComputationId = group.Add(new VocabularyKey(nameof(FieldComputationId), "Field Computation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ComputedField = group.Add(new VocabularyKey(nameof(ComputedField), "Computed Transaction Field", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey FieldComputationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ComputedField { get; private set; }
    }
}