using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PhoneCallVocabulary : SimpleVocabulary
    {
        public PhoneCallVocabulary()
        {
            VocabularyName = "PhoneCall";
            KeyPrefix = "commonDataModel.phonecall";
            KeySeparator = ".";
            Grouping = "/PhoneCall";

            AddGroup("PhoneCall Details", group =>
            {

            });
        }



    }
}