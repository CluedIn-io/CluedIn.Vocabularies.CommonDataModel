using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SlotSpecialtyVocabulary : SimpleVocabulary
    {
        public SlotSpecialtyVocabulary()
        {
            VocabularyName = "Slot Specialty";
            KeyPrefix = "commonDataModel.slotspecialty";
            KeySeparator = ".";
            Grouping = "/SlotSpecialty";

            AddGroup("SlotSpecialty Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SlotSpecialtyId = group.Add(new VocabularyKey(nameof(SlotSpecialtyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SlotSpecialtyId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}