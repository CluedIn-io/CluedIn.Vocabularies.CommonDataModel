using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkTypeTableEntityVocabulary : SimpleVocabulary
    {
        public WorkTypeTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model WorkTypeTableEntity";
            KeyPrefix = "commonDataModel.worktypetableentity";
            KeySeparator = ".";
            Grouping = "/WorkTypeTableEntity";

            AddGroup("Common Data Model WorkTypeTableEntity Details", group =>
            {
                TypeOfWorks = group.Add(new VocabularyKey(nameof(TypeOfWorks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TypeOfWorks { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}