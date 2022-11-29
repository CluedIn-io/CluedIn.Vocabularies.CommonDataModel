using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectCommon
{
    public class LeadVocabulary : SimpleVocabulary
    {
        public LeadVocabulary()
        {
            VocabularyName = "Lead";
            KeyPrefix = "commonDataModel.lead.projectcommon";
            KeySeparator = ".";
            Grouping = "/Lead";

            AddGroup("Lead Details for ProjectCommon", group =>
            {
			    GDPROptOut = group.Add(new VocabularyKey(nameof(GDPROptOut), "GDPR Optout", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    OrderType = group.Add(new VocabularyKey(nameof(OrderType), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey GDPROptOut { get; private set; }
        public VocabularyKey OrderType { get; private set; }
    }
}