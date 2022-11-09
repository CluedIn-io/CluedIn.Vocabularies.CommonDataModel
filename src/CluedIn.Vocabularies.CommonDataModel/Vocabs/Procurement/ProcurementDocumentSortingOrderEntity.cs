using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcurementDocumentSortingOrderEntityVocabulary : SimpleVocabulary
    {
        public ProcurementDocumentSortingOrderEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProcurementDocumentSortingOrderEntity";
            KeyPrefix = "commonDataModel.procurementdocumentsortingorderentity";
            KeySeparator = ".";
            Grouping = "/ProcurementDocumentSortingOrderEntity";

            AddGroup("Common Data Model ProcurementDocumentSortingOrderEntity Details", group =>
            {
                FieldId = group.Add(new VocabularyKey(nameof(FieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SortingTableId = group.Add(new VocabularyKey(nameof(SortingTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentName = group.Add(new VocabularyKey(nameof(DocumentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FieldId { get; private set; }
public VocabularyKey SortingTableId { get; private set; }
public VocabularyKey FieldName { get; private set; }
public VocabularyKey DocumentName { get; private set; }
public VocabularyKey Position { get; private set; }


    }
}