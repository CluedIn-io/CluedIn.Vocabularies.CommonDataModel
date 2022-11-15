using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceTimeWindowEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceTimeWindowEntityVocabulary()
        {
            VocabularyName = "SMA Service Time Window Entity";
            KeyPrefix = "commonDataModel.smaservicetimewindowentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceTimeWindowEntity";

            AddGroup("SMAServiceTimeWindowEntity Details", group =>
            {
                MaximumManualForwardMovementDays = group.Add(new VocabularyKey(nameof(MaximumManualForwardMovementDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumManualBackwardMovementDays = group.Add(new VocabularyKey(nameof(MaximumManualBackwardMovementDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WindowDescription = group.Add(new VocabularyKey(nameof(WindowDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SchedulingMethod = group.Add(new VocabularyKey(nameof(SchedulingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WindowId = group.Add(new VocabularyKey(nameof(WindowId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MaximumManualForwardMovementDays { get; private set; }
        public VocabularyKey MaximumManualBackwardMovementDays { get; private set; }
        public VocabularyKey WindowDescription { get; private set; }
        public VocabularyKey SchedulingMethod { get; private set; }
        public VocabularyKey WindowId { get; private set; }
    }
}