using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeadScoringModelVocabulary : SimpleVocabulary
    {
        public LeadScoringModelVocabulary()
        {
            VocabularyName = "LeadScoringModel";
            KeyPrefix = "commonDataModel.leadscoringmodel";
            KeySeparator = ".";
            Grouping = "/LeadScoringModel";

            AddGroup("LeadScoringModel Details", group =>
            {
                requiredConsent = group.Add(new VocabularyKey(nameof(requiredConsent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey requiredConsent { get; private set; }


    }
}