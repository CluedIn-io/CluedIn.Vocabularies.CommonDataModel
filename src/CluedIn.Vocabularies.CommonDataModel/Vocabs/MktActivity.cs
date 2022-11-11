using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MktActivityVocabulary : SimpleVocabulary
    {
        public MktActivityVocabulary()
        {
            VocabularyName = "Common Data Model MktActivity";
            KeyPrefix = "commonDataModel.mktactivity";
            KeySeparator = ".";
            Grouping = "/MktActivity";

            AddGroup("Common Data Model MktActivity Details", group =>
            {
                actionStatus = group.Add(new VocabularyKey(nameof(actionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                activityadditionalparams = group.Add(new VocabularyKey(nameof(activityadditionalparams), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                activityToken = group.Add(new VocabularyKey(nameof(activityToken), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                actualDurationMinutes = group.Add(new VocabularyKey(nameof(actualDurationMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                actualEnd = group.Add(new VocabularyKey(nameof(actualEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                actualStart = group.Add(new VocabularyKey(nameof(actualStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                durationmillisecond = group.Add(new VocabularyKey(nameof(durationmillisecond), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                errorMessage = group.Add(new VocabularyKey(nameof(errorMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                exchangeRate = group.Add(new VocabularyKey(nameof(exchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isBilled = group.Add(new VocabularyKey(nameof(isBilled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ismapiprivate = group.Add(new VocabularyKey(nameof(ismapiprivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isRegularActivity = group.Add(new VocabularyKey(nameof(isRegularActivity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isworkflowcreated = group.Add(new VocabularyKey(nameof(isworkflowcreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                mktactivityId = group.Add(new VocabularyKey(nameof(mktactivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey actionStatus { get; private set; }
        public VocabularyKey activityadditionalparams { get; private set; }
        public VocabularyKey activityToken { get; private set; }
        public VocabularyKey actualDurationMinutes { get; private set; }
        public VocabularyKey actualEnd { get; private set; }
        public VocabularyKey actualStart { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey durationmillisecond { get; private set; }
        public VocabularyKey errorMessage { get; private set; }
        public VocabularyKey exchangeRate { get; private set; }
        public VocabularyKey isBilled { get; private set; }
        public VocabularyKey ismapiprivate { get; private set; }
        public VocabularyKey isRegularActivity { get; private set; }
        public VocabularyKey isworkflowcreated { get; private set; }
        public VocabularyKey mktactivityId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}