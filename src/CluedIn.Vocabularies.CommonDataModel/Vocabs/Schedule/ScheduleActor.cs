using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ScheduleActorVocabulary : SimpleVocabulary
    {
        public ScheduleActorVocabulary()
        {
            VocabularyName = "Schedule Actor";
            KeyPrefix = "commonDataModel.scheduleactor";
            KeySeparator = ".";
            Grouping = "/ScheduleActor";

            AddGroup("ScheduleActor Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduleActorId = group.Add(new VocabularyKey(nameof(ScheduleActorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ScheduleActorId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}