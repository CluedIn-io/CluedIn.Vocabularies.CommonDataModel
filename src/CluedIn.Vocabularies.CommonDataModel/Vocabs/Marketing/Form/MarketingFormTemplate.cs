using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingFormTemplateVocabulary : SimpleVocabulary
    {
        public MarketingFormTemplateVocabulary()
        {
            VocabularyName = "MarketingFormTemplate";
            KeyPrefix = "commonDataModel.marketingformtemplate";
            KeySeparator = ".";
            Grouping = "/MarketingFormTemplate";

            AddGroup("MarketingFormTemplate Details", group =>
            {
                formToSave = group.Add(new VocabularyKey(nameof(formToSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                entityImage = group.Add(new VocabularyKey(nameof(entityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                entityupdatebehavioronsubmit = group.Add(new VocabularyKey(nameof(entityupdatebehavioronsubmit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                marketingFormTemplateId = group.Add(new VocabularyKey(nameof(marketingFormTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                formControlMapping = group.Add(new VocabularyKey(nameof(formControlMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                formFieldMapping = group.Add(new VocabularyKey(nameof(formFieldMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                formDefinition = group.Add(new VocabularyKey(nameof(formDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                language = group.Add(new VocabularyKey(nameof(language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                marketingProvided = group.Add(new VocabularyKey(nameof(marketingProvided), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                purpose = group.Add(new VocabularyKey(nameof(purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                validforpagetype = group.Add(new VocabularyKey(nameof(validforpagetype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                visualStyle = group.Add(new VocabularyKey(nameof(visualStyle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                errorMessage = group.Add(new VocabularyKey(nameof(errorMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                redirectURL = group.Add(new VocabularyKey(nameof(redirectURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                limitExceededMessage = group.Add(new VocabularyKey(nameof(limitExceededMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                confirmationMessage = group.Add(new VocabularyKey(nameof(confirmationMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                successImageURL = group.Add(new VocabularyKey(nameof(successImageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                errorImageURL = group.Add(new VocabularyKey(nameof(errorImageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                tag = group.Add(new VocabularyKey(nameof(tag), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                label = group.Add(new VocabularyKey(nameof(label), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey formToSave { get; private set; }
        public VocabularyKey entityImage { get; private set; }
        public VocabularyKey entityupdatebehavioronsubmit { get; private set; }
        public VocabularyKey marketingFormTemplateId { get; private set; }
        public VocabularyKey formControlMapping { get; private set; }
        public VocabularyKey formFieldMapping { get; private set; }
        public VocabularyKey formDefinition { get; private set; }
        public VocabularyKey language { get; private set; }
        public VocabularyKey marketingProvided { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey purpose { get; private set; }
        public VocabularyKey validforpagetype { get; private set; }
        public VocabularyKey visualStyle { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey errorMessage { get; private set; }
        public VocabularyKey redirectURL { get; private set; }
        public VocabularyKey limitExceededMessage { get; private set; }
        public VocabularyKey confirmationMessage { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey successImageURL { get; private set; }
        public VocabularyKey errorImageURL { get; private set; }
        public VocabularyKey tag { get; private set; }
        public VocabularyKey label { get; private set; }


    }
}