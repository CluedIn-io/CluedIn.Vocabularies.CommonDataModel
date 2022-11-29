using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Marketing
{
    public class PhoneCallVocabulary : SimpleVocabulary
    {
        public PhoneCallVocabulary()
        {
            VocabularyName = "Phone Call";
            KeyPrefix = "commonDataModel.phonecall.marketing";
            KeySeparator = ".";
            Grouping = "/PhoneCall";

            AddGroup("PhoneCall Details for Marketing", group =>
            {
			    CustomerJourneyIteration = group.Add(new VocabularyKey(nameof(CustomerJourneyIteration), "Customer journey iteration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CustomerJourneyIteration { get; private set; }
    }
}