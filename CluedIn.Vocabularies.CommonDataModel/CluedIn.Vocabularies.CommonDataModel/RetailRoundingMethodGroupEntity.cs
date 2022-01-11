using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailRoundingMethodGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailRoundingMethodGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailRoundingMethodGroupEntity";
            KeyPrefix = "commonDataModel.retailroundingmethodgroupentity";
            KeySeparator = ".";
            Grouping = "/RetailRoundingMethodGroupEntity";

            AddGroup("Common Data Model RetailRoundingMethodGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RoundingMethodId = group.Add(new VocabularyKey(nameof(RoundingMethodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey RoundingMethodId { get; private set; }


    }
}