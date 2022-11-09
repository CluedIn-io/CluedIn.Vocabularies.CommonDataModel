using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjVendorRetentionTermScheduleEntityVocabulary : SimpleVocabulary
    {
        public ProjVendorRetentionTermScheduleEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjVendorRetentionTermScheduleEntity";
            KeyPrefix = "commonDataModel.projvendorretentiontermscheduleentity";
            KeySeparator = ".";
            Grouping = "/ProjVendorRetentionTermScheduleEntity";

            AddGroup("Common Data Model ProjVendorRetentionTermScheduleEntity Details", group =>
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