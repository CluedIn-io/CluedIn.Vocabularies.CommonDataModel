using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesOrderPoolEntityVocabulary : SimpleVocabulary
    {
        public SalesOrderPoolEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesOrderPoolEntity";
            KeyPrefix = "commonDataModel.salesorderpoolentity";
            KeySeparator = ".";
            Grouping = "/SalesOrderPoolEntity";

            AddGroup("Common Data Model SalesOrderPoolEntity Details", group =>
            {
                PoolName = group.Add(new VocabularyKey(nameof(PoolName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PoolId = group.Add(new VocabularyKey(nameof(PoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PoolName { get; private set; }
public VocabularyKey PoolId { get; private set; }


    }
}