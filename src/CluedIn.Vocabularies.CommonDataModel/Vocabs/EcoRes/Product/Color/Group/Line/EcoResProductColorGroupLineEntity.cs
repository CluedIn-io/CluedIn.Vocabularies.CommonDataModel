using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductColorGroupLineEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductColorGroupLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductColorGroupLineEntity";
            KeyPrefix = "commonDataModel.ecoresproductcolorgrouplineentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductColorGroupLineEntity";

            AddGroup("Common Data Model EcoResProductColorGroupLineEntity Details", group =>
            {
                ProductColorGroupId = group.Add(new VocabularyKey(nameof(ProductColorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ColorName = group.Add(new VocabularyKey(nameof(ColorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ColorDescription = group.Add(new VocabularyKey(nameof(ColorDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BarcodeNumber = group.Add(new VocabularyKey(nameof(BarcodeNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReplenishmentWeight = group.Add(new VocabularyKey(nameof(ReplenishmentWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProductColorGroupId { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ColorName { get; private set; }
public VocabularyKey ColorDescription { get; private set; }
public VocabularyKey DisplayOrder { get; private set; }
public VocabularyKey BarcodeNumber { get; private set; }
public VocabularyKey ReplenishmentWeight { get; private set; }


    }
}