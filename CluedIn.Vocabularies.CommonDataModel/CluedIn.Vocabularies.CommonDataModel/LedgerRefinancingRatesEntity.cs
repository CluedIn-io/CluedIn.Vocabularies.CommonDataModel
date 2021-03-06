using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerRefinancingRatesEntityVocabulary : SimpleVocabulary
    {
        public LedgerRefinancingRatesEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerRefinancingRatesEntity";
            KeyPrefix = "commonDataModel.ledgerrefinancingratesentity";
            KeySeparator = ".";
            Grouping = "/LedgerRefinancingRatesEntity";

            AddGroup("Common Data Model LedgerRefinancingRatesEntity Details", group =>
            {
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Percent = group.Add(new VocabularyKey(nameof(Percent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Factor = group.Add(new VocabularyKey(nameof(Factor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FromDate { get; private set; }
public VocabularyKey Percent { get; private set; }
public VocabularyKey Factor { get; private set; }


    }
}