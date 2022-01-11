using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailPackageLinesEntityVocabulary : SimpleVocabulary
    {
        public RetailPackageLinesEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailPackageLinesEntity";
            KeyPrefix = "commonDataModel.retailpackagelinesentity";
            KeySeparator = ".";
            Grouping = "/RetailPackageLinesEntity";

            AddGroup("Common Data Model RetailPackageLinesEntity Details", group =>
            {
                InventDimId = group.Add(new VocabularyKey(nameof(InventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VariantId = group.Add(new VocabularyKey(nameof(VariantId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackageId = group.Add(new VocabularyKey(nameof(PackageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseUnit = group.Add(new VocabularyKey(nameof(PurchaseUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Color = group.Add(new VocabularyKey(nameof(Color), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Size = group.Add(new VocabularyKey(nameof(Size), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Style = group.Add(new VocabularyKey(nameof(Style), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConfigId = group.Add(new VocabularyKey(nameof(ConfigId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey InventDimId { get; private set; }
public VocabularyKey VariantId { get; private set; }
public VocabularyKey ItemId { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey PackageId { get; private set; }
public VocabularyKey PurchaseUnit { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey Color { get; private set; }
public VocabularyKey Size { get; private set; }
public VocabularyKey Style { get; private set; }
public VocabularyKey ConfigId { get; private set; }


    }
}