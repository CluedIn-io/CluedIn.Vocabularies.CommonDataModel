using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchAgreementClassificationTranslationEntityVocabulary : SimpleVocabulary
    {
        public PurchAgreementClassificationTranslationEntityVocabulary()
        {
            VocabularyName = "PurchAgreementClassificationTranslationEntity";
            KeyPrefix = "commonDataModel.purchagreementclassificationtranslationentity";
            KeySeparator = ".";
            Grouping = "/PurchAgreementClassificationTranslationEntity";

            AddGroup("PurchAgreementClassificationTranslationEntity Details", group =>
            {
                PurchaseAgreementClassificationName = group.Add(new VocabularyKey(nameof(PurchaseAgreementClassificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedClassificationDescription = group.Add(new VocabularyKey(nameof(TranslatedClassificationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PurchaseAgreementClassificationName { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey TranslatedClassificationDescription { get; private set; }


    }
}