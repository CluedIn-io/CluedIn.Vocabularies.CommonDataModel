using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CrmCommon
{
    public class ActivityVocabulary : SimpleVocabulary
    {
        public ActivityVocabulary()
        {
            VocabularyName = "Activity";
            KeyPrefix = "commonDataModel.activity.crmcommon";
            KeySeparator = ".";
            Grouping = "/Activity";

            AddGroup("Activity Details for CrmCommon", group =>
            {
			    AllActivityParties = group.Add(new VocabularyKey(nameof(AllActivityParties), "All Activity Parties", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AllActivityParties { get; private set; }
    }
}