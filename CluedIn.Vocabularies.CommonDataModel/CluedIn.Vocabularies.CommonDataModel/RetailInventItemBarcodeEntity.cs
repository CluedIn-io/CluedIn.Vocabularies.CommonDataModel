using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInventItemBarcodeEntityVocabulary : SimpleVocabulary
    {
        public RetailInventItemBarcodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailInventItemBarcodeEntity";
            KeyPrefix = "commonDataModel.retailinventitembarcodeentity";
            KeySeparator = ".";
            Grouping = "/RetailInventItemBarcodeEntity";

            AddGroup("Common Data Model RetailInventItemBarcodeEntity Details", group =>
            {
                barcodeSetupId = group.Add(new VocabularyKey(nameof(barcodeSetupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Blocked = group.Add(new VocabularyKey(nameof(Blocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
inventDimId = group.Add(new VocabularyKey(nameof(inventDimId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
itemBarCode = group.Add(new VocabularyKey(nameof(itemBarCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
itemId = group.Add(new VocabularyKey(nameof(itemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
qty = group.Add(new VocabularyKey(nameof(qty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailShowForItem = group.Add(new VocabularyKey(nameof(RetailShowForItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailVariantId = group.Add(new VocabularyKey(nameof(RetailVariantId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnitID = group.Add(new VocabularyKey(nameof(UnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
useForInput = group.Add(new VocabularyKey(nameof(useForInput), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
useForPrinting = group.Add(new VocabularyKey(nameof(useForPrinting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey barcodeSetupId { get; private set; }
public VocabularyKey Blocked { get; private set; }
public VocabularyKey description { get; private set; }
public VocabularyKey inventDimId { get; private set; }
public VocabularyKey itemBarCode { get; private set; }
public VocabularyKey itemId { get; private set; }
public VocabularyKey qty { get; private set; }
public VocabularyKey RetailShowForItem { get; private set; }
public VocabularyKey RetailVariantId { get; private set; }
public VocabularyKey UnitID { get; private set; }
public VocabularyKey useForInput { get; private set; }
public VocabularyKey useForPrinting { get; private set; }


    }
}