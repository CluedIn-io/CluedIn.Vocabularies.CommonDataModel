using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqReductionKeyEntityVocabulary : SimpleVocabulary
    {
        public ReqReductionKeyEntityVocabulary()
        {
            VocabularyName = "Req Reduction Key Entity";
            KeyPrefix = "commonDataModel.reqreductionkeyentity";
            KeySeparator = ".";
            Grouping = "/ReqReductionKeyEntity";

            AddGroup("ReqReductionKeyEntity Details", group =>
            {
                IsEffectiveDateUsed = group.Add(new VocabularyKey(nameof(IsEffectiveDateUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeyName = group.Add(new VocabularyKey(nameof(KeyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeyId = group.Add(new VocabularyKey(nameof(KeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IsEffectiveDateUsed { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
        public VocabularyKey KeyName { get; private set; }
        public VocabularyKey KeyId { get; private set; }
    }
}