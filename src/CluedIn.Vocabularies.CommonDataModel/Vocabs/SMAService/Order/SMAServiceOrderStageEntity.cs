using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceOrderStageEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceOrderStageEntityVocabulary()
        {
            VocabularyName = "Common Data Model SMAServiceOrderStageEntity";
            KeyPrefix = "commonDataModel.smaserviceorderstageentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceOrderStageEntity";

            AddGroup("Common Data Model SMAServiceOrderStageEntity Details", group =>
            {
                StageId = group.Add(new VocabularyKey(nameof(StageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentServiceOrderStageId = group.Add(new VocabularyKey(nameof(ParentServiceOrderStageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultServiceOrderActivityPhaseCode = group.Add(new VocabularyKey(nameof(DefaultServiceOrderActivityPhaseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStageAllowingServiceOrderCancelation = group.Add(new VocabularyKey(nameof(IsStageAllowingServiceOrderCancelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStageAllowingServiceOrderDeletion = group.Add(new VocabularyKey(nameof(IsStageAllowingServiceOrderDeletion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStageAllowingServiceOrderModification = group.Add(new VocabularyKey(nameof(IsStageAllowingServiceOrderModification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStageAllowingServiceOrderPosting = group.Add(new VocabularyKey(nameof(IsStageAllowingServiceOrderPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStageStoppingServiceOrderTimeRecording = group.Add(new VocabularyKey(nameof(IsStageStoppingServiceOrderTimeRecording), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StageDescription = group.Add(new VocabularyKey(nameof(StageDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStageRequiringServiceOrderReasonCodeEntry = group.Add(new VocabularyKey(nameof(IsStageRequiringServiceOrderReasonCodeEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey StageId { get; private set; }
        public VocabularyKey ParentServiceOrderStageId { get; private set; }
        public VocabularyKey DefaultServiceOrderActivityPhaseCode { get; private set; }
        public VocabularyKey IsStageAllowingServiceOrderCancelation { get; private set; }
        public VocabularyKey IsStageAllowingServiceOrderDeletion { get; private set; }
        public VocabularyKey IsStageAllowingServiceOrderModification { get; private set; }
        public VocabularyKey IsStageAllowingServiceOrderPosting { get; private set; }
        public VocabularyKey IsStageStoppingServiceOrderTimeRecording { get; private set; }
        public VocabularyKey StageDescription { get; private set; }
        public VocabularyKey IsStageRequiringServiceOrderReasonCodeEntry { get; private set; }


    }
}