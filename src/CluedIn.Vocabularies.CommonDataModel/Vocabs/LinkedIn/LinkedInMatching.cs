using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInMatchingVocabulary : SimpleVocabulary
    {
        public LinkedInMatchingVocabulary()
        {
            VocabularyName = "Linked In Matching";
            KeyPrefix = "commonDataModel.linkedinmatching";
            KeySeparator = ".";
            Grouping = "/LinkedInMatching";

            AddGroup("LinkedInMatching Details", group =>
            {
                Activated = group.Add(new VocabularyKey(nameof(Activated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlwaysCreateLead = group.Add(new VocabularyKey(nameof(AlwaysCreateLead), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableContactCreation = group.Add(new VocabularyKey(nameof(EnableContactCreation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedinleadmatchingstrategyId = group.Add(new VocabularyKey(nameof(LinkedinleadmatchingstrategyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Activated { get; private set; }
        public VocabularyKey AlwaysCreateLead { get; private set; }
        public VocabularyKey EnableContactCreation { get; private set; }
        public VocabularyKey LinkedinleadmatchingstrategyId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}