using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollBenefitPlanDefaultDimensionEntityVocabulary : SimpleVocabulary
    {
        public PayrollBenefitPlanDefaultDimensionEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollBenefitPlanDefaultDimensionEntity";
            KeyPrefix = "commonDataModel.payrollbenefitplandefaultdimensionentity";
            KeySeparator = ".";
            Grouping = "/PayrollBenefitPlanDefaultDimensionEntity";

            AddGroup("Common Data Model PayrollBenefitPlanDefaultDimensionEntity Details", group =>
            {
                Plan = group.Add(new VocabularyKey(nameof(Plan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultFinancialDimensions = group.Add(new VocabularyKey(nameof(DefaultFinancialDimensions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Vendor = group.Add(new VocabularyKey(nameof(Vendor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompanyId = group.Add(new VocabularyKey(nameof(CompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BenefitPlanId = group.Add(new VocabularyKey(nameof(BenefitPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultFinancialDimensionsDisplayValue = group.Add(new VocabularyKey(nameof(DefaultFinancialDimensionsDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Plan { get; private set; }
public VocabularyKey Company { get; private set; }
public VocabularyKey Category { get; private set; }
public VocabularyKey DefaultFinancialDimensions { get; private set; }
public VocabularyKey LegalEntity { get; private set; }
public VocabularyKey Vendor { get; private set; }
public VocabularyKey CompanyId { get; private set; }
public VocabularyKey LegalEntityId { get; private set; }
public VocabularyKey BenefitPlanId { get; private set; }
public VocabularyKey DefaultFinancialDimensionsDisplayValue { get; private set; }


    }
}