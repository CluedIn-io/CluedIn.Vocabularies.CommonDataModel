using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ScheduleServiceTypeVocabulary : SimpleVocabulary
    {
        public ScheduleServiceTypeVocabulary()
        {
            VocabularyName = "ScheduleServiceType";
            KeyPrefix = "commonDataModel.scheduleservicetype";
            KeySeparator = ".";
            Grouping = "/ScheduleServiceType";

            AddGroup("ScheduleServiceType Details", group =>
            {
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                scheduleServiceTypeId = group.Add(new VocabularyKey(nameof(scheduleServiceTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey name { get; private set; }
        public VocabularyKey scheduleServiceTypeId { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}