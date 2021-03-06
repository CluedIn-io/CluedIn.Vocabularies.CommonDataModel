using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductColorEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductColorEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductColorEntity";
            KeyPrefix = "commonDataModel.ecoresproductcolorentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductColorEntity";

            AddGroup("Common Data Model EcoResProductColorEntity Details", group =>
            {
                ColorId = group.Add(new VocabularyKey(nameof(ColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ColorId { get; private set; }


    }
}