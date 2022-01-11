using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWaveLabelTemplateV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWaveLabelTemplateV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWaveLabelTemplateV2Entity";
            KeyPrefix = "commonDataModel.whswavelabeltemplatev2entity";
            KeySeparator = ".";
            Grouping = "/WHSWaveLabelTemplateV2Entity";

            AddGroup("Common Data Model WHSWaveLabelTemplateV2Entity Details", group =>
            {
                TemplateDescription = group.Add(new VocabularyKey(nameof(TemplateDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateName = group.Add(new VocabularyKey(nameof(TemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkQuery = group.Add(new VocabularyKey(nameof(WorkQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WaveStepCode = group.Add(new VocabularyKey(nameof(WaveStepCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WaveLabelTypeId = group.Add(new VocabularyKey(nameof(WaveLabelTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TemplateDescription { get; private set; }
public VocabularyKey TemplateName { get; private set; }
public VocabularyKey WorkQuery { get; private set; }
public VocabularyKey WaveStepCode { get; private set; }
public VocabularyKey WarehouseId { get; private set; }
public VocabularyKey WaveLabelTypeId { get; private set; }


    }
}