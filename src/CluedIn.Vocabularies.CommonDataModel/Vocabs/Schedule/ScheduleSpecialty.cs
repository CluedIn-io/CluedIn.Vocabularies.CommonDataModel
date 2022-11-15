using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ScheduleSpecialtyVocabulary : SimpleVocabulary
    {
        public ScheduleSpecialtyVocabulary()
        {
            VocabularyName = "Schedule Specialty";
            KeyPrefix = "commonDataModel.schedulespecialty";
            KeySeparator = ".";
            Grouping = "/ScheduleSpecialty";

            AddGroup("ScheduleSpecialty Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduleSpecialtyId = group.Add(new VocabularyKey(nameof(ScheduleSpecialtyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ScheduleSpecialtyId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}