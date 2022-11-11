using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PhoneCallVocabulary : SimpleVocabulary
    {
        public PhoneCallVocabulary()
        {
            VocabularyName = "Common Data Model PhoneCall";
            KeyPrefix = "commonDataModel.phonecall";
            KeySeparator = ".";
            Grouping = "/PhoneCall";

            AddGroup("Common Data Model PhoneCall Details", group =>
            {

            });
        }



    }
}