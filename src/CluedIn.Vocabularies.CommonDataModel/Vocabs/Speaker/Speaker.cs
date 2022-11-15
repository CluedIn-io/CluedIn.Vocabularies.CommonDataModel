using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SpeakerVocabulary : SimpleVocabulary
    {
        public SpeakerVocabulary()
        {
            VocabularyName = "Speaker";
            KeyPrefix = "commonDataModel.speaker";
            KeySeparator = ".";
            Grouping = "/Speaker";

            AddGroup("Metadata", group =>
            {
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                About = group.Add(new VocabularyKey(nameof(About), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Accomplishments = group.Add(new VocabularyKey(nameof(Accomplishments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Blog = group.Add(new VocabularyKey(nameof(Blog), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedIn = group.Add(new VocabularyKey(nameof(LinkedIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Publications = group.Add(new VocabularyKey(nameof(Publications), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpeakerCost = group.Add(new VocabularyKey(nameof(SpeakerCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpeakerCostBase = group.Add(new VocabularyKey(nameof(SpeakerCostBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpeakerId = group.Add(new VocabularyKey(nameof(SpeakerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Title = group.Add(new VocabularyKey(nameof(Title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Twitter = group.Add(new VocabularyKey(nameof(Twitter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Website = group.Add(new VocabularyKey(nameof(Website), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessID = group.Add(new VocabularyKey(nameof(ProcessID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StageID = group.Add(new VocabularyKey(nameof(StageID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey About { get; private set; }
        public VocabularyKey Accomplishments { get; private set; }
        public VocabularyKey Blog { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey LinkedIn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Publications { get; private set; }
        public VocabularyKey SpeakerCost { get; private set; }
        public VocabularyKey SpeakerCostBase { get; private set; }
        public VocabularyKey SpeakerId { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey Twitter { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey Website { get; private set; }
        public VocabularyKey ProcessID { get; private set; }
        public VocabularyKey StageID { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
    }
}