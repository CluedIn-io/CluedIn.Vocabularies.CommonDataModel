using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventProductTypeEntityVocabulary : SimpleVocabulary
    {
        public InventProductTypeEntityVocabulary()
        {
            VocabularyName = "Invent Product Type Entity";
            KeyPrefix = "commonDataModel.inventproducttypeentity";
            KeySeparator = ".";
            Grouping = "/InventProductTypeEntity";

            AddGroup("InventProductTypeEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductType = group.Add(new VocabularyKey(nameof(ProductType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProductType { get; private set; }
    }
}