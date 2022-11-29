using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Marketing
{
    public class FormPageVocabulary : SimpleVocabulary
    {
        public FormPageVocabulary()
        {
            VocabularyName = "Form Page";
            KeyPrefix = "commonDataModel.formpage.marketing";
            KeySeparator = ".";
            Grouping = "/FormPage";

            AddGroup("FormPage Details for Marketing", group =>
            {
			    FormpageId = group.Add(new VocabularyKey(nameof(FormpageId), "Form page", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ConfirmationMessage = group.Add(new VocabularyKey(nameof(ConfirmationMessage), "Confirmation message", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ErrorMessage = group.Add(new VocabularyKey(nameof(ErrorMessage), "Error message", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LimitExceededMessage = group.Add(new VocabularyKey(nameof(LimitExceededMessage), "Limit exceeded message", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RedirectURL = group.Add(new VocabularyKey(nameof(RedirectURL), "Redirect URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Javascriptcode = group.Add(new VocabularyKey(nameof(Javascriptcode), "Javascript code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey FormpageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ConfirmationMessage { get; private set; }
        public VocabularyKey ErrorMessage { get; private set; }
        public VocabularyKey LimitExceededMessage { get; private set; }
        public VocabularyKey RedirectURL { get; private set; }
        public VocabularyKey Javascriptcode { get; private set; }
    }
}