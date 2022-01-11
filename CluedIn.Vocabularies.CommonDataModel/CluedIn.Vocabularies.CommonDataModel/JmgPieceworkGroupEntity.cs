using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgPieceworkGroupEntityVocabulary : SimpleVocabulary
    {
        public JmgPieceworkGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgPieceworkGroupEntity";
            KeyPrefix = "commonDataModel.jmgpieceworkgroupentity";
            KeySeparator = ".";
            Grouping = "/JmgPieceworkGroupEntity";

            AddGroup("Common Data Model JmgPieceworkGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupId { get; private set; }
public VocabularyKey GroupDescription { get; private set; }


    }
}