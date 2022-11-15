using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductColorEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductColorEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Color Entity";
            KeyPrefix = "commonDataModel.ecoresproductcolorentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductColorEntity";

            AddGroup("EcoResProductColorEntity Details", group =>
            {
                ColorId = group.Add(new VocabularyKey(nameof(ColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ColorId { get; private set; }
    }
}