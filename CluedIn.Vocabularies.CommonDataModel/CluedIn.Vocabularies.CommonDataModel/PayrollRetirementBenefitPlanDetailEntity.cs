using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollRetirementBenefitPlanDetailEntityVocabulary : SimpleVocabulary
    {
        public PayrollRetirementBenefitPlanDetailEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollRetirementBenefitPlanDetailEntity";
            KeyPrefix = "commonDataModel.payrollretirementbenefitplandetailentity";
            KeySeparator = ".";
            Grouping = "/PayrollRetirementBenefitPlanDetailEntity";

            AddGroup("Common Data Model PayrollRetirementBenefitPlanDetailEntity Details", group =>
            {
                BenefitPlan = group.Add(new VocabularyKey(nameof(BenefitPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContributionLimitMethod = group.Add(new VocabularyKey(nameof(ContributionLimitMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContributionMethod = group.Add(new VocabularyKey(nameof(ContributionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetirementType = group.Add(new VocabularyKey(nameof(RetirementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BenefitPlanID = group.Add(new VocabularyKey(nameof(BenefitPlanID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BenefitPlan { get; private set; }
public VocabularyKey ContributionLimitMethod { get; private set; }
public VocabularyKey ContributionMethod { get; private set; }
public VocabularyKey RetirementType { get; private set; }
public VocabularyKey BenefitPlanID { get; private set; }


    }
}