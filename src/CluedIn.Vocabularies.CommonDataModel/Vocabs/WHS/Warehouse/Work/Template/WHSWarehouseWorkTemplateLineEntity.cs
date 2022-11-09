using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkTemplateLineEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkTemplateLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWorkTemplateLineEntity";
            KeyPrefix = "commonDataModel.whswarehouseworktemplatelineentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkTemplateLineEntity";

            AddGroup("Common Data Model WHSWarehouseWorkTemplateLineEntity Details", group =>
            {
                WarehouseWorkOrderType = group.Add(new VocabularyKey(nameof(WarehouseWorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkTemplateId = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkOrderLineType = group.Add(new VocabularyKey(nameof(WorkOrderLineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomWorkOrderLineType = group.Add(new VocabularyKey(nameof(CustomWorkOrderLineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWorkLineMandatory = group.Add(new VocabularyKey(nameof(IsWorkLineMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWorkExecutionStopped = group.Add(new VocabularyKey(nameof(IsWorkExecutionStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CanFreezeWork = group.Add(new VocabularyKey(nameof(CanFreezeWork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseLocationDirectiveCode = group.Add(new VocabularyKey(nameof(WarehouseLocationDirectiveCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkClassId = group.Add(new VocabularyKey(nameof(WarehouseWorkClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QualityCheckTemplateId = group.Add(new VocabularyKey(nameof(QualityCheckTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WarehouseWorkOrderType { get; private set; }
public VocabularyKey WarehouseWorkTemplateId { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey WorkOrderLineType { get; private set; }
public VocabularyKey CustomWorkOrderLineType { get; private set; }
public VocabularyKey IsWorkLineMandatory { get; private set; }
public VocabularyKey IsWorkExecutionStopped { get; private set; }
public VocabularyKey CanFreezeWork { get; private set; }
public VocabularyKey WarehouseLocationDirectiveCode { get; private set; }
public VocabularyKey WarehouseWorkClassId { get; private set; }
public VocabularyKey QualityCheckTemplateId { get; private set; }


    }
}