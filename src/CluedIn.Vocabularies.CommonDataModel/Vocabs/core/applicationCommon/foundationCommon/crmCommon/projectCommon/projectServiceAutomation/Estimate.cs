using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class EstimateVocabulary : SimpleVocabulary
    {
        public EstimateVocabulary()
        {
            VocabularyName = "Estimate";
            KeyPrefix = "commonDataModel.estimate.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/Estimate";

            AddGroup("Estimate Details for ProjectServiceAutomation", group =>
            {
			    EstimateId = group.Add(new VocabularyKey(nameof(EstimateId), "Estimate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimateHeaderType = group.Add(new VocabularyKey(nameof(EstimateHeaderType), "Estimate Header Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EstimateId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EstimateHeaderType { get; private set; }
    }
}