using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManGroupEntityVocabulary : SimpleVocabulary
    {
        public CredManGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model CredManGroupEntity";
            KeyPrefix = "commonDataModel.credmangroupentity";
            KeySeparator = ".";
            Grouping = "/CredManGroupEntity";

            AddGroup("Common Data Model CredManGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupId { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}