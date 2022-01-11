using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRRoyaltyAgreementHeaderEntityVocabulary : SimpleVocabulary
    {
        public MCRRoyaltyAgreementHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRRoyaltyAgreementHeaderEntity";
            KeyPrefix = "commonDataModel.mcrroyaltyagreementheaderentity";
            KeySeparator = ".";
            Grouping = "/MCRRoyaltyAgreementHeaderEntity";

            AddGroup("Common Data Model MCRRoyaltyAgreementHeaderEntity Details", group =>
            {
                RoyaltyAgreementId = group.Add(new VocabularyKey(nameof(RoyaltyAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsApprovalRequired = group.Add(new VocabularyKey(nameof(IsApprovalRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCalculationSearchDateType = group.Add(new VocabularyKey(nameof(DefaultCalculationSearchDateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesCumulationMethod = group.Add(new VocabularyKey(nameof(SalesCumulationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultCurrencyCode = group.Add(new VocabularyKey(nameof(DefaultCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgreementDescription = group.Add(new VocabularyKey(nameof(AgreementDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultEffectiveDate = group.Add(new VocabularyKey(nameof(DefaultEffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultExpirationDate = group.Add(new VocabularyKey(nameof(DefaultExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemRoyaltyRelation = group.Add(new VocabularyKey(nameof(ItemRoyaltyRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemRoyaltyCode = group.Add(new VocabularyKey(nameof(ItemRoyaltyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoyaltyAccrualMainAccountId = group.Add(new VocabularyKey(nameof(RoyaltyAccrualMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoyaltyAccrualMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(RoyaltyAccrualMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoyaltyExpenseMainAccountId = group.Add(new VocabularyKey(nameof(RoyaltyExpenseMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoyaltyExpenseMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(RoyaltyExpenseMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesCumulationMethodCustomizedPeriodType = group.Add(new VocabularyKey(nameof(SalesCumulationMethodCustomizedPeriodType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgreementNote = group.Add(new VocabularyKey(nameof(AgreementNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoyaltyBreakBasis = group.Add(new VocabularyKey(nameof(RoyaltyBreakBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineAmountBasis = group.Add(new VocabularyKey(nameof(LineAmountBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesUnitSymbolOption = group.Add(new VocabularyKey(nameof(SalesUnitSymbolOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultSalesUnitSymbol = group.Add(new VocabularyKey(nameof(DefaultSalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesUnitSymbolType = group.Add(new VocabularyKey(nameof(SalesUnitSymbolType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultVendorAccountNumber = group.Add(new VocabularyKey(nameof(DefaultVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsValidated = group.Add(new VocabularyKey(nameof(IsValidated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidatedBy = group.Add(new VocabularyKey(nameof(ValidatedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidatingWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(ValidatingWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey RoyaltyAgreementId { get; private set; }
public VocabularyKey IsApprovalRequired { get; private set; }
public VocabularyKey DefaultCalculationSearchDateType { get; private set; }
public VocabularyKey SalesCumulationMethod { get; private set; }
public VocabularyKey DefaultCurrencyCode { get; private set; }
public VocabularyKey AgreementDescription { get; private set; }
public VocabularyKey DefaultEffectiveDate { get; private set; }
public VocabularyKey DefaultExpirationDate { get; private set; }
public VocabularyKey ItemRoyaltyRelation { get; private set; }
public VocabularyKey ItemRoyaltyCode { get; private set; }
public VocabularyKey RoyaltyAccrualMainAccountId { get; private set; }
public VocabularyKey RoyaltyAccrualMainAccountIdDisplayValue { get; private set; }
public VocabularyKey RoyaltyExpenseMainAccountId { get; private set; }
public VocabularyKey RoyaltyExpenseMainAccountIdDisplayValue { get; private set; }
public VocabularyKey SalesCumulationMethodCustomizedPeriodType { get; private set; }
public VocabularyKey AgreementNote { get; private set; }
public VocabularyKey RoyaltyBreakBasis { get; private set; }
public VocabularyKey LineAmountBasis { get; private set; }
public VocabularyKey SalesUnitSymbolOption { get; private set; }
public VocabularyKey DefaultSalesUnitSymbol { get; private set; }
public VocabularyKey SalesUnitSymbolType { get; private set; }
public VocabularyKey DefaultVendorAccountNumber { get; private set; }
public VocabularyKey IsValidated { get; private set; }
public VocabularyKey ValidatedBy { get; private set; }
public VocabularyKey ValidatingWorkerPersonnelNumber { get; private set; }


    }
}