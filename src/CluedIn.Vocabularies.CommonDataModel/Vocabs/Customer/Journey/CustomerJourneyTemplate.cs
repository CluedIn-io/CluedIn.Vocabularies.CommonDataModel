using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerJourneyTemplateVocabulary : SimpleVocabulary
    {
        public CustomerJourneyTemplateVocabulary()
        {
            VocabularyName = "Customer Journey Template";
            KeyPrefix = "commonDataModel.customerjourneytemplate";
            KeySeparator = ".";
            Grouping = "/CustomerJourneyTemplate";

            AddGroup("CustomerJourneyTemplate Details", group =>
            {
                FormToSave = group.Add(new VocabularyKey(nameof(FormToSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerJourneyDesignerState = group.Add(new VocabularyKey(nameof(CustomerJourneyDesignerState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerJourneyID = group.Add(new VocabularyKey(nameof(CustomerJourneyID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerJourneyTemplateId = group.Add(new VocabularyKey(nameof(CustomerJourneyTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Entitytarget = group.Add(new VocabularyKey(nameof(Entitytarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRecurring = group.Add(new VocabularyKey(nameof(IsRecurring), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Purposeoption = group.Add(new VocabularyKey(nameof(Purposeoption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecurrenceCount = group.Add(new VocabularyKey(nameof(RecurrenceCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecurrenceIntervalDays = group.Add(new VocabularyKey(nameof(RecurrenceIntervalDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Validationresults = group.Add(new VocabularyKey(nameof(Validationresults), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkflowDefinition = group.Add(new VocabularyKey(nameof(WorkflowDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tag = group.Add(new VocabularyKey(nameof(Tag), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Label = group.Add(new VocabularyKey(nameof(Label), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FormToSave { get; private set; }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey CustomerJourneyDesignerState { get; private set; }
        public VocabularyKey CustomerJourneyID { get; private set; }
        public VocabularyKey CustomerJourneyTemplateId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Entitytarget { get; private set; }
        public VocabularyKey IsRecurring { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Purposeoption { get; private set; }
        public VocabularyKey RecurrenceCount { get; private set; }
        public VocabularyKey RecurrenceIntervalDays { get; private set; }
        public VocabularyKey Validationresults { get; private set; }
        public VocabularyKey WorkflowDefinition { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Tag { get; private set; }
        public VocabularyKey Label { get; private set; }
    }
}