using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjVendorRetentionTermScheduleEntityVocabulary : SimpleVocabulary
    {
        public ProjVendorRetentionTermScheduleEntityVocabulary()
        {
            VocabularyName = "Proj Vendor Retention Term Schedule Entity";
            KeyPrefix = "commonDataModel.projvendorretentiontermscheduleentity";
            KeySeparator = ".";
            Grouping = "/ProjVendorRetentionTermScheduleEntity";

            AddGroup("ProjVendorRetentionTermScheduleEntity Details", group =>
            {
                PercentageToRetain = group.Add(new VocabularyKey(nameof(PercentageToRetain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PercentageToRelease = group.Add(new VocabularyKey(nameof(PercentageToRelease), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleID = group.Add(new VocabularyKey(nameof(RuleID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PercentageOfUnitsDelivered = group.Add(new VocabularyKey(nameof(PercentageOfUnitsDelivered), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PercentageToRetain { get; private set; }
        public VocabularyKey PercentageToRelease { get; private set; }
        public VocabularyKey RuleID { get; private set; }
        public VocabularyKey PercentageOfUnitsDelivered { get; private set; }
    }
}