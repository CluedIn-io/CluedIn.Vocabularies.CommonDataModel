using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetDepreciationProfileManualScheduleEntityVocabulary : SimpleVocabulary
    {
        public AssetDepreciationProfileManualScheduleEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetDepreciationProfileManualScheduleEntity";
            KeyPrefix = "commonDataModel.assetdepreciationprofilemanualscheduleentity";
            KeySeparator = ".";
            Grouping = "/AssetDepreciationProfileManualScheduleEntity";

            AddGroup("Common Data Model AssetDepreciationProfileManualScheduleEntity Details", group =>
            {
                IntervalNumber = group.Add(new VocabularyKey(nameof(IntervalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Percentage = group.Add(new VocabularyKey(nameof(Percentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProfileId = group.Add(new VocabularyKey(nameof(ProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IntervalNumber { get; private set; }
public VocabularyKey Percentage { get; private set; }
public VocabularyKey ProfileId { get; private set; }


    }
}