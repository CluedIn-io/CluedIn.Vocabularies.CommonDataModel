using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PhoneCallVocabulary : SimpleVocabulary
    {
        public PhoneCallVocabulary()
        {
            VocabularyName = "Phone Call";
            KeyPrefix = "commonDataModel.phonecall";
            KeySeparator = ".";
            Grouping = "/PhoneCall";

            AddGroup("PhoneCall Details", group =>
            {
            });
        }
    }
}