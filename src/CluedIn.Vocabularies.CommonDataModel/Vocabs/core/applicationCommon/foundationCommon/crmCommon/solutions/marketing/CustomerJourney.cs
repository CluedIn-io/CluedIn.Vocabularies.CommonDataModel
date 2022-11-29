using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Marketing
{
    public class CustomerJourneyVocabulary : SimpleVocabulary
    {
        public CustomerJourneyVocabulary()
        {
            VocabularyName = "Customer Journey";
            KeyPrefix = "commonDataModel.customerjourney.marketing";
            KeySeparator = ".";
            Grouping = "/CustomerJourney";

            AddGroup("CustomerJourney Details for Marketing", group =>
            {
			    CustomerJourneyId = group.Add(new VocabularyKey(nameof(CustomerJourneyId), "Customer journey", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerJourneyDesignerState = group.Add(new VocabularyKey(nameof(CustomerJourneyDesignerState), "Customer journey designer state", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerJourneyTemplate = group.Add(new VocabularyKey(nameof(CustomerJourneyTemplate), "Customer journey template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerJourneyTimeZone = group.Add(new VocabularyKey(nameof(CustomerJourneyTimeZone), "Time zone", VocabularyKeyDataType.TimeZone, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDateTime = group.Add(new VocabularyKey(nameof(EndDateTime), "End date and time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), "Insights", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsRecurring = group.Add(new VocabularyKey(nameof(IsRecurring), "Is recurring", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    PublishedBy = group.Add(new VocabularyKey(nameof(PublishedBy), "Published by", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Purpose = group.Add(new VocabularyKey(nameof(Purpose), "Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecurrenceCount = group.Add(new VocabularyKey(nameof(RecurrenceCount), "Recurrence count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RecurrenceIntervalDays = group.Add(new VocabularyKey(nameof(RecurrenceIntervalDays), "Recurrence interval (days)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), "Start date and time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidationResults = group.Add(new VocabularyKey(nameof(ValidationResults), "Error check results", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkflowDefinition = group.Add(new VocabularyKey(nameof(WorkflowDefinition), "Workflow definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CustomerJourneyId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CustomerJourneyDesignerState { get; private set; }
        public VocabularyKey CustomerJourneyTemplate { get; private set; }
        public VocabularyKey CustomerJourneyTimeZone { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDateTime { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey IsRecurring { get; private set; }
        public VocabularyKey PublishedBy { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey RecurrenceCount { get; private set; }
        public VocabularyKey RecurrenceIntervalDays { get; private set; }
        public VocabularyKey StartDateTime { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey ValidationResults { get; private set; }
        public VocabularyKey WorkflowDefinition { get; private set; }
    }
}