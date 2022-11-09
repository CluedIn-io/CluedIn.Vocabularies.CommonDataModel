using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeadScoringModelVocabulary : SimpleVocabulary
    {
        public LeadScoringModelVocabulary()
        {
            VocabularyName = "Common Data Model LeadScoringModel";
            KeyPrefix = "commonDataModel.leadscoringmodel";
            KeySeparator = ".";
            Grouping = "/LeadScoringModel";

            AddGroup("Common Data Model LeadScoringModel Details", group =>
            {
                requiredConsent = group.Add(new VocabularyKey(nameof(requiredConsent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey requiredConsent { get; private set; }


    }
}