using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DMFDefinitionGroupTemplateHeaderEntityVocabulary : SimpleVocabulary
    {
        public DMFDefinitionGroupTemplateHeaderEntityVocabulary()
        {
            VocabularyName = "DMFDefinitionGroupTemplateHeaderEntity";
            KeyPrefix = "commonDataModel.dmfdefinitiongrouptemplateheaderentity";
            KeySeparator = ".";
            Grouping = "/DMFDefinitionGroupTemplateHeaderEntity";

            AddGroup("DMFDefinitionGroupTemplateHeaderEntity Details", group =>
            {
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidatedDateTime = group.Add(new VocabularyKey(nameof(ValidatedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey ValidatedDateTime { get; private set; }


    }
}