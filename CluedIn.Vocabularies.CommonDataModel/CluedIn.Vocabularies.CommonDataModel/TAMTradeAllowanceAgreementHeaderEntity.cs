using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMTradeAllowanceAgreementHeaderEntityVocabulary : SimpleVocabulary
    {
        public TAMTradeAllowanceAgreementHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model TAMTradeAllowanceAgreementHeaderEntity";
            KeyPrefix = "commonDataModel.tamtradeallowanceagreementheaderentity";
            KeySeparator = ".";
            Grouping = "/TAMTradeAllowanceAgreementHeaderEntity";

            AddGroup("Common Data Model TAMTradeAllowanceAgreementHeaderEntity Details", group =>
            {
                BaseQuantity = group.Add(new VocabularyKey(nameof(BaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgreementCurrencyCode = group.Add(new VocabularyKey(nameof(AgreementCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PromotionLiftPercentage = group.Add(new VocabularyKey(nameof(PromotionLiftPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MarketingObjectiveCode = group.Add(new VocabularyKey(nameof(MarketingObjectiveCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PromotionCostAmount = group.Add(new VocabularyKey(nameof(PromotionCostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToOrderDate = group.Add(new VocabularyKey(nameof(ToOrderDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromOrderDate = group.Add(new VocabularyKey(nameof(FromOrderDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpectedPromotionalQuantity = group.Add(new VocabularyKey(nameof(ExpectedPromotionalQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToLumpSumPayoutDate = group.Add(new VocabularyKey(nameof(ToLumpSumPayoutDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromLumpSumPayoutDate = group.Add(new VocabularyKey(nameof(FromLumpSumPayoutDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgreementDescription = group.Add(new VocabularyKey(nameof(AgreementDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgreementDetails = group.Add(new VocabularyKey(nameof(AgreementDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgreementId = group.Add(new VocabularyKey(nameof(AgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TradeAllowanceAgreementPeriodName = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementPeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgreementStatus = group.Add(new VocabularyKey(nameof(AgreementStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsBaseQuantityOverridden = group.Add(new VocabularyKey(nameof(IsBaseQuantityOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToRequestedShipDate = group.Add(new VocabularyKey(nameof(ToRequestedShipDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromRequestedShipDate = group.Add(new VocabularyKey(nameof(FromRequestedShipDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToRequestedReceiptDate = group.Add(new VocabularyKey(nameof(ToRequestedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromRequestedReceiptDate = group.Add(new VocabularyKey(nameof(FromRequestedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BaseQuantityUnitSymbol = group.Add(new VocabularyKey(nameof(BaseQuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkflowApprovalStatus = group.Add(new VocabularyKey(nameof(WorkflowApprovalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OwningWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(OwningWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BaseQuantity { get; private set; }
public VocabularyKey AgreementCurrencyCode { get; private set; }
public VocabularyKey PromotionLiftPercentage { get; private set; }
public VocabularyKey MarketingObjectiveCode { get; private set; }
public VocabularyKey PromotionCostAmount { get; private set; }
public VocabularyKey ToOrderDate { get; private set; }
public VocabularyKey FromOrderDate { get; private set; }
public VocabularyKey ExpectedPromotionalQuantity { get; private set; }
public VocabularyKey ToLumpSumPayoutDate { get; private set; }
public VocabularyKey FromLumpSumPayoutDate { get; private set; }
public VocabularyKey AgreementDescription { get; private set; }
public VocabularyKey AgreementDetails { get; private set; }
public VocabularyKey AgreementId { get; private set; }
public VocabularyKey TradeAllowanceAgreementPeriodName { get; private set; }
public VocabularyKey AgreementStatus { get; private set; }
public VocabularyKey IsBaseQuantityOverridden { get; private set; }
public VocabularyKey ToRequestedShipDate { get; private set; }
public VocabularyKey FromRequestedShipDate { get; private set; }
public VocabularyKey ToRequestedReceiptDate { get; private set; }
public VocabularyKey FromRequestedReceiptDate { get; private set; }
public VocabularyKey BaseQuantityUnitSymbol { get; private set; }
public VocabularyKey WorkflowApprovalStatus { get; private set; }
public VocabularyKey OwningWorkerPersonnelNumber { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }


    }
}