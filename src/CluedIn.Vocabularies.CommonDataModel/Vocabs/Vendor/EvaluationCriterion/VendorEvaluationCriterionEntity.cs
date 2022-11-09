using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorEvaluationCriterionEntityVocabulary : SimpleVocabulary
    {
        public VendorEvaluationCriterionEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendorEvaluationCriterionEntity";
            KeyPrefix = "commonDataModel.vendorevaluationcriterionentity";
            KeySeparator = ".";
            Grouping = "/VendorEvaluationCriterionEntity";

            AddGroup("Common Data Model VendorEvaluationCriterionEntity Details", group =>
            {
                CriterionGroupRecId = group.Add(new VocabularyKey(nameof(CriterionGroupRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CriterionName = group.Add(new VocabularyKey(nameof(CriterionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorEvaluationCriterionGroupName = group.Add(new VocabularyKey(nameof(VendorEvaluationCriterionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CriterionGroupRecId { get; private set; }
public VocabularyKey CriterionName { get; private set; }
public VocabularyKey VendorEvaluationCriterionGroupName { get; private set; }


    }
}