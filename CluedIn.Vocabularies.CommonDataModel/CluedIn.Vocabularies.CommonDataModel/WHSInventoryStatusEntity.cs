using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSInventoryStatusEntityVocabulary : SimpleVocabulary
    {
        public WHSInventoryStatusEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSInventoryStatusEntity";
            KeyPrefix = "commonDataModel.whsinventorystatusentity";
            KeySeparator = ".";
            Grouping = "/WHSInventoryStatusEntity";

            AddGroup("Common Data Model WHSInventoryStatusEntity Details", group =>
            {
                StatusId = group.Add(new VocabularyKey(nameof(StatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StatusName = group.Add(new VocabularyKey(nameof(StatusName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillStatusBlockInventory = group.Add(new VocabularyKey(nameof(WillStatusBlockInventory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey StatusId { get; private set; }
public VocabularyKey StatusName { get; private set; }
public VocabularyKey WillStatusBlockInventory { get; private set; }


    }
}