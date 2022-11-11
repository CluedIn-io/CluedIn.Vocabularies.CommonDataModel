using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FormPageVocabulary : SimpleVocabulary
    {
        public FormPageVocabulary()
        {
            VocabularyName = "Common Data Model FormPage";
            KeyPrefix = "commonDataModel.formpage";
            KeySeparator = ".";
            Grouping = "/FormPage";

            AddGroup("Common Data Model FormPage Details", group =>
            {
                confirmationMessage = group.Add(new VocabularyKey(nameof(confirmationMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                errorMessage = group.Add(new VocabularyKey(nameof(errorMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                formPageId = group.Add(new VocabularyKey(nameof(formPageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                limitExceededMessage = group.Add(new VocabularyKey(nameof(limitExceededMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                webSiteId = group.Add(new VocabularyKey(nameof(webSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                redirectURL = group.Add(new VocabularyKey(nameof(redirectURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                javaScriptCode = group.Add(new VocabularyKey(nameof(javaScriptCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                externalformhostingIframe = group.Add(new VocabularyKey(nameof(externalformhostingIframe), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                externalHostingFormatDescription = group.Add(new VocabularyKey(nameof(externalHostingFormatDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                externalHostingFormat = group.Add(new VocabularyKey(nameof(externalHostingFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                javascriptcodeCompound = group.Add(new VocabularyKey(nameof(javascriptcodeCompound), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                successImageURL = group.Add(new VocabularyKey(nameof(successImageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                errorImageURL = group.Add(new VocabularyKey(nameof(errorImageURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey confirmationMessage { get; private set; }
        public VocabularyKey errorMessage { get; private set; }
        public VocabularyKey formPageId { get; private set; }
        public VocabularyKey limitExceededMessage { get; private set; }
        public VocabularyKey webSiteId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey redirectURL { get; private set; }
        public VocabularyKey javaScriptCode { get; private set; }
        public VocabularyKey externalformhostingIframe { get; private set; }
        public VocabularyKey externalHostingFormatDescription { get; private set; }
        public VocabularyKey externalHostingFormat { get; private set; }
        public VocabularyKey javascriptcodeCompound { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey successImageURL { get; private set; }
        public VocabularyKey errorImageURL { get; private set; }


    }
}