using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceRepairStageEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceRepairStageEntityVocabulary()
        {
            VocabularyName = "SMAServiceRepairStageEntity";
            KeyPrefix = "commonDataModel.smaservicerepairstageentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceRepairStageEntity";

            AddGroup("SMAServiceRepairStageEntity Details", group =>
            {
                IsFinishedStage = group.Add(new VocabularyKey(nameof(IsFinishedStage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StageDescription = group.Add(new VocabularyKey(nameof(StageDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StageId = group.Add(new VocabularyKey(nameof(StageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsFinishedStage { get; private set; }
        public VocabularyKey StageDescription { get; private set; }
        public VocabularyKey StageId { get; private set; }


    }
}