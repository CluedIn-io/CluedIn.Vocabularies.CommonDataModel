using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ScoringConfigurationVocabulary : SimpleVocabulary
    {
        public ScoringConfigurationVocabulary()
        {
            VocabularyName = "Scoring Configuration";
            KeyPrefix = "commonDataModel.scoringconfiguration";
            KeySeparator = ".";
            Grouping = "/ScoringConfiguration";

            AddGroup("ScoringConfiguration Details", group =>
            {
                AutomaticleadscorescleanupEnabled = group.Add(new VocabularyKey(nameof(AutomaticleadscorescleanupEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutomaticqualificationEnabled = group.Add(new VocabularyKey(nameof(AutomaticqualificationEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutomaticSalesreadyEnabled = group.Add(new VocabularyKey(nameof(AutomaticSalesreadyEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadscoringconfigurationId = group.Add(new VocabularyKey(nameof(LeadscoringconfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AutomaticleadscorescleanupEnabled { get; private set; }
        public VocabularyKey AutomaticqualificationEnabled { get; private set; }
        public VocabularyKey AutomaticSalesreadyEnabled { get; private set; }
        public VocabularyKey LeadscoringconfigurationId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}