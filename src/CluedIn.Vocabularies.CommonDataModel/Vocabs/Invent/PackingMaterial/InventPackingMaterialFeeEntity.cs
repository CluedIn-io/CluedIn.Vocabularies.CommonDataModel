using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventPackingMaterialFeeEntityVocabulary : SimpleVocabulary
    {
        public InventPackingMaterialFeeEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventPackingMaterialFeeEntity";
            KeyPrefix = "commonDataModel.inventpackingmaterialfeeentity";
            KeySeparator = ".";
            Grouping = "/InventPackingMaterialFeeEntity";

            AddGroup("Common Data Model InventPackingMaterialFeeEntity Details", group =>
            {
                PackingMaterialCode = group.Add(new VocabularyKey(nameof(PackingMaterialCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PricePerUnit = group.Add(new VocabularyKey(nameof(PricePerUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceCurrencyCode = group.Add(new VocabularyKey(nameof(PriceCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PackingMaterialCode { get; private set; }
public VocabularyKey PricePerUnit { get; private set; }
public VocabularyKey PriceCurrencyCode { get; private set; }
public VocabularyKey FromDate { get; private set; }
public VocabularyKey ToDate { get; private set; }


    }
}