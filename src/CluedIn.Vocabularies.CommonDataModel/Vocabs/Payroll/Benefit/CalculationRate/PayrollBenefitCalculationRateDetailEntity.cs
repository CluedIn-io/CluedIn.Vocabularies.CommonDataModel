using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollBenefitCalculationRateDetailEntityVocabulary : SimpleVocabulary
    {
        public PayrollBenefitCalculationRateDetailEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollBenefitCalculationRateDetailEntity";
            KeyPrefix = "commonDataModel.payrollbenefitcalculationratedetailentity";
            KeySeparator = ".";
            Grouping = "/PayrollBenefitCalculationRateDetailEntity";

            AddGroup("Common Data Model PayrollBenefitCalculationRateDetailEntity Details", group =>
            {
                BenefitCalculationRateVersion = group.Add(new VocabularyKey(nameof(BenefitCalculationRateVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContributionMethod = group.Add(new VocabularyKey(nameof(ContributionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerDeduction = group.Add(new VocabularyKey(nameof(WorkerDeduction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmployerContribution = group.Add(new VocabularyKey(nameof(EmployerContribution), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BenefitCalculationRate = group.Add(new VocabularyKey(nameof(BenefitCalculationRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Effective = group.Add(new VocabularyKey(nameof(Effective), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Expiration = group.Add(new VocabularyKey(nameof(Expiration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BenefitCalculationRateVersion { get; private set; }
public VocabularyKey ContributionMethod { get; private set; }
public VocabularyKey WorkerDeduction { get; private set; }
public VocabularyKey EmployerContribution { get; private set; }
public VocabularyKey BenefitCalculationRate { get; private set; }
public VocabularyKey Effective { get; private set; }
public VocabularyKey Expiration { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}