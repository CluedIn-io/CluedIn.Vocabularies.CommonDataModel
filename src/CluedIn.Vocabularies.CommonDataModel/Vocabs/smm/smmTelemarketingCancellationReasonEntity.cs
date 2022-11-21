using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmTelemarketingCancellationReasonEntityVocabulary : SimpleVocabulary
    {
        public SmmTelemarketingCancellationReasonEntityVocabulary()
        {
            VocabularyName = "Smm Telemarketing Cancellation Reason Entity";
            KeyPrefix = "commonDataModel.smmtelemarketingcancellationreasonentity";
            KeySeparator = ".";
            Grouping = "/SmmTelemarketingCancellationReasonEntity";

            AddGroup("SmmTelemarketingCancellationReasonEntity Details", group =>
            {
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ReasonDescription { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
    }
}