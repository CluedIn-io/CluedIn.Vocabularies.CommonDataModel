using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ScheduleServiceTypeVocabulary : SimpleVocabulary
    {
        public ScheduleServiceTypeVocabulary()
        {
            VocabularyName = "Schedule Service Type";
            KeyPrefix = "commonDataModel.scheduleservicetype";
            KeySeparator = ".";
            Grouping = "/ScheduleServiceType";

            AddGroup("ScheduleServiceType Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduleServiceTypeId = group.Add(new VocabularyKey(nameof(ScheduleServiceTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ScheduleServiceTypeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}