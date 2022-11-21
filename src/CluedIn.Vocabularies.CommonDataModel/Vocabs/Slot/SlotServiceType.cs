using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SlotServiceTypeVocabulary : SimpleVocabulary
    {
        public SlotServiceTypeVocabulary()
        {
            VocabularyName = "Slot Service Type";
            KeyPrefix = "commonDataModel.slotservicetype";
            KeySeparator = ".";
            Grouping = "/SlotServiceType";

            AddGroup("SlotServiceType Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SlotServiceTypeId = group.Add(new VocabularyKey(nameof(SlotServiceTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SlotServiceTypeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}