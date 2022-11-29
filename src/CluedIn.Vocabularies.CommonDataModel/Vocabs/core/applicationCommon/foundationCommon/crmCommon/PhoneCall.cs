using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CrmCommon
{
    public class PhoneCallVocabulary : SimpleVocabulary
    {
        public PhoneCallVocabulary()
        {
            VocabularyName = "Phone Call";
            KeyPrefix = "commonDataModel.phonecall.crmcommon";
            KeySeparator = ".";
            Grouping = "/PhoneCall";

            AddGroup("PhoneCall Details for CrmCommon", group =>
            {
			    To = group.Add(new VocabularyKey(nameof(To), "Call To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    From = group.Add(new VocabularyKey(nameof(From), "Call From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey To { get; private set; }
        public VocabularyKey From { get; private set; }
    }
}