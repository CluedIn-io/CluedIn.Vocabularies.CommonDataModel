using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class FeedbackVocabulary : SimpleVocabulary
    {
        public FeedbackVocabulary()
        {
            VocabularyName = "Feedback";
            KeyPrefix = "commonDataModel.feedback.portals";
            KeySeparator = ".";
            Grouping = "/Feedback";

            AddGroup("Feedback Details for Portals", group =>
            {
			    PublishedToWeb = group.Add(new VocabularyKey(nameof(PublishedToWeb), "Published To Web", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AuthorURL = group.Add(new VocabularyKey(nameof(AuthorURL), "Author URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    AdxContactEmail = group.Add(new VocabularyKey(nameof(AdxContactEmail), "Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    AdxContactUsername = group.Add(new VocabularyKey(nameof(AdxContactUsername), "Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByContact = group.Add(new VocabularyKey(nameof(AdxCreatedByContact), "Created By Name (Contact)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey PublishedToWeb { get; private set; }
        public VocabularyKey AuthorURL { get; private set; }
        public VocabularyKey AdxContactEmail { get; private set; }
        public VocabularyKey AdxContactUsername { get; private set; }
        public VocabularyKey AdxCreatedByContact { get; private set; }
    }
}