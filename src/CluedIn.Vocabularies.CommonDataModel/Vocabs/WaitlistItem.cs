using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WaitlistItemVocabulary : SimpleVocabulary
    {
        public WaitlistItemVocabulary()
        {
            VocabularyName = "Waitlist Item";
            KeyPrefix = "commonDataModel.waitlistitem";
            KeySeparator = ".";
            Grouping = "/WaitlistItem";

            AddGroup("WaitlistItem Details", group =>
            {
                Autoregister = group.Add(new VocabularyKey(nameof(Autoregister), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invited = group.Add(new VocabularyKey(nameof(Invited), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reserved = group.Add(new VocabularyKey(nameof(Reserved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WaitlistItemId = group.Add(new VocabularyKey(nameof(WaitlistItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Autoregister { get; private set; }
        public VocabularyKey Invited { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Reserved { get; private set; }
        public VocabularyKey WaitlistItemId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}