using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventBuyerGroupEntityVocabulary : SimpleVocabulary
    {
        public InventBuyerGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventBuyerGroupEntity";
            KeyPrefix = "commonDataModel.inventbuyergroupentity";
            KeySeparator = ".";
            Grouping = "/InventBuyerGroupEntity";

            AddGroup("Common Data Model InventBuyerGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupDescription { get; private set; }
public VocabularyKey GroupId { get; private set; }


    }
}