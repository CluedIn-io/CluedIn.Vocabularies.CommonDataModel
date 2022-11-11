using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorEvaluationCriterionTranslationEntityVocabulary : SimpleVocabulary
    {
        public VendorEvaluationCriterionTranslationEntityVocabulary()
        {
            VocabularyName = "VendorEvaluationCriterionTranslationEntity";
            KeyPrefix = "commonDataModel.vendorevaluationcriteriontranslationentity";
            KeySeparator = ".";
            Grouping = "/VendorEvaluationCriterionTranslationEntity";

            AddGroup("VendorEvaluationCriterionTranslationEntity Details", group =>
            {
                VendReviewCriterionRecId = group.Add(new VocabularyKey(nameof(VendReviewCriterionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendReviewCriterionGroupRecId = group.Add(new VocabularyKey(nameof(VendReviewCriterionGroupRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorEvaluationCriterionName = group.Add(new VocabularyKey(nameof(VendorEvaluationCriterionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorEvaluationCriterionGroupName = group.Add(new VocabularyKey(nameof(VendorEvaluationCriterionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TranslatedCriterionDescription = group.Add(new VocabularyKey(nameof(TranslatedCriterionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey VendReviewCriterionRecId { get; private set; }
        public VocabularyKey VendReviewCriterionGroupRecId { get; private set; }
        public VocabularyKey VendorEvaluationCriterionName { get; private set; }
        public VocabularyKey VendorEvaluationCriterionGroupName { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey TranslatedCriterionDescription { get; private set; }


    }
}