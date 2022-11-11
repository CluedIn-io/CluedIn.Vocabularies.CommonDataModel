using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRBrokerDifferentialReasonCodeEntityVocabulary : SimpleVocabulary
    {
        public MCRBrokerDifferentialReasonCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRBrokerDifferentialReasonCodeEntity";
            KeyPrefix = "commonDataModel.mcrbrokerdifferentialreasoncodeentity";
            KeySeparator = ".";
            Grouping = "/MCRBrokerDifferentialReasonCodeEntity";

            AddGroup("Common Data Model MCRBrokerDifferentialReasonCodeEntity Details", group =>
            {
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteOffMainAccountId = group.Add(new VocabularyKey(nameof(WriteOffMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteOffMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(WriteOffMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ReasonDescription { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
        public VocabularyKey WriteOffMainAccountId { get; private set; }
        public VocabularyKey WriteOffMainAccountIdDisplayValue { get; private set; }


    }
}