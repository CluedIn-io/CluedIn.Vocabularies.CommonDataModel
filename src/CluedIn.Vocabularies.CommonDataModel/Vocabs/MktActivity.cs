using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MktActivityVocabulary : SimpleVocabulary
    {
        public MktActivityVocabulary()
        {
            VocabularyName = "Mkt Activity";
            KeyPrefix = "commonDataModel.mktactivity";
            KeySeparator = ".";
            Grouping = "/MktActivity";

            AddGroup("MktActivity Details", group =>
            {
                ActionStatus = group.Add(new VocabularyKey(nameof(ActionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Activityadditionalparams = group.Add(new VocabularyKey(nameof(Activityadditionalparams), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityToken = group.Add(new VocabularyKey(nameof(ActivityToken), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualDurationMinutes = group.Add(new VocabularyKey(nameof(ActualDurationMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualEnd = group.Add(new VocabularyKey(nameof(ActualEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualStart = group.Add(new VocabularyKey(nameof(ActualStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Durationmillisecond = group.Add(new VocabularyKey(nameof(Durationmillisecond), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorMessage = group.Add(new VocabularyKey(nameof(ErrorMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBilled = group.Add(new VocabularyKey(nameof(IsBilled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Ismapiprivate = group.Add(new VocabularyKey(nameof(Ismapiprivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRegularActivity = group.Add(new VocabularyKey(nameof(IsRegularActivity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Isworkflowcreated = group.Add(new VocabularyKey(nameof(Isworkflowcreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MktactivityId = group.Add(new VocabularyKey(nameof(MktactivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ActionStatus { get; private set; }
        public VocabularyKey Activityadditionalparams { get; private set; }
        public VocabularyKey ActivityToken { get; private set; }
        public VocabularyKey ActualDurationMinutes { get; private set; }
        public VocabularyKey ActualEnd { get; private set; }
        public VocabularyKey ActualStart { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Durationmillisecond { get; private set; }
        public VocabularyKey ErrorMessage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey IsBilled { get; private set; }
        public VocabularyKey Ismapiprivate { get; private set; }
        public VocabularyKey IsRegularActivity { get; private set; }
        public VocabularyKey Isworkflowcreated { get; private set; }
        public VocabularyKey MktactivityId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}