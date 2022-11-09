using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductStyleEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductStyleEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductStyleEntity";
            KeyPrefix = "commonDataModel.ecoresproductstyleentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductStyleEntity";

            AddGroup("Common Data Model EcoResProductStyleEntity Details", group =>
            {
                StyleId = group.Add(new VocabularyKey(nameof(StyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey StyleId { get; private set; }


    }
}