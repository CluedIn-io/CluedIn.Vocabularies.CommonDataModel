using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceStageReasonCodeEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceStageReasonCodeEntityVocabulary()
        {
            VocabularyName = "SMAServiceStageReasonCodeEntity";
            KeyPrefix = "commonDataModel.smaservicestagereasoncodeentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceStageReasonCodeEntity";

            AddGroup("SMAServiceStageReasonCodeEntity Details", group =>
            {
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ReasonDescription { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }


    }
}