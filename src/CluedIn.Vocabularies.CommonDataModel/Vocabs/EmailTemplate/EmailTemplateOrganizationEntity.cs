using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EmailTemplateOrganizationEntityVocabulary : SimpleVocabulary
    {
        public EmailTemplateOrganizationEntityVocabulary()
        {
            VocabularyName = "Email Template Organization Entity";
            KeyPrefix = "commonDataModel.emailtemplateorganizationentity";
            KeySeparator = ".";
            Grouping = "/EmailTemplateOrganizationEntity";

            AddGroup("EmailTemplateOrganizationEntity Details", group =>
            {
                BatchGroup = group.Add(new VocabularyKey(nameof(BatchGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLanguage = group.Add(new VocabularyKey(nameof(DefaultLanguage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailId = group.Add(new VocabularyKey(nameof(EmailId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SenderAddress = group.Add(new VocabularyKey(nameof(SenderAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SenderName = group.Add(new VocabularyKey(nameof(SenderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BatchGroup { get; private set; }
        public VocabularyKey DefaultLanguage { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EmailId { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey SenderAddress { get; private set; }
        public VocabularyKey SenderName { get; private set; }
    }
}