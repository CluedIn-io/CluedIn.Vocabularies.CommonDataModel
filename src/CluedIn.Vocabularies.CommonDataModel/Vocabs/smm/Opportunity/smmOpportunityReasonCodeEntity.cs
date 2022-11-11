using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmOpportunityReasonCodeEntityVocabulary : SimpleVocabulary
    {
        public smmOpportunityReasonCodeEntityVocabulary()
        {
            VocabularyName = "smmOpportunityReasonCodeEntity";
            KeyPrefix = "commonDataModel.smmopportunityreasoncodeentity";
            KeySeparator = ".";
            Grouping = "/smmOpportunityReasonCodeEntity";

            AddGroup("smmOpportunityReasonCodeEntity Details", group =>
            {
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ReasonDescription { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }


    }
}