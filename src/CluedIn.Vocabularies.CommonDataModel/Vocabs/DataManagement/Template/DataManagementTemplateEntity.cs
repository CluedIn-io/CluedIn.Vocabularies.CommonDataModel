using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DataManagementTemplateEntityVocabulary : SimpleVocabulary
    {
        public DataManagementTemplateEntityVocabulary()
        {
            VocabularyName = "Common Data Model DataManagementTemplateEntity";
            KeyPrefix = "commonDataModel.datamanagementtemplateentity";
            KeySeparator = ".";
            Grouping = "/DataManagementTemplateEntity";

            AddGroup("Common Data Model DataManagementTemplateEntity Details", group =>
            {
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}