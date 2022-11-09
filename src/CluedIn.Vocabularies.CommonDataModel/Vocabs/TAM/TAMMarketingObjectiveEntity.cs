using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMMarketingObjectiveEntityVocabulary : SimpleVocabulary
    {
        public TAMMarketingObjectiveEntityVocabulary()
        {
            VocabularyName = "Common Data Model TAMMarketingObjectiveEntity";
            KeyPrefix = "commonDataModel.tammarketingobjectiveentity";
            KeySeparator = ".";
            Grouping = "/TAMMarketingObjectiveEntity";

            AddGroup("Common Data Model TAMMarketingObjectiveEntity Details", group =>
            {
                ObjectiveCode = group.Add(new VocabularyKey(nameof(ObjectiveCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ObjectiveDescription = group.Add(new VocabularyKey(nameof(ObjectiveDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ObjectiveCode { get; private set; }
public VocabularyKey ObjectiveDescription { get; private set; }


    }
}