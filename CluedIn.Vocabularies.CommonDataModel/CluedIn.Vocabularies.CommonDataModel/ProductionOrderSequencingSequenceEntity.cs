using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProductionOrderSequencingSequenceEntityVocabulary : SimpleVocabulary
    {
        public ProductionOrderSequencingSequenceEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProductionOrderSequencingSequenceEntity";
            KeyPrefix = "commonDataModel.productionordersequencingsequenceentity";
            KeySeparator = ".";
            Grouping = "/ProductionOrderSequencingSequenceEntity";

            AddGroup("Common Data Model ProductionOrderSequencingSequenceEntity Details", group =>
            {
                SequenceId = group.Add(new VocabularyKey(nameof(SequenceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SequenceDescription = group.Add(new VocabularyKey(nameof(SequenceDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SequenceId { get; private set; }
public VocabularyKey SequenceDescription { get; private set; }


    }
}