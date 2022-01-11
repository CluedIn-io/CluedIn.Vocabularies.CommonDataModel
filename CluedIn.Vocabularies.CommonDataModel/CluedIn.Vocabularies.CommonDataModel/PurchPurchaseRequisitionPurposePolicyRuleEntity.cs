using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRequisitionPurposePolicyRuleEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRequisitionPurposePolicyRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPurchaseRequisitionPurposePolicyRuleEntity";
            KeyPrefix = "commonDataModel.purchpurchaserequisitionpurposepolicyruleentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRequisitionPurposePolicyRuleEntity";

            AddGroup("Common Data Model PurchPurchaseRequisitionPurposePolicyRuleEntity Details", group =>
            {
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPurposeOverrideAllowed = group.Add(new VocabularyKey(nameof(IsPurposeOverrideAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultPurchaseRequisitionPurpose = group.Add(new VocabularyKey(nameof(DefaultPurchaseRequisitionPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchasingPolicyName = group.Add(new VocabularyKey(nameof(PurchasingPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyRuleType = group.Add(new VocabularyKey(nameof(PolicyRuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyRuleName = group.Add(new VocabularyKey(nameof(PolicyRuleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }
public VocabularyKey IsPurposeOverrideAllowed { get; private set; }
public VocabularyKey DefaultPurchaseRequisitionPurpose { get; private set; }
public VocabularyKey PurchasingPolicyName { get; private set; }
public VocabularyKey Policy { get; private set; }
public VocabularyKey PolicyRuleType { get; private set; }
public VocabularyKey PolicyRuleName { get; private set; }


    }
}