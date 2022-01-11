using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWaveTemplateProcessingMethodAssignmentEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWaveTemplateProcessingMethodAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWaveTemplateProcessingMethodAssignmentEntity";
            KeyPrefix = "commonDataModel.whswarehousewavetemplateprocessingmethodassignmententity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWaveTemplateProcessingMethodAssignmentEntity";

            AddGroup("Common Data Model WHSWarehouseWaveTemplateProcessingMethodAssignmentEntity Details", group =>
            {
                WarehouseWaveProcessingMethodName = group.Add(new VocabularyKey(nameof(WarehouseWaveProcessingMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MethodSequenceNumber = group.Add(new VocabularyKey(nameof(MethodSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MethodWaveStepCode = group.Add(new VocabularyKey(nameof(MethodWaveStepCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateName = group.Add(new VocabularyKey(nameof(TemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WarehouseWaveProcessingMethodName { get; private set; }
public VocabularyKey MethodSequenceNumber { get; private set; }
public VocabularyKey MethodWaveStepCode { get; private set; }
public VocabularyKey TemplateName { get; private set; }


    }
}