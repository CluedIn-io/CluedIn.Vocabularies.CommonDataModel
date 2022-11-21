using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductSizeEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductSizeEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Size Entity";
            KeyPrefix = "commonDataModel.ecoresproductsizeentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductSizeEntity";

            AddGroup("EcoResProductSizeEntity Details", group =>
            {
                SizeId = group.Add(new VocabularyKey(nameof(SizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SizeId { get; private set; }
    }
}