using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReturnCustomerReturnReasonCodeEntityVocabulary : SimpleVocabulary
    {
        public ReturnCustomerReturnReasonCodeEntityVocabulary()
        {
            VocabularyName = "Return Customer Return Reason Code Entity";
            KeyPrefix = "commonDataModel.returncustomerreturnreasoncodeentity";
            KeySeparator = ".";
            Grouping = "/ReturnCustomerReturnReasonCodeEntity";

            AddGroup("ReturnCustomerReturnReasonCodeEntity Details", group =>
            {
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerReturnReasonCodeGroupId = group.Add(new VocabularyKey(nameof(CustomerReturnReasonCodeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ReasonDescription { get; private set; }
        public VocabularyKey CustomerReturnReasonCodeGroupId { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
    }
}