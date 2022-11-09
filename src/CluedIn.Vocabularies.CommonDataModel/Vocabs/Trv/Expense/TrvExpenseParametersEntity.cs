using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvExpenseParametersEntityVocabulary : SimpleVocabulary
    {
        public TrvExpenseParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvExpenseParametersEntity";
            KeyPrefix = "commonDataModel.trvexpenseparametersentity";
            KeySeparator = ".";
            Grouping = "/TrvExpenseParametersEntity";

            AddGroup("Common Data Model TrvExpenseParametersEntity Details", group =>
            {
                AllowEditDistributions = group.Add(new VocabularyKey(nameof(AllowEditDistributions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BarCodeSetupId = group.Add(new VocabularyKey(nameof(BarCodeSetupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConvertPBSExchToInternal = group.Add(new VocabularyKey(nameof(ConvertPBSExchToInternal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeductBreakf = group.Add(new VocabularyKey(nameof(DeductBreakf), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeductDinner = group.Add(new VocabularyKey(nameof(DeductDinner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeductLunch = group.Add(new VocabularyKey(nameof(DeductLunch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisplayEntireExpenseOnDrillBack = group.Add(new VocabularyKey(nameof(DisplayEntireExpenseOnDrillBack), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnableTaxRecovery = group.Add(new VocabularyKey(nameof(EnableTaxRecovery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GlWorkSheet = group.Add(new VocabularyKey(nameof(GlWorkSheet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HotelReductionDef = group.Add(new VocabularyKey(nameof(HotelReductionDef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeOverviewInCoverPage = group.Add(new VocabularyKey(nameof(IncludeOverviewInCoverPage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeUserIDInBarcode = group.Add(new VocabularyKey(nameof(IncludeUserIDInBarcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAllowApproveExpenseOnBudgetFail = group.Add(new VocabularyKey(nameof(IsAllowApproveExpenseOnBudgetFail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAllowSubmitExpenseOnBudgetFail = group.Add(new VocabularyKey(nameof(IsAllowSubmitExpenseOnBudgetFail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAllowSubmitRequisitionOnBudgetFail = group.Add(new VocabularyKey(nameof(IsAllowSubmitRequisitionOnBudgetFail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAllowUpdateAccountingDate = group.Add(new VocabularyKey(nameof(IsAllowUpdateAccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReleaseEncumbrancesOnCloseRequisition = group.Add(new VocabularyKey(nameof(IsReleaseEncumbrancesOnCloseRequisition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsTravelRequisitionMandatoryForExpense = group.Add(new VocabularyKey(nameof(IsTravelRequisitionMandatoryForExpense), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
KeyId = group.Add(new VocabularyKey(nameof(KeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
KmPrice = group.Add(new VocabularyKey(nameof(KmPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MealReductionDef = group.Add(new VocabularyKey(nameof(MealReductionDef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinHours = group.Add(new VocabularyKey(nameof(MinHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OtherReductionDef = group.Add(new VocabularyKey(nameof(OtherReductionDef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PerDiemCalculation = group.Add(new VocabularyKey(nameof(PerDiemCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PerDiemRounding = group.Add(new VocabularyKey(nameof(PerDiemRounding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonalPaidBy = group.Add(new VocabularyKey(nameof(PersonalPaidBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostImmediately = group.Add(new VocabularyKey(nameof(PostImmediately), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxIncluded = group.Add(new VocabularyKey(nameof(TaxIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseInterCompanyExpense = group.Add(new VocabularyKey(nameof(UseInterCompanyExpense), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidateTravelPurpose = group.Add(new VocabularyKey(nameof(ValidateTravelPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WhenToEvaluatePolicy = group.Add(new VocabularyKey(nameof(WhenToEvaluatePolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AllowEditCreditCardExchRate = group.Add(new VocabularyKey(nameof(AllowEditCreditCardExchRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseAntiCorruption = group.Add(new VocabularyKey(nameof(UseAntiCorruption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MealReductionType = group.Add(new VocabularyKey(nameof(MealReductionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AllowEditDistributions { get; private set; }
public VocabularyKey BarCodeSetupId { get; private set; }
public VocabularyKey ConvertPBSExchToInternal { get; private set; }
public VocabularyKey DeductBreakf { get; private set; }
public VocabularyKey DeductDinner { get; private set; }
public VocabularyKey DeductLunch { get; private set; }
public VocabularyKey DisplayEntireExpenseOnDrillBack { get; private set; }
public VocabularyKey EnableTaxRecovery { get; private set; }
public VocabularyKey GlWorkSheet { get; private set; }
public VocabularyKey HotelReductionDef { get; private set; }
public VocabularyKey IncludeOverviewInCoverPage { get; private set; }
public VocabularyKey IncludeUserIDInBarcode { get; private set; }
public VocabularyKey IsAllowApproveExpenseOnBudgetFail { get; private set; }
public VocabularyKey IsAllowSubmitExpenseOnBudgetFail { get; private set; }
public VocabularyKey IsAllowSubmitRequisitionOnBudgetFail { get; private set; }
public VocabularyKey IsAllowUpdateAccountingDate { get; private set; }
public VocabularyKey IsReleaseEncumbrancesOnCloseRequisition { get; private set; }
public VocabularyKey IsTravelRequisitionMandatoryForExpense { get; private set; }
public VocabularyKey KeyId { get; private set; }
public VocabularyKey KmPrice { get; private set; }
public VocabularyKey MealReductionDef { get; private set; }
public VocabularyKey MinHours { get; private set; }
public VocabularyKey OtherReductionDef { get; private set; }
public VocabularyKey PerDiemCalculation { get; private set; }
public VocabularyKey PerDiemRounding { get; private set; }
public VocabularyKey PersonalPaidBy { get; private set; }
public VocabularyKey PostImmediately { get; private set; }
public VocabularyKey TaxIncluded { get; private set; }
public VocabularyKey UseInterCompanyExpense { get; private set; }
public VocabularyKey ValidateTravelPurpose { get; private set; }
public VocabularyKey WhenToEvaluatePolicy { get; private set; }
public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
public VocabularyKey AllowEditCreditCardExchRate { get; private set; }
public VocabularyKey UseAntiCorruption { get; private set; }
public VocabularyKey MealReductionType { get; private set; }


    }
}