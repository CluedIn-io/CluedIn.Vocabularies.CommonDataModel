using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjPostTransViewEntityVocabulary : SimpleVocabulary
    {
        public ProjPostTransViewEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjPostTransViewEntity";
            KeyPrefix = "commonDataModel.projposttransviewentity";
            KeySeparator = ".";
            Grouping = "/ProjPostTransViewEntity";

            AddGroup("Common Data Model ProjPostTransViewEntity Details", group =>
            {
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyId = group.Add(new VocabularyKey(nameof(CurrencyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LinePropertyID = group.Add(new VocabularyKey(nameof(LinePropertyID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceName = group.Add(new VocabularyKey(nameof(ResourceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalCostAmount = group.Add(new VocabularyKey(nameof(TotalCostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalSalesAmount = group.Add(new VocabularyKey(nameof(TotalSalesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionOrigin = group.Add(new VocabularyKey(nameof(TransactionOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionId = group.Add(new VocabularyKey(nameof(TransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorName = group.Add(new VocabularyKey(nameof(VendorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CategoryId { get; private set; }
public VocabularyKey CurrencyId { get; private set; }
public VocabularyKey ItemId { get; private set; }
public VocabularyKey LinePropertyID { get; private set; }
public VocabularyKey ProjectId { get; private set; }
public VocabularyKey TransactionType { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey ResourceName { get; private set; }
public VocabularyKey TotalCostAmount { get; private set; }
public VocabularyKey TotalSalesAmount { get; private set; }
public VocabularyKey TransactionOrigin { get; private set; }
public VocabularyKey TransactionDate { get; private set; }
public VocabularyKey TransactionId { get; private set; }
public VocabularyKey VendorAccount { get; private set; }
public VocabularyKey VendorName { get; private set; }


    }
}