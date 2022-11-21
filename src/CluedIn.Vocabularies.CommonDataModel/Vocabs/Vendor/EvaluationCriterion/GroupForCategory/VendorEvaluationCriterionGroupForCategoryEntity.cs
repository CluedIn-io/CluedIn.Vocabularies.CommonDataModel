using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorEvaluationCriterionGroupForCategoryEntityVocabulary : SimpleVocabulary
    {
        public VendorEvaluationCriterionGroupForCategoryEntityVocabulary()
        {
            VocabularyName = "Vendor Evaluation Criterion Group For Category Entity";
            KeyPrefix = "commonDataModel.vendorevaluationcriteriongroupforcategoryentity";
            KeySeparator = ".";
            Grouping = "/VendorEvaluationCriterionGroupForCategoryEntity";

            AddGroup("VendorEvaluationCriterionGroupForCategoryEntity Details", group =>
            {
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupName { get; private set; }
    }
}