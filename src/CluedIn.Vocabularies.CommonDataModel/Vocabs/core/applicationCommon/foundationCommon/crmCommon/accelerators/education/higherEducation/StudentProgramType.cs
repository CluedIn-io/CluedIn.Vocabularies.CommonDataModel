using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.HigherEducation
{
    public class StudentProgramTypeVocabulary : SimpleVocabulary
    {
        public StudentProgramTypeVocabulary()
        {
            VocabularyName = "Student Program Type";
            KeyPrefix = "commonDataModel.studentprogramtype.highereducation";
            KeySeparator = ".";
            Grouping = "/StudentProgramType";

            AddGroup("StudentProgramType Details for HigherEducation", group =>
            {
			    StudentProgramTypeId = group.Add(new VocabularyKey(nameof(StudentProgramTypeId), "Student Program Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Student Program Type Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey StudentProgramTypeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}