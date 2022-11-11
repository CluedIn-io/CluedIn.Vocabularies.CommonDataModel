using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaskActivityMarketingTemplateVocabulary : SimpleVocabulary
    {
        public TaskActivityMarketingTemplateVocabulary()
        {
            VocabularyName = "TaskActivityMarketingTemplate";
            KeyPrefix = "commonDataModel.taskactivitymarketingtemplate";
            KeySeparator = ".";
            Grouping = "/TaskActivityMarketingTemplate";

            AddGroup("TaskActivityMarketingTemplate Details", group =>
            {
                scheduleddurationminutes = group.Add(new VocabularyKey(nameof(scheduleddurationminutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                prioritycode = group.Add(new VocabularyKey(nameof(prioritycode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                scheduleType = group.Add(new VocabularyKey(nameof(scheduleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                startDate = group.Add(new VocabularyKey(nameof(startDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                startDelay = group.Add(new VocabularyKey(nameof(startDelay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                startTimeHour = group.Add(new VocabularyKey(nameof(startTimeHour), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                startTimeMinute = group.Add(new VocabularyKey(nameof(startTimeMinute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                subject = group.Add(new VocabularyKey(nameof(subject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                taskActivityMarketingTemplateId = group.Add(new VocabularyKey(nameof(taskActivityMarketingTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey scheduleddurationminutes { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey prioritycode { get; private set; }
        public VocabularyKey scheduleType { get; private set; }
        public VocabularyKey startDate { get; private set; }
        public VocabularyKey startDelay { get; private set; }
        public VocabularyKey startTimeHour { get; private set; }
        public VocabularyKey startTimeMinute { get; private set; }
        public VocabularyKey subject { get; private set; }
        public VocabularyKey taskActivityMarketingTemplateId { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}