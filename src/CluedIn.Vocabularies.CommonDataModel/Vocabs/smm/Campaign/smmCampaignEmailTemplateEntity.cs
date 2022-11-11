using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmCampaignEmailTemplateEntityVocabulary : SimpleVocabulary
    {
        public smmCampaignEmailTemplateEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmCampaignEmailTemplateEntity";
            KeyPrefix = "commonDataModel.smmcampaignemailtemplateentity";
            KeySeparator = ".";
            Grouping = "/smmCampaignEmailTemplateEntity";

            AddGroup("Common Data Model smmCampaignEmailTemplateEntity Details", group =>
            {
                TemplateName = group.Add(new VocabularyKey(nameof(TemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailSubject = group.Add(new VocabularyKey(nameof(EmailSubject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailText = group.Add(new VocabularyKey(nameof(EmailText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TemplateName { get; private set; }
        public VocabularyKey EmailSubject { get; private set; }
        public VocabularyKey EmailText { get; private set; }


    }
}