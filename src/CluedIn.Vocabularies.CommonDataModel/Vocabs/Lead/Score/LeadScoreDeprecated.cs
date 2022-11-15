using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeadScoreDeprecatedVocabulary : SimpleVocabulary
    {
        public LeadScoreDeprecatedVocabulary()
        {
            VocabularyName = "Lead Score Deprecated";
            KeyPrefix = "commonDataModel.leadscoredeprecated";
            KeySeparator = ".";
            Grouping = "/LeadScoreDeprecated";

            AddGroup("LeadScoreDeprecated Details", group =>
            {
                LeadscoreId = group.Add(new VocabularyKey(nameof(LeadscoreId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PcenLead = group.Add(new VocabularyKey(nameof(PcenLead), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestbuilderserviceMktleadscores = group.Add(new VocabularyKey(nameof(RequestbuilderserviceMktleadscores), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResultparserserviceMktleadscores = group.Add(new VocabularyKey(nameof(ResultparserserviceMktleadscores), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SelectGrade = group.Add(new VocabularyKey(nameof(SelectGrade), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SelectScore = group.Add(new VocabularyKey(nameof(SelectScore), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SelectScoringmodelName = group.Add(new VocabularyKey(nameof(SelectScoringmodelName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SelectScoringmodelid = group.Add(new VocabularyKey(nameof(SelectScoringmodelid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIDType = group.Add(new VocabularyKey(nameof(OwnerIDType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LeadscoreId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PcenLead { get; private set; }
        public VocabularyKey RequestbuilderserviceMktleadscores { get; private set; }
        public VocabularyKey ResultparserserviceMktleadscores { get; private set; }
        public VocabularyKey SelectGrade { get; private set; }
        public VocabularyKey SelectScore { get; private set; }
        public VocabularyKey SelectScoringmodelName { get; private set; }
        public VocabularyKey SelectScoringmodelid { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIDType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}