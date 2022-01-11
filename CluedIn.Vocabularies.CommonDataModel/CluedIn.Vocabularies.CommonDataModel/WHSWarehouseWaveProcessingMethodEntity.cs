using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWaveProcessingMethodEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWaveProcessingMethodEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWaveProcessingMethodEntity";
            KeyPrefix = "commonDataModel.whswarehousewaveprocessingmethodentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWaveProcessingMethodEntity";

            AddGroup("Common Data Model WHSWarehouseWaveProcessingMethodEntity Details", group =>
            {
                MethodName = group.Add(new VocabularyKey(nameof(MethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MethodPosition = group.Add(new VocabularyKey(nameof(MethodPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsRepeatable = group.Add(new VocabularyKey(nameof(IsRepeatable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WaveTemplateType = group.Add(new VocabularyKey(nameof(WaveTemplateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey MethodName { get; private set; }
public VocabularyKey MethodPosition { get; private set; }
public VocabularyKey IsRepeatable { get; private set; }
public VocabularyKey WaveTemplateType { get; private set; }


    }
}