using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollBenefitCalculationRateHeaderEntityVocabulary : SimpleVocabulary
    {
        public PayrollBenefitCalculationRateHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollBenefitCalculationRateHeaderEntity";
            KeyPrefix = "commonDataModel.payrollbenefitcalculationrateheaderentity";
            KeySeparator = ".";
            Grouping = "/PayrollBenefitCalculationRateHeaderEntity";

            AddGroup("Common Data Model PayrollBenefitCalculationRateHeaderEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TierType = group.Add(new VocabularyKey(nameof(TierType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey TierType { get; private set; }


    }
}