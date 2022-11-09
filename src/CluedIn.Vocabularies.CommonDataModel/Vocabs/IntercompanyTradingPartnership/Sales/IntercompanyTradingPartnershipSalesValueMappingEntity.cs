using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntercompanyTradingPartnershipSalesValueMappingEntityVocabulary : SimpleVocabulary
    {
        public IntercompanyTradingPartnershipSalesValueMappingEntityVocabulary()
        {
            VocabularyName = "Common Data Model IntercompanyTradingPartnershipSalesValueMappingEntity";
            KeyPrefix = "commonDataModel.intercompanytradingpartnershipsalesvaluemappingentity";
            KeySeparator = ".";
            Grouping = "/IntercompanyTradingPartnershipSalesValueMappingEntity";

            AddGroup("Common Data Model IntercompanyTradingPartnershipSalesValueMappingEntity Details", group =>
            {
                CustomerLegalEntityId = group.Add(new VocabularyKey(nameof(CustomerLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryModeCodeDefinition = group.Add(new VocabularyKey(nameof(DeliveryModeCodeDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalDeliveryModeCode = group.Add(new VocabularyKey(nameof(ExternalDeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryTermsCodeDefinition = group.Add(new VocabularyKey(nameof(DeliveryTermsCodeDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalDeliveryTermsCode = group.Add(new VocabularyKey(nameof(ExternalDeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeCodeDefinition = group.Add(new VocabularyKey(nameof(ChargeCodeDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalChargeCode = group.Add(new VocabularyKey(nameof(ExternalChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderReturnReasonCodeDefinition = group.Add(new VocabularyKey(nameof(OrderReturnReasonCodeDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalOrderReturnReasonCode = group.Add(new VocabularyKey(nameof(ExternalOrderReturnReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderReturnDispositionCodeDefinition = group.Add(new VocabularyKey(nameof(OrderReturnDispositionCodeDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalOrderReturnDispositionCode = group.Add(new VocabularyKey(nameof(ExternalOrderReturnDispositionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderInventoryProfileCodeDefinition = group.Add(new VocabularyKey(nameof(OrderInventoryProfileCodeDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalOrderInventoryProfileCode = group.Add(new VocabularyKey(nameof(ExternalOrderInventoryProfileCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgreementClassificationDefinition = group.Add(new VocabularyKey(nameof(AgreementClassificationDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalAgreementClassificationCode = group.Add(new VocabularyKey(nameof(ExternalAgreementClassificationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CustomerLegalEntityId { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }
public VocabularyKey DeliveryModeCodeDefinition { get; private set; }
public VocabularyKey ExternalDeliveryModeCode { get; private set; }
public VocabularyKey DeliveryTermsCodeDefinition { get; private set; }
public VocabularyKey ExternalDeliveryTermsCode { get; private set; }
public VocabularyKey ChargeCodeDefinition { get; private set; }
public VocabularyKey ExternalChargeCode { get; private set; }
public VocabularyKey OrderReturnReasonCodeDefinition { get; private set; }
public VocabularyKey ExternalOrderReturnReasonCode { get; private set; }
public VocabularyKey OrderReturnDispositionCodeDefinition { get; private set; }
public VocabularyKey ExternalOrderReturnDispositionCode { get; private set; }
public VocabularyKey OrderInventoryProfileCodeDefinition { get; private set; }
public VocabularyKey ExternalOrderInventoryProfileCode { get; private set; }
public VocabularyKey AgreementClassificationDefinition { get; private set; }
public VocabularyKey ExternalAgreementClassificationCode { get; private set; }


    }
}