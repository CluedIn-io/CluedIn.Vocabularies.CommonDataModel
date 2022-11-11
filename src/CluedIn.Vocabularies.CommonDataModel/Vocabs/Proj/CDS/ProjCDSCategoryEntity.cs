using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCDSCategoryEntityVocabulary : SimpleVocabulary
    {
        public ProjCDSCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjCDSCategoryEntity";
            KeyPrefix = "commonDataModel.projcdscategoryentity";
            KeySeparator = ".";
            Grouping = "/ProjCDSCategoryEntity";

            AddGroup("Common Data Model ProjCDSCategoryEntity Details", group =>
            {
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SharedCategory = group.Add(new VocabularyKey(nameof(SharedCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegrationId = group.Add(new VocabularyKey(nameof(IntegrationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey SharedCategory { get; private set; }
        public VocabularyKey IntegrationId { get; private set; }


    }
}