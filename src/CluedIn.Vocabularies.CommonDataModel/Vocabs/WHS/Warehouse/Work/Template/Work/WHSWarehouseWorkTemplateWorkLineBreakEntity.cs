using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkTemplateWorkLineBreakEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkTemplateWorkLineBreakEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWorkTemplateWorkLineBreakEntity";
            KeyPrefix = "commonDataModel.whswarehouseworktemplateworklinebreakentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkTemplateWorkLineBreakEntity";

            AddGroup("Common Data Model WHSWarehouseWorkTemplateWorkLineBreakEntity Details", group =>
            {
                WarehouseWorkTemplateId = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkTemplateWorkOrderType = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateWorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkTemplateLineRecordId = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateLineRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseWorkTemplateLineNumber = group.Add(new VocabularyKey(nameof(WarehouseWorkTemplateLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkLineBreakSequenceNumber = group.Add(new VocabularyKey(nameof(WorkLineBreakSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkTemplateWorkLineBreakTableField = group.Add(new VocabularyKey(nameof(WorkTemplateWorkLineBreakTableField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WarehouseWorkTemplateId { get; private set; }
public VocabularyKey WarehouseWorkTemplateWorkOrderType { get; private set; }
public VocabularyKey WarehouseWorkTemplateLineRecordId { get; private set; }
public VocabularyKey WarehouseWorkTemplateLineNumber { get; private set; }
public VocabularyKey WorkLineBreakSequenceNumber { get; private set; }
public VocabularyKey WorkTemplateWorkLineBreakTableField { get; private set; }


    }
}