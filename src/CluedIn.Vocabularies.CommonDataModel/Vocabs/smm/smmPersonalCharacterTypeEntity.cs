using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmPersonalCharacterTypeEntityVocabulary : SimpleVocabulary
    {
        public smmPersonalCharacterTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmPersonalCharacterTypeEntity";
            KeyPrefix = "commonDataModel.smmpersonalcharactertypeentity";
            KeySeparator = ".";
            Grouping = "/smmPersonalCharacterTypeEntity";

            AddGroup("Common Data Model smmPersonalCharacterTypeEntity Details", group =>
            {
                TypeName = group.Add(new VocabularyKey(nameof(TypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TypeName { get; private set; }
public VocabularyKey TypeDescription { get; private set; }


    }
}