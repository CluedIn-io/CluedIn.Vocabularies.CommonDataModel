using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductMasterConfigurationEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductMasterConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductMasterConfigurationEntity";
            KeyPrefix = "commonDataModel.ecoresproductmasterconfigurationentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductMasterConfigurationEntity";

            AddGroup("Common Data Model EcoResProductMasterConfigurationEntity Details", group =>
            {
                DimensionTableId = group.Add(new VocabularyKey(nameof(DimensionTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductMasterNumber = group.Add(new VocabularyKey(nameof(ProductMasterNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReplenishmentWeight = group.Add(new VocabularyKey(nameof(ReplenishmentWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContainerUnitSymbol = group.Add(new VocabularyKey(nameof(ContainerUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisplaySequenceNumber = group.Add(new VocabularyKey(nameof(DisplaySequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DimensionTableId { get; private set; }
public VocabularyKey ProductMasterNumber { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ReplenishmentWeight { get; private set; }
public VocabularyKey ContainerUnitSymbol { get; private set; }
public VocabularyKey DisplaySequenceNumber { get; private set; }


    }
}