using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductSizeEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductSizeEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductSizeEntity";
            KeyPrefix = "commonDataModel.ecoresproductsizeentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductSizeEntity";

            AddGroup("Common Data Model EcoResProductSizeEntity Details", group =>
            {
                SizeId = group.Add(new VocabularyKey(nameof(SizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SizeId { get; private set; }


    }
}