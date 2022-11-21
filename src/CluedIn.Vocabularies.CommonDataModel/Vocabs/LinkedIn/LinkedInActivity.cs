using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInActivityVocabulary : SimpleVocabulary
    {
        public LinkedInActivityVocabulary()
        {
            VocabularyName = "Linked In Activity";
            KeyPrefix = "commonDataModel.linkedinactivity";
            KeySeparator = ".";
            Grouping = "/LinkedInActivity";

            AddGroup("LinkedInActivity Details", group =>
            {
                ActionStatus = group.Add(new VocabularyKey(nameof(ActionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Activityadditionalparams = group.Add(new VocabularyKey(nameof(Activityadditionalparams), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Actualdurationminutes = group.Add(new VocabularyKey(nameof(Actualdurationminutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualEnd = group.Add(new VocabularyKey(nameof(ActualEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualStart = group.Add(new VocabularyKey(nameof(ActualStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Durationmillisecond = group.Add(new VocabularyKey(nameof(Durationmillisecond), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorMessage = group.Add(new VocabularyKey(nameof(ErrorMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInActivityId = group.Add(new VocabularyKey(nameof(LinkedInActivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ActionStatus { get; private set; }
        public VocabularyKey Activityadditionalparams { get; private set; }
        public VocabularyKey Actualdurationminutes { get; private set; }
        public VocabularyKey ActualEnd { get; private set; }
        public VocabularyKey ActualStart { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Durationmillisecond { get; private set; }
        public VocabularyKey ErrorMessage { get; private set; }
        public VocabularyKey LinkedInActivityId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}