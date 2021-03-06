using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetConsumptionFactorEntityVocabulary : SimpleVocabulary
    {
        public AssetConsumptionFactorEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetConsumptionFactorEntity";
            KeyPrefix = "commonDataModel.assetconsumptionfactorentity";
            KeySeparator = ".";
            Grouping = "/AssetConsumptionFactorEntity";

            AddGroup("Common Data Model AssetConsumptionFactorEntity Details", group =>
            {
                Percentage = group.Add(new VocabularyKey(nameof(Percentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConsumptionFactorId = group.Add(new VocabularyKey(nameof(ConsumptionFactorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Percentage { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey ConsumptionFactorId { get; private set; }


    }
}