using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductRelationTypeEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductRelationTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductRelationTypeEntity";
            KeyPrefix = "commonDataModel.ecoresproductrelationtypeentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductRelationTypeEntity";

            AddGroup("Common Data Model EcoResProductRelationTypeEntity Details", group =>
            {
                TypeName = group.Add(new VocabularyKey(nameof(TypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TypeName { get; private set; }


    }
}