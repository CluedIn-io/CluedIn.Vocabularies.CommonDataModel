using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryProfileCustomerVendorLedgerEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryProfileCustomerVendorLedgerEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventInventoryProfileCustomerVendorLedgerEntity";
            KeyPrefix = "commonDataModel.inventinventoryprofilecustomervendorledgerentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryProfileCustomerVendorLedgerEntity";

            AddGroup("Common Data Model InventInventoryProfileCustomerVendorLedgerEntity Details", group =>
            {
                InventoryProfileRelation = group.Add(new VocabularyKey(nameof(InventoryProfileRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
KindOfActivity = group.Add(new VocabularyKey(nameof(KindOfActivity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryProfileId = group.Add(new VocabularyKey(nameof(InventoryProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerPostingProfile = group.Add(new VocabularyKey(nameof(CustomerPostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorPostingProfile = group.Add(new VocabularyKey(nameof(VendorPostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey InventoryProfileRelation { get; private set; }
public VocabularyKey KindOfActivity { get; private set; }
public VocabularyKey InventoryProfileId { get; private set; }
public VocabularyKey CustomerPostingProfile { get; private set; }
public VocabularyKey VendorPostingProfile { get; private set; }


    }
}