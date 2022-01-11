using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollPayStatementEarningLineInquiryEntityVocabulary : SimpleVocabulary
    {
        public PayrollPayStatementEarningLineInquiryEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollPayStatementEarningLineInquiryEntity";
            KeyPrefix = "commonDataModel.payrollpaystatementearninglineinquiryentity";
            KeySeparator = ".";
            Grouping = "/PayrollPayStatementEarningLineInquiryEntity";

            AddGroup("Common Data Model PayrollPayStatementEarningLineInquiryEntity Details", group =>
            {
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayStatementNumber = group.Add(new VocabularyKey(nameof(PayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodEndDate = group.Add(new VocabularyKey(nameof(PeriodEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodStartDate = group.Add(new VocabularyKey(nameof(PeriodStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayCycleId = group.Add(new VocabularyKey(nameof(PayCycleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingCurrencyAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EarningRate = group.Add(new VocabularyKey(nameof(EarningRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxRegionDescription = group.Add(new VocabularyKey(nameof(TaxRegionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BenefitPlanIDGLI = group.Add(new VocabularyKey(nameof(BenefitPlanIDGLI), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BenefitOptionIDGLI = group.Add(new VocabularyKey(nameof(BenefitOptionIDGLI), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GeneralLiabilityInsurance = group.Add(new VocabularyKey(nameof(GeneralLiabilityInsurance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BenefitPlanIDComp = group.Add(new VocabularyKey(nameof(BenefitPlanIDComp), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BenefitOptionIDComp = group.Add(new VocabularyKey(nameof(BenefitOptionIDComp), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerCompensation = group.Add(new VocabularyKey(nameof(WorkerCompensation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Source = group.Add(new VocabularyKey(nameof(Source), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LineNum { get; private set; }
public VocabularyKey Worker { get; private set; }
public VocabularyKey PersonnelNumber { get; private set; }
public VocabularyKey PayStatementNumber { get; private set; }
public VocabularyKey PeriodEndDate { get; private set; }
public VocabularyKey PeriodStartDate { get; private set; }
public VocabularyKey PayCycleId { get; private set; }
public VocabularyKey AccountingDate { get; private set; }
public VocabularyKey EarningCode { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey AccountingCurrencyAmount { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey EarningRate { get; private set; }
public VocabularyKey PositionId { get; private set; }
public VocabularyKey TaxRegionDescription { get; private set; }
public VocabularyKey BenefitPlanIDGLI { get; private set; }
public VocabularyKey BenefitOptionIDGLI { get; private set; }
public VocabularyKey GeneralLiabilityInsurance { get; private set; }
public VocabularyKey BenefitPlanIDComp { get; private set; }
public VocabularyKey BenefitOptionIDComp { get; private set; }
public VocabularyKey WorkerCompensation { get; private set; }
public VocabularyKey Source { get; private set; }


    }
}