using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWaveStepCodeEntityVocabulary : SimpleVocabulary
    {
        public WHSWaveStepCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWaveStepCodeEntity";
            KeyPrefix = "commonDataModel.whswavestepcodeentity";
            KeySeparator = ".";
            Grouping = "/WHSWaveStepCodeEntity";

            AddGroup("Common Data Model WHSWaveStepCodeEntity Details", group =>
            {
                WaveStepType = group.Add(new VocabularyKey(nameof(WaveStepType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WaveStepCode = group.Add(new VocabularyKey(nameof(WaveStepCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WaveStepDescription = group.Add(new VocabularyKey(nameof(WaveStepDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WaveStepType { get; private set; }
public VocabularyKey WaveStepCode { get; private set; }
public VocabularyKey WaveStepDescription { get; private set; }


    }
}