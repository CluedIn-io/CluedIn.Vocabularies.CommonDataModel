using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductMasterColorEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductMasterColorEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductMasterColorEntity";
            KeyPrefix = "commonDataModel.ecoresproductmastercolorentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductMasterColorEntity";

            AddGroup("Common Data Model EcoResProductMasterColorEntity Details", group =>
            {
                DimensionTableId = group.Add(new VocabularyKey(nameof(DimensionTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductMasterNumber = group.Add(new VocabularyKey(nameof(ProductMasterNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReplenishmentWeight = group.Add(new VocabularyKey(nameof(ReplenishmentWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisplaySequenceNumber = group.Add(new VocabularyKey(nameof(DisplaySequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DimensionTableId { get; private set; }
public VocabularyKey ProductMasterNumber { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ReplenishmentWeight { get; private set; }
public VocabularyKey DisplaySequenceNumber { get; private set; }


    }
}