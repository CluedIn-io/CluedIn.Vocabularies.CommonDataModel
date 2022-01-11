using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailReturnInfocodePolicyLineEntityVocabulary : SimpleVocabulary
    {
        public RetailReturnInfocodePolicyLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailReturnInfocodePolicyLineEntity";
            KeyPrefix = "commonDataModel.retailreturninfocodepolicylineentity";
            KeySeparator = ".";
            Grouping = "/RetailReturnInfocodePolicyLineEntity";

            AddGroup("Common Data Model RetailReturnInfocodePolicyLineEntity Details", group =>
            {
                Warehouse = group.Add(new VocabularyKey(nameof(Warehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BlockItem = group.Add(new VocabularyKey(nameof(BlockItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PalletId = group.Add(new VocabularyKey(nameof(PalletId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyNumber = group.Add(new VocabularyKey(nameof(PolicyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailStoreTable = group.Add(new VocabularyKey(nameof(RetailStoreTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InfocodeId = group.Add(new VocabularyKey(nameof(InfocodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubcodeId = group.Add(new VocabularyKey(nameof(SubcodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Warehouse { get; private set; }
public VocabularyKey BlockItem { get; private set; }
public VocabularyKey Policy { get; private set; }
public VocabularyKey LocationId { get; private set; }
public VocabularyKey PalletId { get; private set; }
public VocabularyKey PolicyNumber { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey OperatingUnitNumber { get; private set; }
public VocabularyKey RetailStoreTable { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey InfocodeId { get; private set; }
public VocabularyKey SubcodeId { get; private set; }


    }
}