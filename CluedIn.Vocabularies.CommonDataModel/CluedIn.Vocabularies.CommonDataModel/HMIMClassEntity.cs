using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMClassEntityVocabulary : SimpleVocabulary
    {
        public HMIMClassEntityVocabulary()
        {
            VocabularyName = "Common Data Model HMIMClassEntity";
            KeyPrefix = "commonDataModel.hmimclassentity";
            KeySeparator = ".";
            Grouping = "/HMIMClassEntity";

            AddGroup("Common Data Model HMIMClassEntity Details", group =>
            {
                ClassCode = group.Add(new VocabularyKey(nameof(ClassCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ClassCode { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}