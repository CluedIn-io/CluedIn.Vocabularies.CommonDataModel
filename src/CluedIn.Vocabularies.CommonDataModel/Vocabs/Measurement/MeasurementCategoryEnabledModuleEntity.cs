using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MeasurementCategoryEnabledModuleEntityVocabulary : SimpleVocabulary
    {
        public MeasurementCategoryEnabledModuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model MeasurementCategoryEnabledModuleEntity";
            KeyPrefix = "commonDataModel.measurementcategoryenabledmoduleentity";
            KeySeparator = ".";
            Grouping = "/MeasurementCategoryEnabledModuleEntity";

            AddGroup("Common Data Model MeasurementCategoryEnabledModuleEntity Details", group =>
            {
                Module = group.Add(new VocabularyKey(nameof(Module), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyId = group.Add(new VocabularyKey(nameof(CompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Module { get; private set; }
        public VocabularyKey CompanyId { get; private set; }
        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey Category { get; private set; }


    }
}