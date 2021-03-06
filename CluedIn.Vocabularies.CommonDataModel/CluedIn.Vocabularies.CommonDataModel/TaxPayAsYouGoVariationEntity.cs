using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxPayAsYouGoVariationEntityVocabulary : SimpleVocabulary
    {
        public TaxPayAsYouGoVariationEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxPayAsYouGoVariationEntity";
            KeyPrefix = "commonDataModel.taxpayasyougovariationentity";
            KeySeparator = ".";
            Grouping = "/TaxPayAsYouGoVariationEntity";

            AddGroup("Common Data Model TaxPayAsYouGoVariationEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey ReasonCode { get; private set; }


    }
}