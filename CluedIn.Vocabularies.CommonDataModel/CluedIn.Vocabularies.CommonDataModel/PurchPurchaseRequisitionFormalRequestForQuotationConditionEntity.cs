using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRequisitionFormalRequestForQuotationConditionEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRequisitionFormalRequestForQuotationConditionEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPurchaseRequisitionFormalRequestForQuotationConditionEntity";
            KeyPrefix = "commonDataModel.purchpurchaserequisitionformalrequestforquotationconditionentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRequisitionFormalRequestForQuotationConditionEntity";

            AddGroup("Common Data Model PurchPurchaseRequisitionFormalRequestForQuotationConditionEntity Details", group =>
            {
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchReqControlRFQRule = group.Add(new VocabularyKey(nameof(PurchReqControlRFQRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQConditionThresholdAmount = group.Add(new VocabularyKey(nameof(RFQConditionThresholdAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcurementProductCategoryName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseRequisitionRequestForQuotationControlPolicyRuleValidFrom = group.Add(new VocabularyKey(nameof(PurchaseRequisitionRequestForQuotationControlPolicyRuleValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcurementProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Category { get; private set; }
public VocabularyKey PurchReqControlRFQRule { get; private set; }
public VocabularyKey RFQConditionThresholdAmount { get; private set; }
public VocabularyKey ProcurementProductCategoryName { get; private set; }
public VocabularyKey PurchaseRequisitionRequestForQuotationControlPolicyRuleValidFrom { get; private set; }
public VocabularyKey PurchasingPolicyName { get; private set; }
public VocabularyKey ProcurementProductCategoryHierarchyName { get; private set; }


    }
}