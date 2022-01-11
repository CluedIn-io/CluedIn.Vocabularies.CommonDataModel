using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmLeadRatingEntityVocabulary : SimpleVocabulary
    {
        public smmLeadRatingEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmLeadRatingEntity";
            KeyPrefix = "commonDataModel.smmleadratingentity";
            KeySeparator = ".";
            Grouping = "/smmLeadRatingEntity";

            AddGroup("Common Data Model smmLeadRatingEntity Details", group =>
            {
                RatingDescription = group.Add(new VocabularyKey(nameof(RatingDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RatingId = group.Add(new VocabularyKey(nameof(RatingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey RatingDescription { get; private set; }
public VocabularyKey RatingId { get; private set; }


    }
}