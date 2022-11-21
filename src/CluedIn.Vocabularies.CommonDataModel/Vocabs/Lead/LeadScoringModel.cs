using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeadScoringModelVocabulary : SimpleVocabulary
    {
        public LeadScoringModelVocabulary()
        {
            VocabularyName = "Lead Scoring Model";
            KeyPrefix = "commonDataModel.leadscoringmodel";
            KeySeparator = ".";
            Grouping = "/LeadScoringModel";

            AddGroup("LeadScoringModel Details", group =>
            {
                RequiredConsent = group.Add(new VocabularyKey(nameof(RequiredConsent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RequiredConsent { get; private set; }
    }
}