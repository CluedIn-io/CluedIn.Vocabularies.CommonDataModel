using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgIndirectTimeAndAttendanceActivityCategoryEntityVocabulary : SimpleVocabulary
    {
        public JmgIndirectTimeAndAttendanceActivityCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgIndirectTimeAndAttendanceActivityCategoryEntity";
            KeyPrefix = "commonDataModel.jmgindirecttimeandattendanceactivitycategoryentity";
            KeySeparator = ".";
            Grouping = "/JmgIndirectTimeAndAttendanceActivityCategoryEntity";

            AddGroup("Common Data Model JmgIndirectTimeAndAttendanceActivityCategoryEntity Details", group =>
            {
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryDescription = group.Add(new VocabularyKey(nameof(CategoryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActivityRegistrationType = group.Add(new VocabularyKey(nameof(ActivityRegistrationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CategoryId { get; private set; }
public VocabularyKey CategoryDescription { get; private set; }
public VocabularyKey ActivityRegistrationType { get; private set; }


    }
}