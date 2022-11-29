using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Banking
{
    public class LeadToOpportunitySalesProcessVocabulary : SimpleVocabulary
    {
        public LeadToOpportunitySalesProcessVocabulary()
        {
            VocabularyName = "Lead To Opportunity Sales Process";
            KeyPrefix = "commonDataModel.leadtoopportunitysalesprocess.banking";
            KeySeparator = ".";
            Grouping = "/LeadToOpportunitySalesProcess";

            AddGroup("LeadToOpportunitySalesProcess Details for Banking", group =>
            {
			    LeadId = group.Add(new VocabularyKey(nameof(LeadId), "Lead", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OpportunityId = group.Add(new VocabularyKey(nameof(OpportunityId), "Opportunity Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey LeadId { get; private set; }
        public VocabularyKey OpportunityId { get; private set; }
    }
}