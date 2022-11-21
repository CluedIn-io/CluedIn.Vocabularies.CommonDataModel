using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmSigningLimitRevocationReasonCodeEntityVocabulary : SimpleVocabulary
    {
        public HcmSigningLimitRevocationReasonCodeEntityVocabulary()
        {
            VocabularyName = "Hcm Signing Limit Revocation Reason Code Entity";
            KeyPrefix = "commonDataModel.hcmsigninglimitrevocationreasoncodeentity";
            KeySeparator = ".";
            Grouping = "/HcmSigningLimitRevocationReasonCodeEntity";

            AddGroup("HcmSigningLimitRevocationReasonCodeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
    }
}