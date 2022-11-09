using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCrossDockLineQuantityEntityVocabulary : SimpleVocabulary
    {
        public RetailCrossDockLineQuantityEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailCrossDockLineQuantityEntity";
            KeyPrefix = "commonDataModel.retailcrossdocklinequantityentity";
            KeySeparator = ".";
            Grouping = "/RetailCrossDockLineQuantityEntity";

            AddGroup("Common Data Model RetailCrossDockLineQuantityEntity Details", group =>
            {
                CrossDockId = group.Add(new VocabularyKey(nameof(CrossDockId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Warehouse = group.Add(new VocabularyKey(nameof(Warehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTable = group.Add(new VocabularyKey(nameof(SalesTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseCompany = group.Add(new VocabularyKey(nameof(WarehouseCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesId = group.Add(new VocabularyKey(nameof(SalesId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CrossDockId { get; private set; }
public VocabularyKey Warehouse { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey SalesTable { get; private set; }
public VocabularyKey WarehouseCompany { get; private set; }
public VocabularyKey SalesId { get; private set; }


    }
}