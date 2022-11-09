using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkPoolEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkPoolEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWorkPoolEntity";
            KeyPrefix = "commonDataModel.whswarehouseworkpoolentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkPoolEntity";

            AddGroup("Common Data Model WHSWarehouseWorkPoolEntity Details", group =>
            {
                WorkPoolDescription = group.Add(new VocabularyKey(nameof(WorkPoolDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkPoolId = group.Add(new VocabularyKey(nameof(WorkPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WorkPoolDescription { get; private set; }
public VocabularyKey WorkPoolId { get; private set; }


    }
}