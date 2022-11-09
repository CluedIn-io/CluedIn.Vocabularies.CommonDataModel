using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProductionOrderSequencingSequenceValueEntityVocabulary : SimpleVocabulary
    {
        public ProductionOrderSequencingSequenceValueEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProductionOrderSequencingSequenceValueEntity";
            KeyPrefix = "commonDataModel.productionordersequencingsequencevalueentity";
            KeySeparator = ".";
            Grouping = "/ProductionOrderSequencingSequenceValueEntity";

            AddGroup("Common Data Model ProductionOrderSequencingSequenceValueEntity Details", group =>
            {
                ProductionOrderSequencingSequenceId = group.Add(new VocabularyKey(nameof(ProductionOrderSequencingSequenceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SequenceValue = group.Add(new VocabularyKey(nameof(SequenceValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Rank = group.Add(new VocabularyKey(nameof(Rank), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProductionOrderSequencingSequenceId { get; private set; }
public VocabularyKey SequenceValue { get; private set; }
public VocabularyKey Rank { get; private set; }


    }
}