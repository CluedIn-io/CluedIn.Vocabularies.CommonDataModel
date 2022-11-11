using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInMatchingVocabulary : SimpleVocabulary
    {
        public LinkedInMatchingVocabulary()
        {
            VocabularyName = "LinkedInMatching";
            KeyPrefix = "commonDataModel.linkedinmatching";
            KeySeparator = ".";
            Grouping = "/LinkedInMatching";

            AddGroup("LinkedInMatching Details", group =>
            {
                activated = group.Add(new VocabularyKey(nameof(activated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                alwaysCreateLead = group.Add(new VocabularyKey(nameof(alwaysCreateLead), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                enableContactCreation = group.Add(new VocabularyKey(nameof(enableContactCreation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedinleadmatchingstrategyId = group.Add(new VocabularyKey(nameof(linkedinleadmatchingstrategyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey activated { get; private set; }
        public VocabularyKey alwaysCreateLead { get; private set; }
        public VocabularyKey enableContactCreation { get; private set; }
        public VocabularyKey linkedinleadmatchingstrategyId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}