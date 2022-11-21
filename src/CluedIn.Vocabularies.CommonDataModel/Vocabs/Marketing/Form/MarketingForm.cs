using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingFormVocabulary : SimpleVocabulary
    {
        public MarketingFormVocabulary()
        {
            VocabularyName = "Marketing Form";
            KeyPrefix = "commonDataModel.marketingform";
            KeySeparator = ".";
            Grouping = "/MarketingForm";

            AddGroup("MarketingForm Details", group =>
            {
                Info = group.Add(new VocabularyKey(nameof(Info), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowPrefill = group.Add(new VocabularyKey(nameof(AllowPrefill), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AlwaysGenerateLeads = group.Add(new VocabularyKey(nameof(AlwaysGenerateLeads), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Capturing = group.Add(new VocabularyKey(nameof(Capturing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapturingData = group.Add(new VocabularyKey(nameof(CapturingData), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapturingScanTime = group.Add(new VocabularyKey(nameof(CapturingScanTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CapturingConfigured = group.Add(new VocabularyKey(nameof(CapturingConfigured), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Entityupdatebehavioronsubmit = group.Add(new VocabularyKey(nameof(Entityupdatebehavioronsubmit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingFormId = group.Add(new VocabularyKey(nameof(MarketingFormId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormControlMapping = group.Add(new VocabularyKey(nameof(FormControlMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormFieldMapping = group.Add(new VocabularyKey(nameof(FormFieldMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormDefinition = group.Add(new VocabularyKey(nameof(FormDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormToSave = group.Add(new VocabularyKey(nameof(FormToSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidForPageType = group.Add(new VocabularyKey(nameof(ValidForPageType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VisualStyle = group.Add(new VocabularyKey(nameof(VisualStyle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalHostedFormInstructions = group.Add(new VocabularyKey(nameof(ExternalHostedFormInstructions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Organizationwhitelistdomain = group.Add(new VocabularyKey(nameof(Organizationwhitelistdomain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingProvided = group.Add(new VocabularyKey(nameof(MarketingProvided), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorMessage = group.Add(new VocabularyKey(nameof(ErrorMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RedirectURL = group.Add(new VocabularyKey(nameof(RedirectURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LimitExceededMessage = group.Add(new VocabularyKey(nameof(LimitExceededMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmationMessage = group.Add(new VocabularyKey(nameof(ConfirmationMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuccessImageURL = group.Add(new VocabularyKey(nameof(SuccessImageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorImageURL = group.Add(new VocabularyKey(nameof(ErrorImageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Keepsuccessfulsubmissions = group.Add(new VocabularyKey(nameof(Keepsuccessfulsubmissions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableDoubleOptIn = group.Add(new VocabularyKey(nameof(EnableDoubleOptIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Doubleoptinthankyouformat = group.Add(new VocabularyKey(nameof(Doubleoptinthankyouformat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Doubleoptinthankyouurl = group.Add(new VocabularyKey(nameof(Doubleoptinthankyouurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Info { get; private set; }
        public VocabularyKey AllowPrefill { get; private set; }
        public VocabularyKey AlwaysGenerateLeads { get; private set; }
        public VocabularyKey Capturing { get; private set; }
        public VocabularyKey CapturingData { get; private set; }
        public VocabularyKey CapturingScanTime { get; private set; }
        public VocabularyKey CapturingConfigured { get; private set; }
        public VocabularyKey Entityupdatebehavioronsubmit { get; private set; }
        public VocabularyKey MarketingFormId { get; private set; }
        public VocabularyKey FormControlMapping { get; private set; }
        public VocabularyKey FormFieldMapping { get; private set; }
        public VocabularyKey FormDefinition { get; private set; }
        public VocabularyKey FormToSave { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ValidForPageType { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey VisualStyle { get; private set; }
        public VocabularyKey ExternalHostedFormInstructions { get; private set; }
        public VocabularyKey Organizationwhitelistdomain { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey MarketingProvided { get; private set; }
        public VocabularyKey ErrorMessage { get; private set; }
        public VocabularyKey RedirectURL { get; private set; }
        public VocabularyKey LimitExceededMessage { get; private set; }
        public VocabularyKey ConfirmationMessage { get; private set; }
        public VocabularyKey SuccessImageURL { get; private set; }
        public VocabularyKey ErrorImageURL { get; private set; }
        public VocabularyKey Keepsuccessfulsubmissions { get; private set; }
        public VocabularyKey EnableDoubleOptIn { get; private set; }
        public VocabularyKey Doubleoptinthankyouformat { get; private set; }
        public VocabularyKey Doubleoptinthankyouurl { get; private set; }
    }
}