using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DirNameAffixEntityVocabulary : SimpleVocabulary
    {
        public DirNameAffixEntityVocabulary()
        {
            VocabularyName = "Common Data Model DirNameAffixEntity";
            KeyPrefix = "commonDataModel.dirnameaffixentity";
            KeySeparator = ".";
            Grouping = "/DirNameAffixEntity";

            AddGroup("Common Data Model DirNameAffixEntity Details", group =>
            {
                Affix = group.Add(new VocabularyKey(nameof(Affix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Affix { get; private set; }
public VocabularyKey Type { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}