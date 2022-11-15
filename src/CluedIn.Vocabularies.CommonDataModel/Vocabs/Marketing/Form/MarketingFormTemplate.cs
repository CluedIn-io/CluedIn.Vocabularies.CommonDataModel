using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingFormTemplateVocabulary : SimpleVocabulary
    {
        public MarketingFormTemplateVocabulary()
        {
            VocabularyName = "Marketing Form Template";
            KeyPrefix = "commonDataModel.marketingformtemplate";
            KeySeparator = ".";
            Grouping = "/MarketingFormTemplate";

            AddGroup("MarketingFormTemplate Details", group =>
            {
                FormToSave = group.Add(new VocabularyKey(nameof(FormToSave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Entityupdatebehavioronsubmit = group.Add(new VocabularyKey(nameof(Entityupdatebehavioronsubmit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingFormTemplateId = group.Add(new VocabularyKey(nameof(MarketingFormTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormControlMapping = group.Add(new VocabularyKey(nameof(FormControlMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormFieldMapping = group.Add(new VocabularyKey(nameof(FormFieldMapping), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormDefinition = group.Add(new VocabularyKey(nameof(FormDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingProvided = group.Add(new VocabularyKey(nameof(MarketingProvided), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Validforpagetype = group.Add(new VocabularyKey(nameof(Validforpagetype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VisualStyle = group.Add(new VocabularyKey(nameof(VisualStyle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorMessage = group.Add(new VocabularyKey(nameof(ErrorMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RedirectURL = group.Add(new VocabularyKey(nameof(RedirectURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LimitExceededMessage = group.Add(new VocabularyKey(nameof(LimitExceededMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmationMessage = group.Add(new VocabularyKey(nameof(ConfirmationMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuccessImageURL = group.Add(new VocabularyKey(nameof(SuccessImageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorImageURL = group.Add(new VocabularyKey(nameof(ErrorImageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tag = group.Add(new VocabularyKey(nameof(Tag), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Label = group.Add(new VocabularyKey(nameof(Label), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FormToSave { get; private set; }
        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey Entityupdatebehavioronsubmit { get; private set; }
        public VocabularyKey MarketingFormTemplateId { get; private set; }
        public VocabularyKey FormControlMapping { get; private set; }
        public VocabularyKey FormFieldMapping { get; private set; }
        public VocabularyKey FormDefinition { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey MarketingProvided { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey Validforpagetype { get; private set; }
        public VocabularyKey VisualStyle { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey ErrorMessage { get; private set; }
        public VocabularyKey RedirectURL { get; private set; }
        public VocabularyKey LimitExceededMessage { get; private set; }
        public VocabularyKey ConfirmationMessage { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SuccessImageURL { get; private set; }
        public VocabularyKey ErrorImageURL { get; private set; }
        public VocabularyKey Tag { get; private set; }
        public VocabularyKey Label { get; private set; }
    }
}