using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PhoneCallActivityMarketingTemplateVocabulary : SimpleVocabulary
    {
        public PhoneCallActivityMarketingTemplateVocabulary()
        {
            VocabularyName = "Phone Call Activity Marketing Template";
            KeyPrefix = "commonDataModel.phonecallactivitymarketingtemplate";
            KeySeparator = ".";
            Grouping = "/PhoneCallActivityMarketingTemplate";

            AddGroup("PhoneCallActivityMarketingTemplate Details", group =>
            {
                Scheduleddurationminutes = group.Add(new VocabularyKey(nameof(Scheduleddurationminutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhoneCallActivityMarketingTemplateId = group.Add(new VocabularyKey(nameof(PhoneCallActivityMarketingTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Prioritycode = group.Add(new VocabularyKey(nameof(Prioritycode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduleType = group.Add(new VocabularyKey(nameof(ScheduleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDelay = group.Add(new VocabularyKey(nameof(StartDelay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartTimeHour = group.Add(new VocabularyKey(nameof(StartTimeHour), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartTimeMinute = group.Add(new VocabularyKey(nameof(StartTimeMinute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Subject = group.Add(new VocabularyKey(nameof(Subject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Scheduleddurationminutes { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PhoneCallActivityMarketingTemplateId { get; private set; }
        public VocabularyKey Prioritycode { get; private set; }
        public VocabularyKey ScheduleType { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StartDelay { get; private set; }
        public VocabularyKey StartTimeHour { get; private set; }
        public VocabularyKey StartTimeMinute { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}