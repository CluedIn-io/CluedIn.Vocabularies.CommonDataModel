using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingFormVocabulary : SimpleVocabulary
    {
        public MarketingFormVocabulary()
        {
            VocabularyName = "MarketingForm";
            KeyPrefix = "commonDataModel.marketingform";
            KeySeparator = ".";
            Grouping = "/MarketingForm";

            AddGroup("MarketingForm Details", group =>
            {
                info = group.Add(new VocabularyKey(nameof(info), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                allowPrefill = group.Add(new VocabularyKey(nameof(allowPrefill), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                alwaysGenerateLeads = group.Add(new VocabularyKey(nameof(alwaysGenerateLeads), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                capturing = group.Add(new VocabularyKey(nameof(capturing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                capturingData = group.Add(new VocabularyKey(nameof(capturingData), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                capturingScanTime = group.Add(new VocabularyKey(nameof(capturingScanTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                capturingConfigured = group.Add(new VocabularyKey(nameof(capturingConfigured), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                entityupdatebehavioronsubmit = group.Add(new VocabularyKey(nameof(entityupdatebehavioronsubmit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                marketingFormId = group.Add(new VocabularyKey(nameof(marketingFormId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                formControlMapping = group.Add(new VocabularyKey(nameof(formControlMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                formFieldMapping = group.Add(new VocabularyKey(nameof(formFieldMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                formDefinition = group.Add(new VocabularyKey(nameof(formDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                formToSave = group.Add(new VocabularyKey(nameof(formToSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                insightsPlaceholder = group.Add(new VocabularyKey(nameof(insightsPlaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                validForPageType = group.Add(new VocabularyKey(nameof(validForPageType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                purpose = group.Add(new VocabularyKey(nameof(purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                visualStyle = group.Add(new VocabularyKey(nameof(visualStyle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                externalHostedFormInstructions = group.Add(new VocabularyKey(nameof(externalHostedFormInstructions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                organizationwhitelistdomain = group.Add(new VocabularyKey(nameof(organizationwhitelistdomain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                marketingProvided = group.Add(new VocabularyKey(nameof(marketingProvided), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                errorMessage = group.Add(new VocabularyKey(nameof(errorMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                redirectURL = group.Add(new VocabularyKey(nameof(redirectURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                limitExceededMessage = group.Add(new VocabularyKey(nameof(limitExceededMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                confirmationMessage = group.Add(new VocabularyKey(nameof(confirmationMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                successImageURL = group.Add(new VocabularyKey(nameof(successImageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                errorImageURL = group.Add(new VocabularyKey(nameof(errorImageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                keepsuccessfulsubmissions = group.Add(new VocabularyKey(nameof(keepsuccessfulsubmissions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                enableDoubleOptIn = group.Add(new VocabularyKey(nameof(enableDoubleOptIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                doubleoptinthankyouformat = group.Add(new VocabularyKey(nameof(doubleoptinthankyouformat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                doubleoptinthankyouurl = group.Add(new VocabularyKey(nameof(doubleoptinthankyouurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey info { get; private set; }
        public VocabularyKey allowPrefill { get; private set; }
        public VocabularyKey alwaysGenerateLeads { get; private set; }
        public VocabularyKey capturing { get; private set; }
        public VocabularyKey capturingData { get; private set; }
        public VocabularyKey capturingScanTime { get; private set; }
        public VocabularyKey capturingConfigured { get; private set; }
        public VocabularyKey entityupdatebehavioronsubmit { get; private set; }
        public VocabularyKey marketingFormId { get; private set; }
        public VocabularyKey formControlMapping { get; private set; }
        public VocabularyKey formFieldMapping { get; private set; }
        public VocabularyKey formDefinition { get; private set; }
        public VocabularyKey formToSave { get; private set; }
        public VocabularyKey insightsPlaceholder { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey validForPageType { get; private set; }
        public VocabularyKey purpose { get; private set; }
        public VocabularyKey visualStyle { get; private set; }
        public VocabularyKey externalHostedFormInstructions { get; private set; }
        public VocabularyKey organizationwhitelistdomain { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey marketingProvided { get; private set; }
        public VocabularyKey errorMessage { get; private set; }
        public VocabularyKey redirectURL { get; private set; }
        public VocabularyKey limitExceededMessage { get; private set; }
        public VocabularyKey confirmationMessage { get; private set; }
        public VocabularyKey successImageURL { get; private set; }
        public VocabularyKey errorImageURL { get; private set; }
        public VocabularyKey keepsuccessfulsubmissions { get; private set; }
        public VocabularyKey enableDoubleOptIn { get; private set; }
        public VocabularyKey doubleoptinthankyouformat { get; private set; }
        public VocabularyKey doubleoptinthankyouurl { get; private set; }


    }
}