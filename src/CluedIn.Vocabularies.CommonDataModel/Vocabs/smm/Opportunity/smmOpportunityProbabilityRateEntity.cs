using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmOpportunityProbabilityRateEntityVocabulary : SimpleVocabulary
    {
        public SmmOpportunityProbabilityRateEntityVocabulary()
        {
            VocabularyName = "Smm Opportunity Probability Rate Entity";
            KeyPrefix = "commonDataModel.smmopportunityprobabilityrateentity";
            KeySeparator = ".";
            Grouping = "/SmmOpportunityProbabilityRateEntity";

            AddGroup("SmmOpportunityProbabilityRateEntity Details", group =>
            {
                ProbabilityDescription = group.Add(new VocabularyKey(nameof(ProbabilityDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProbabilityPercentage = group.Add(new VocabularyKey(nameof(ProbabilityPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProbabilityDescription { get; private set; }
        public VocabularyKey ProbabilityPercentage { get; private set; }
    }
}