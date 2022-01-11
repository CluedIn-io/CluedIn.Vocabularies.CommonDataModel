using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesDocumentSortingOrderEntityVocabulary : SimpleVocabulary
    {
        public SalesDocumentSortingOrderEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesDocumentSortingOrderEntity";
            KeyPrefix = "commonDataModel.salesdocumentsortingorderentity";
            KeySeparator = ".";
            Grouping = "/SalesDocumentSortingOrderEntity";

            AddGroup("Common Data Model SalesDocumentSortingOrderEntity Details", group =>
            {
                FieldId = group.Add(new VocabularyKey(nameof(FieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SortingSubTableId = group.Add(new VocabularyKey(nameof(SortingSubTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SortingTableId = group.Add(new VocabularyKey(nameof(SortingTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentName = group.Add(new VocabularyKey(nameof(DocumentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubDocumentName = group.Add(new VocabularyKey(nameof(SubDocumentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FieldId { get; private set; }
public VocabularyKey SortingSubTableId { get; private set; }
public VocabularyKey SortingTableId { get; private set; }
public VocabularyKey FieldName { get; private set; }
public VocabularyKey DocumentName { get; private set; }
public VocabularyKey SubDocumentName { get; private set; }
public VocabularyKey Position { get; private set; }


    }
}