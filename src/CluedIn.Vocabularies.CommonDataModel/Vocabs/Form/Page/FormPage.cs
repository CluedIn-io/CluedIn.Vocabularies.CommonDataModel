using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FormPageVocabulary : SimpleVocabulary
    {
        public FormPageVocabulary()
        {
            VocabularyName = "Form Page";
            KeyPrefix = "commonDataModel.formpage";
            KeySeparator = ".";
            Grouping = "/FormPage";

            AddGroup("FormPage Details", group =>
            {
                ConfirmationMessage = group.Add(new VocabularyKey(nameof(ConfirmationMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorMessage = group.Add(new VocabularyKey(nameof(ErrorMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormPageId = group.Add(new VocabularyKey(nameof(FormPageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LimitExceededMessage = group.Add(new VocabularyKey(nameof(LimitExceededMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebSiteId = group.Add(new VocabularyKey(nameof(WebSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RedirectURL = group.Add(new VocabularyKey(nameof(RedirectURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JavaScriptCode = group.Add(new VocabularyKey(nameof(JavaScriptCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalformhostingIframe = group.Add(new VocabularyKey(nameof(ExternalformhostingIframe), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalHostingFormatDescription = group.Add(new VocabularyKey(nameof(ExternalHostingFormatDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalHostingFormat = group.Add(new VocabularyKey(nameof(ExternalHostingFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JavascriptcodeCompound = group.Add(new VocabularyKey(nameof(JavascriptcodeCompound), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
        public VocabularyKey FormPageId { get; private set; }
        public VocabularyKey LimitExceededMessage { get; private set; }
        public VocabularyKey WebSiteId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RedirectURL { get; private set; }
        public VocabularyKey JavaScriptCode { get; private set; }
        public VocabularyKey ExternalformhostingIframe { get; private set; }
        public VocabularyKey ExternalHostingFormatDescription { get; private set; }
        public VocabularyKey ExternalHostingFormat { get; private set; }
        public VocabularyKey JavascriptcodeCompound { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SuccessImageURL { get; private set; }
        public VocabularyKey ErrorImageURL { get; private set; }
    }
}