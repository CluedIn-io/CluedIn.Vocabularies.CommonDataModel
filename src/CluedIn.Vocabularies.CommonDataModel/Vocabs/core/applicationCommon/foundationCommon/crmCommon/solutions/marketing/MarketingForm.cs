using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Marketing
{
    public class MarketingFormVocabulary : SimpleVocabulary
    {
        public MarketingFormVocabulary()
        {
            VocabularyName = "Marketing Form";
            KeyPrefix = "commonDataModel.marketingform.marketing";
            KeySeparator = ".";
            Grouping = "/MarketingForm";

            AddGroup("MarketingForm Details for Marketing", group =>
            {
			    MarketingFormId = group.Add(new VocabularyKey(nameof(MarketingFormId), "Marketing form", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllowPrefill = group.Add(new VocabularyKey(nameof(AllowPrefill), "Prefill fields", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ContactMatchingStrategy = group.Add(new VocabularyKey(nameof(ContactMatchingStrategy), "Contact matching strategy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UpdateContactsLeads = group.Add(new VocabularyKey(nameof(UpdateContactsLeads), "Update contacts/leads", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MarketingFormTemplate = group.Add(new VocabularyKey(nameof(MarketingFormTemplate), "Marketing form template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FormControlMapping = group.Add(new VocabularyKey(nameof(FormControlMapping), "Form control mapping", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FormDefinition = group.Add(new VocabularyKey(nameof(FormDefinition), "Form definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), "Insights", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LeadMatchingStrategy = group.Add(new VocabularyKey(nameof(LeadMatchingStrategy), "Lead matching strategy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidForPageType = group.Add(new VocabularyKey(nameof(ValidForPageType), "Form type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Purpose = group.Add(new VocabularyKey(nameof(Purpose), "Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VisualStyle = group.Add(new VocabularyKey(nameof(VisualStyle), "Visual style", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MarketingFormId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AllowPrefill { get; private set; }
        public VocabularyKey ContactMatchingStrategy { get; private set; }
        public VocabularyKey UpdateContactsLeads { get; private set; }
        public VocabularyKey MarketingFormTemplate { get; private set; }
        public VocabularyKey FormControlMapping { get; private set; }
        public VocabularyKey FormDefinition { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey LeadMatchingStrategy { get; private set; }
        public VocabularyKey ValidForPageType { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey VisualStyle { get; private set; }
    }
}