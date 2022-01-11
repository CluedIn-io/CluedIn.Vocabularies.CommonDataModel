using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseLocationTypeEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseLocationTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseLocationTypeEntity";
            KeyPrefix = "commonDataModel.whswarehouselocationtypeentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseLocationTypeEntity";

            AddGroup("Common Data Model WHSWarehouseLocationTypeEntity Details", group =>
            {
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TypeDescription { get; private set; }
public VocabularyKey TypeId { get; private set; }


    }
}