using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SlotVocabulary : SimpleVocabulary
    {
        public SlotVocabulary()
        {
            VocabularyName = "Slot";
            KeyPrefix = "commonDataModel.slot";
            KeySeparator = ".";
            Grouping = "/Slot";

            AddGroup("Slot Details", group =>
            {
                AppointmentTypeNew = group.Add(new VocabularyKey(nameof(AppointmentTypeNew), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comment = group.Add(new VocabularyKey(nameof(Comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                End = group.Add(new VocabularyKey(nameof(End), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Overbooked = group.Add(new VocabularyKey(nameof(Overbooked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SlotId = group.Add(new VocabularyKey(nameof(SlotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Start = group.Add(new VocabularyKey(nameof(Start), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AppointmentTypeNew { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey End { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Overbooked { get; private set; }
        public VocabularyKey SlotId { get; private set; }
        public VocabularyKey Start { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}