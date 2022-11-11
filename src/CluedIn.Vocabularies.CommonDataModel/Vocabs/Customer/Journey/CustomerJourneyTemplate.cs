using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerJourneyTemplateVocabulary : SimpleVocabulary
    {
        public CustomerJourneyTemplateVocabulary()
        {
            VocabularyName = "Common Data Model CustomerJourneyTemplate";
            KeyPrefix = "commonDataModel.customerjourneytemplate";
            KeySeparator = ".";
            Grouping = "/CustomerJourneyTemplate";

            AddGroup("Common Data Model CustomerJourneyTemplate Details", group =>
            {
                formToSave = group.Add(new VocabularyKey(nameof(formToSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                entityImage = group.Add(new VocabularyKey(nameof(entityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                customerJourneyDesignerState = group.Add(new VocabularyKey(nameof(customerJourneyDesignerState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                customerJourneyID = group.Add(new VocabularyKey(nameof(customerJourneyID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                customerJourneyTemplateId = group.Add(new VocabularyKey(nameof(customerJourneyTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                entitytarget = group.Add(new VocabularyKey(nameof(entitytarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isRecurring = group.Add(new VocabularyKey(nameof(isRecurring), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                language = group.Add(new VocabularyKey(nameof(language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                purposeoption = group.Add(new VocabularyKey(nameof(purposeoption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                recurrenceCount = group.Add(new VocabularyKey(nameof(recurrenceCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                recurrenceIntervalDays = group.Add(new VocabularyKey(nameof(recurrenceIntervalDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                validationresults = group.Add(new VocabularyKey(nameof(validationresults), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                workflowDefinition = group.Add(new VocabularyKey(nameof(workflowDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                tag = group.Add(new VocabularyKey(nameof(tag), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                label = group.Add(new VocabularyKey(nameof(label), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey formToSave { get; private set; }
        public VocabularyKey entityImage { get; private set; }
        public VocabularyKey customerJourneyDesignerState { get; private set; }
        public VocabularyKey customerJourneyID { get; private set; }
        public VocabularyKey customerJourneyTemplateId { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey entitytarget { get; private set; }
        public VocabularyKey isRecurring { get; private set; }
        public VocabularyKey language { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey purposeoption { get; private set; }
        public VocabularyKey recurrenceCount { get; private set; }
        public VocabularyKey recurrenceIntervalDays { get; private set; }
        public VocabularyKey validationresults { get; private set; }
        public VocabularyKey workflowDefinition { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey tag { get; private set; }
        public VocabularyKey label { get; private set; }


    }
}