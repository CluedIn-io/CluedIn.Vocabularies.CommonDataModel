using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorEvaluationCriterionGroupForCategoryTranslationEntityVocabulary : SimpleVocabulary
    {
        public VendorEvaluationCriterionGroupForCategoryTranslationEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendorEvaluationCriterionGroupForCategoryTranslationEntity";
            KeyPrefix = "commonDataModel.vendorevaluationcriteriongroupforcategorytranslationentity";
            KeySeparator = ".";
            Grouping = "/VendorEvaluationCriterionGroupForCategoryTranslationEntity";

            AddGroup("Common Data Model VendorEvaluationCriterionGroupForCategoryTranslationEntity Details", group =>
            {
                VendorEvaluationCriterionGroupRecId = group.Add(new VocabularyKey(nameof(VendorEvaluationCriterionGroupRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorEvaluationCriterionGroupName = group.Add(new VocabularyKey(nameof(VendorEvaluationCriterionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TranslatedGroupDescription = group.Add(new VocabularyKey(nameof(TranslatedGroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey VendorEvaluationCriterionGroupRecId { get; private set; }
public VocabularyKey VendorEvaluationCriterionGroupName { get; private set; }
public VocabularyKey LanguageId { get; private set; }
public VocabularyKey TranslatedGroupDescription { get; private set; }


    }
}