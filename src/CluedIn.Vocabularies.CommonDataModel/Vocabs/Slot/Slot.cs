using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SlotVocabulary : SimpleVocabulary
    {
        public SlotVocabulary()
        {
            VocabularyName = "Common Data Model Slot";
            KeyPrefix = "commonDataModel.slot";
            KeySeparator = ".";
            Grouping = "/Slot";

            AddGroup("Common Data Model Slot Details", group =>
            {
                appointmentTypeNew = group.Add(new VocabularyKey(nameof(appointmentTypeNew), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                comment = group.Add(new VocabularyKey(nameof(comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                end = group.Add(new VocabularyKey(nameof(end), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overbooked = group.Add(new VocabularyKey(nameof(overbooked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                slotId = group.Add(new VocabularyKey(nameof(slotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                start = group.Add(new VocabularyKey(nameof(start), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                status = group.Add(new VocabularyKey(nameof(status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey appointmentTypeNew { get; private set; }
        public VocabularyKey comment { get; private set; }
        public VocabularyKey end { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey overbooked { get; private set; }
        public VocabularyKey slotId { get; private set; }
        public VocabularyKey start { get; private set; }
        public VocabularyKey status { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}