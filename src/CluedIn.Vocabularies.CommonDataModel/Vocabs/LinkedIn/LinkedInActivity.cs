using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInActivityVocabulary : SimpleVocabulary
    {
        public LinkedInActivityVocabulary()
        {
            VocabularyName = "Common Data Model LinkedInActivity";
            KeyPrefix = "commonDataModel.linkedinactivity";
            KeySeparator = ".";
            Grouping = "/LinkedInActivity";

            AddGroup("Common Data Model LinkedInActivity Details", group =>
            {
                actionStatus = group.Add(new VocabularyKey(nameof(actionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                activityadditionalparams = group.Add(new VocabularyKey(nameof(activityadditionalparams), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                actualdurationminutes = group.Add(new VocabularyKey(nameof(actualdurationminutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                actualEnd = group.Add(new VocabularyKey(nameof(actualEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                actualStart = group.Add(new VocabularyKey(nameof(actualStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                durationmillisecond = group.Add(new VocabularyKey(nameof(durationmillisecond), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                errorMessage = group.Add(new VocabularyKey(nameof(errorMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedInActivityId = group.Add(new VocabularyKey(nameof(linkedInActivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey actionStatus { get; private set; }
        public VocabularyKey activityadditionalparams { get; private set; }
        public VocabularyKey actualdurationminutes { get; private set; }
        public VocabularyKey actualEnd { get; private set; }
        public VocabularyKey actualStart { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey durationmillisecond { get; private set; }
        public VocabularyKey errorMessage { get; private set; }
        public VocabularyKey linkedInActivityId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}