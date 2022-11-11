using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSLateShipReasonEntityVocabulary : SimpleVocabulary
    {
        public TMSLateShipReasonEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSLateShipReasonEntity";
            KeyPrefix = "commonDataModel.tmslateshipreasonentity";
            KeySeparator = ".";
            Grouping = "/TMSLateShipReasonEntity";

            AddGroup("Common Data Model TMSLateShipReasonEntity Details", group =>
            {
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ReasonCode { get; private set; }
        public VocabularyKey ReasonDescription { get; private set; }


    }
}