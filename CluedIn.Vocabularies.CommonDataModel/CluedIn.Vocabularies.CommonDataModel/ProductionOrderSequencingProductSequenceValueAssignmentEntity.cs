using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProductionOrderSequencingProductSequenceValueAssignmentEntityVocabulary : SimpleVocabulary
    {
        public ProductionOrderSequencingProductSequenceValueAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProductionOrderSequencingProductSequenceValueAssignmentEntity";
            KeyPrefix = "commonDataModel.productionordersequencingproductsequencevalueassignmententity";
            KeySeparator = ".";
            Grouping = "/ProductionOrderSequencingProductSequenceValueAssignmentEntity";

            AddGroup("Common Data Model ProductionOrderSequencingProductSequenceValueAssignmentEntity Details", group =>
            {
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionOrderSequencingSequenceValue = group.Add(new VocabularyKey(nameof(ProductionOrderSequencingSequenceValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductionOrderSequencingSequenceId = group.Add(new VocabularyKey(nameof(ProductionOrderSequencingSequenceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ItemCode { get; private set; }
public VocabularyKey ItemRelation { get; private set; }
public VocabularyKey ProductionOrderSequencingSequenceValue { get; private set; }
public VocabularyKey ProductionOrderSequencingSequenceId { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey ProductGroupId { get; private set; }


    }
}