using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorEvaluationCriterionGroupForCategoryEntityVocabulary : SimpleVocabulary
    {
        public VendorEvaluationCriterionGroupForCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendorEvaluationCriterionGroupForCategoryEntity";
            KeyPrefix = "commonDataModel.vendorevaluationcriteriongroupforcategoryentity";
            KeySeparator = ".";
            Grouping = "/VendorEvaluationCriterionGroupForCategoryEntity";

            AddGroup("Common Data Model VendorEvaluationCriterionGroupForCategoryEntity Details", group =>
            {
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupName { get; private set; }


    }
}