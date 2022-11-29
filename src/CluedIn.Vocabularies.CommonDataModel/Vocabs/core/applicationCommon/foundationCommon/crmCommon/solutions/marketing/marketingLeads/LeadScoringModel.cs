using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.MarketingLeads
{
    public class LeadScoringModelVocabulary : SimpleVocabulary
    {
        public LeadScoringModelVocabulary()
        {
            VocabularyName = "Lead Scoring Model";
            KeyPrefix = "commonDataModel.leadscoringmodel.marketingleads";
            KeySeparator = ".";
            Grouping = "/LeadScoringModel";

            AddGroup("LeadScoringModel Details for MarketingLeads", group =>
            {
			    LeadScoreModelId = group.Add(new VocabularyKey(nameof(LeadScoreModelId), "Lead scoring model", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), "Insights", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModelDefinition = group.Add(new VocabularyKey(nameof(ModelDefinition), "Model definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey LeadScoreModelId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey ModelDefinition { get; private set; }
    }
}