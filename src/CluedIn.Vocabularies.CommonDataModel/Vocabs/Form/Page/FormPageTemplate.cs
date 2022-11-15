using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FormPageTemplateVocabulary : SimpleVocabulary
    {
        public FormPageTemplateVocabulary()
        {
            VocabularyName = "Form Page Template";
            KeyPrefix = "commonDataModel.formpagetemplate";
            KeySeparator = ".";
            Grouping = "/FormPageTemplate";

            AddGroup("FormPageTemplate Details", group =>
            {
                ConfirmationMessage = group.Add(new VocabularyKey(nameof(ConfirmationMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorMessage = group.Add(new VocabularyKey(nameof(ErrorMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormPageTemplateId = group.Add(new VocabularyKey(nameof(FormPageTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LimitExceededMessage = group.Add(new VocabularyKey(nameof(LimitExceededMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RedirectURL = group.Add(new VocabularyKey(nameof(RedirectURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuccessImageURL = group.Add(new VocabularyKey(nameof(SuccessImageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorImageURL = group.Add(new VocabularyKey(nameof(ErrorImageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ConfirmationMessage { get; private set; }
        public VocabularyKey ErrorMessage { get; private set; }
        public VocabularyKey FormPageTemplateId { get; private set; }
        public VocabularyKey LimitExceededMessage { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RedirectURL { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SuccessImageURL { get; private set; }
        public VocabularyKey ErrorImageURL { get; private set; }
    }
}