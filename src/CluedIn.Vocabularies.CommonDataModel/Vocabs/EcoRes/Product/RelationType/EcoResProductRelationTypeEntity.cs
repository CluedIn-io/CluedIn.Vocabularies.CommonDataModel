using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductRelationTypeEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductRelationTypeEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Relation Type Entity";
            KeyPrefix = "commonDataModel.ecoresproductrelationtypeentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductRelationTypeEntity";

            AddGroup("EcoResProductRelationTypeEntity Details", group =>
            {
                TypeName = group.Add(new VocabularyKey(nameof(TypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TypeName { get; private set; }
    }
}