using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxFringeVariationEntityVocabulary : SimpleVocabulary
    {
        public TaxFringeVariationEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxFringeVariationEntity";
            KeyPrefix = "commonDataModel.taxfringevariationentity";
            KeySeparator = ".";
            Grouping = "/TaxFringeVariationEntity";

            AddGroup("Common Data Model TaxFringeVariationEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey ReasonCode { get; private set; }


    }
}