using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LinkedInFormQuestionVocabulary : SimpleVocabulary
    {
        public LinkedInFormQuestionVocabulary()
        {
            VocabularyName = "Linked In Form Question";
            KeyPrefix = "commonDataModel.linkedinformquestion";
            KeySeparator = ".";
            Grouping = "/LinkedInFormQuestion";

            AddGroup("LinkedInFormQuestion Details", group =>
            {
                DisplayName = group.Add(new VocabularyKey(nameof(DisplayName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsConsentCheckbox = group.Add(new VocabularyKey(nameof(IsConsentCheckbox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCustomQuestion = group.Add(new VocabularyKey(nameof(IsCustomQuestion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInFormQuestionId = group.Add(new VocabularyKey(nameof(LinkedInFormQuestionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInID = group.Add(new VocabularyKey(nameof(LinkedInID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResponseEditable = group.Add(new VocabularyKey(nameof(ResponseEditable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResponseType = group.Add(new VocabularyKey(nameof(ResponseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DisplayName { get; private set; }
        public VocabularyKey IsConsentCheckbox { get; private set; }
        public VocabularyKey IsCustomQuestion { get; private set; }
        public VocabularyKey LinkedInFormQuestionId { get; private set; }
        public VocabularyKey LinkedInID { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ResponseEditable { get; private set; }
        public VocabularyKey ResponseType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}