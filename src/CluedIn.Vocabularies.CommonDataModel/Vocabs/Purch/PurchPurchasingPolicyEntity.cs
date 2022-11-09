using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchasingPolicyEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchasingPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPurchasingPolicyEntity";
            KeyPrefix = "commonDataModel.purchpurchasingpolicyentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchasingPolicyEntity";

            AddGroup("Common Data Model PurchPurchasingPolicyEntity Details", group =>
            {
                PolicyDescription = group.Add(new VocabularyKey(nameof(PolicyDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPolicyActive = group.Add(new VocabularyKey(nameof(IsPolicyActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyType = group.Add(new VocabularyKey(nameof(PolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PolicyDescription { get; private set; }
public VocabularyKey IsPolicyActive { get; private set; }
public VocabularyKey PolicyName { get; private set; }
public VocabularyKey PolicyType { get; private set; }


    }
}