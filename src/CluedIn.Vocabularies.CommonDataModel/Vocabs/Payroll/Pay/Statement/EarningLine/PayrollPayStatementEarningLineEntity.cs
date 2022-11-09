using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollPayStatementEarningLineEntityVocabulary : SimpleVocabulary
    {
        public PayrollPayStatementEarningLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollPayStatementEarningLineEntity";
            KeyPrefix = "commonDataModel.payrollpaystatementearninglineentity";
            KeySeparator = ".";
            Grouping = "/PayrollPayStatementEarningLineEntity";

            AddGroup("Common Data Model PayrollPayStatementEarningLineEntity Details", group =>
            {
                AmountInTransactionCurrency = group.Add(new VocabularyKey(nameof(AmountInTransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmployerContribution = group.Add(new VocabularyKey(nameof(EmployerContribution), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineToRemove = group.Add(new VocabularyKey(nameof(LineToRemove), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineOverridden = group.Add(new VocabularyKey(nameof(LineOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayStatement = group.Add(new VocabularyKey(nameof(PayStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayStatementLineSource = group.Add(new VocabularyKey(nameof(PayStatementLineSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceDocumentLine = group.Add(new VocabularyKey(nameof(SourceDocumentLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EarningsDate = group.Add(new VocabularyKey(nameof(EarningsDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EarningRate = group.Add(new VocabularyKey(nameof(EarningRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerCompensationBenefit = group.Add(new VocabularyKey(nameof(WorkerCompensationBenefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GeneralLiabilityInsurance = group.Add(new VocabularyKey(nameof(GeneralLiabilityInsurance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxRegion = group.Add(new VocabularyKey(nameof(TaxRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingDistributionTemplateId = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingDistributionLegalEntityId = group.Add(new VocabularyKey(nameof(AccountingDistributionLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingDistributionLegalEntity = group.Add(new VocabularyKey(nameof(AccountingDistributionLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayStatementNumber = group.Add(new VocabularyKey(nameof(PayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CompensationBenefitId = group.Add(new VocabularyKey(nameof(CompensationBenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GeneralLiabilityInsuranceBenefitId = group.Add(new VocabularyKey(nameof(GeneralLiabilityInsuranceBenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerTaxRegion = group.Add(new VocabularyKey(nameof(WorkerTaxRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxRegionLocationId = group.Add(new VocabularyKey(nameof(TaxRegionLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkerTaxRegionLocationId = group.Add(new VocabularyKey(nameof(WorkerTaxRegionLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReversedPayStatementNumber = group.Add(new VocabularyKey(nameof(ReversedPayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReversedPayStatement = group.Add(new VocabularyKey(nameof(ReversedPayStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReversedPayStatementLineNum = group.Add(new VocabularyKey(nameof(ReversedPayStatementLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AmountInTransactionCurrency { get; private set; }
public VocabularyKey AccountingDate { get; private set; }
public VocabularyKey TemplateId { get; private set; }
public VocabularyKey EmployerContribution { get; private set; }
public VocabularyKey LineToRemove { get; private set; }
public VocabularyKey LineOverridden { get; private set; }
public VocabularyKey PayStatement { get; private set; }
public VocabularyKey Position { get; private set; }
public VocabularyKey PayStatementLineSource { get; private set; }
public VocabularyKey SourceDocumentLine { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey Company { get; private set; }
public VocabularyKey EarningCode { get; private set; }
public VocabularyKey EarningsDate { get; private set; }
public VocabularyKey EarningRate { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey WorkerCompensationBenefit { get; private set; }
public VocabularyKey GeneralLiabilityInsurance { get; private set; }
public VocabularyKey TaxRegion { get; private set; }
public VocabularyKey AccountingDistributionTemplateId { get; private set; }
public VocabularyKey AccountingDistributionLegalEntityId { get; private set; }
public VocabularyKey AccountingDistributionLegalEntity { get; private set; }
public VocabularyKey PayStatementNumber { get; private set; }
public VocabularyKey PositionId { get; private set; }
public VocabularyKey EarningCodeId { get; private set; }
public VocabularyKey CompensationBenefitId { get; private set; }
public VocabularyKey GeneralLiabilityInsuranceBenefitId { get; private set; }
public VocabularyKey WorkerTaxRegion { get; private set; }
public VocabularyKey TaxRegionLocationId { get; private set; }
public VocabularyKey WorkerTaxRegionLocationId { get; private set; }
public VocabularyKey PersonnelNumber { get; private set; }
public VocabularyKey ReversedPayStatementNumber { get; private set; }
public VocabularyKey ReversedPayStatement { get; private set; }
public VocabularyKey ReversedPayStatementLineNum { get; private set; }


    }
}