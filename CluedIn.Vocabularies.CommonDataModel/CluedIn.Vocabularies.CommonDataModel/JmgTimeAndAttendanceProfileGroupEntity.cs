using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgTimeAndAttendanceProfileGroupEntityVocabulary : SimpleVocabulary
    {
        public JmgTimeAndAttendanceProfileGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgTimeAndAttendanceProfileGroupEntity";
            KeyPrefix = "commonDataModel.jmgtimeandattendanceprofilegroupentity";
            KeySeparator = ".";
            Grouping = "/JmgTimeAndAttendanceProfileGroupEntity";

            AddGroup("Common Data Model JmgTimeAndAttendanceProfileGroupEntity Details", group =>
            {
                ProfileGroupId = group.Add(new VocabularyKey(nameof(ProfileGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProfileGroupId { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}