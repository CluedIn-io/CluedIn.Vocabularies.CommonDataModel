using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeadScoreDeprecatedVocabulary : SimpleVocabulary
    {
        public LeadScoreDeprecatedVocabulary()
        {
            VocabularyName = "Common Data Model LeadScoreDeprecated";
            KeyPrefix = "commonDataModel.leadscoredeprecated";
            KeySeparator = ".";
            Grouping = "/LeadScoreDeprecated";

            AddGroup("Common Data Model LeadScoreDeprecated Details", group =>
            {
                leadscoreId = group.Add(new VocabularyKey(nameof(leadscoreId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                pcenLead = group.Add(new VocabularyKey(nameof(pcenLead), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                requestbuilderserviceMktleadscores = group.Add(new VocabularyKey(nameof(requestbuilderserviceMktleadscores), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                resultparserserviceMktleadscores = group.Add(new VocabularyKey(nameof(resultparserserviceMktleadscores), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                selectGrade = group.Add(new VocabularyKey(nameof(selectGrade), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                selectScore = group.Add(new VocabularyKey(nameof(selectScore), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                selectScoringmodelName = group.Add(new VocabularyKey(nameof(selectScoringmodelName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                selectScoringmodelid = group.Add(new VocabularyKey(nameof(selectScoringmodelid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIDType = group.Add(new VocabularyKey(nameof(ownerIDType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey leadscoreId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey pcenLead { get; private set; }
        public VocabularyKey requestbuilderserviceMktleadscores { get; private set; }
        public VocabularyKey resultparserserviceMktleadscores { get; private set; }
        public VocabularyKey selectGrade { get; private set; }
        public VocabularyKey selectScore { get; private set; }
        public VocabularyKey selectScoringmodelName { get; private set; }
        public VocabularyKey selectScoringmodelid { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIDType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}