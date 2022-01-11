using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjStageEntityVocabulary : SimpleVocabulary
    {
        public ProjStageEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjStageEntity";
            KeyPrefix = "commonDataModel.projstageentity";
            KeySeparator = ".";
            Grouping = "/ProjStageEntity";

            AddGroup("Common Data Model ProjStageEntity Details", group =>
            {
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Stage = group.Add(new VocabularyKey(nameof(Stage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Language { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey Stage { get; private set; }


    }
}