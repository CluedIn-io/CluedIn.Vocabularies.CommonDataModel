using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductMasterConfigurationTranslationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductMasterConfigurationTranslationEntityVocabulary()
        {
            VocabularyName = "EcoResProductMasterConfigurationTranslationEntity";
            KeyPrefix = "commonDataModel.ecoresproductmasterconfigurationtranslationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductMasterConfigurationTranslationEntity";

            AddGroup("EcoResProductMasterConfigurationTranslationEntity Details", group =>
            {
                DimensionTableId = group.Add(new VocabularyKey(nameof(DimensionTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterNumber = group.Add(new VocabularyKey(nameof(ProductMasterNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMasterConfigurationId = group.Add(new VocabularyKey(nameof(ProductMasterConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedConfigurationName = group.Add(new VocabularyKey(nameof(TranslatedConfigurationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedConfigurationDescription = group.Add(new VocabularyKey(nameof(TranslatedConfigurationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DimensionTableId { get; private set; }
        public VocabularyKey ProductMasterNumber { get; private set; }
        public VocabularyKey ProductMasterConfigurationId { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey TranslatedConfigurationName { get; private set; }
        public VocabularyKey TranslatedConfigurationDescription { get; private set; }


    }
}