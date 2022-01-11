using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WarrantyPolicyEntityVocabulary : SimpleVocabulary
    {
        public WarrantyPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model WarrantyPolicyEntity";
            KeyPrefix = "commonDataModel.warrantypolicyentity";
            KeySeparator = ".";
            Grouping = "/WarrantyPolicyEntity";

            AddGroup("Common Data Model WarrantyPolicyEntity Details", group =>
            {
                PolicyNumber = group.Add(new VocabularyKey(nameof(PolicyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarrantiedItemId = group.Add(new VocabularyKey(nameof(WarrantiedItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarrantiedInventoryLotId = group.Add(new VocabularyKey(nameof(WarrantiedInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarrantiedSerialNumber = group.Add(new VocabularyKey(nameof(WarrantiedSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarrantiedFulfilledDate = group.Add(new VocabularyKey(nameof(WarrantiedFulfilledDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarrantyItemId = group.Add(new VocabularyKey(nameof(WarrantyItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarrantyInventoryLotId = group.Add(new VocabularyKey(nameof(WarrantyInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarrantySalesDate = group.Add(new VocabularyKey(nameof(WarrantySalesDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarrantyEffectiveDate = group.Add(new VocabularyKey(nameof(WarrantyEffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarrantyExpirationDate = group.Add(new VocabularyKey(nameof(WarrantyExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PolicyNumber { get; private set; }
public VocabularyKey WarrantiedItemId { get; private set; }
public VocabularyKey WarrantiedInventoryLotId { get; private set; }
public VocabularyKey WarrantiedSerialNumber { get; private set; }
public VocabularyKey WarrantiedFulfilledDate { get; private set; }
public VocabularyKey WarrantyItemId { get; private set; }
public VocabularyKey WarrantyInventoryLotId { get; private set; }
public VocabularyKey WarrantySalesDate { get; private set; }
public VocabularyKey WarrantyEffectiveDate { get; private set; }
public VocabularyKey WarrantyExpirationDate { get; private set; }
public VocabularyKey CustomerAccount { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey Notes { get; private set; }


    }
}