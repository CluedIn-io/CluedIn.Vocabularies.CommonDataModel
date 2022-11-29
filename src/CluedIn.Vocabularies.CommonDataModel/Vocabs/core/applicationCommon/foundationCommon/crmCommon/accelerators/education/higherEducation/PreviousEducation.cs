using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.HigherEducation
{
    public class PreviousEducationVocabulary : SimpleVocabulary
    {
        public PreviousEducationVocabulary()
        {
            VocabularyName = "Previous Education";
            KeyPrefix = "commonDataModel.previouseducation.highereducation";
            KeySeparator = ".";
            Grouping = "/PreviousEducation";

            AddGroup("PreviousEducation Details for HigherEducation", group =>
            {
			    PreviousEducationId = group.Add(new VocabularyKey(nameof(PreviousEducationId), "Previous Education", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Previous Education Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ClassSize = group.Add(new VocabularyKey(nameof(ClassSize), "Class Size", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DateofEnrollment = group.Add(new VocabularyKey(nameof(DateofEnrollment), "Date of Enrollment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GPA = group.Add(new VocabularyKey(nameof(GPA), "GPA", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Graduated = group.Add(new VocabularyKey(nameof(Graduated), "Graduated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    GraduationDate = group.Add(new VocabularyKey(nameof(GraduationDate), "Graduation Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastDateofAttendance = group.Add(new VocabularyKey(nameof(LastDateofAttendance), "Last Date of Attendance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Major = group.Add(new VocabularyKey(nameof(Major), "Major", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Rank = group.Add(new VocabularyKey(nameof(Rank), "Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey PreviousEducationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ClassSize { get; private set; }
        public VocabularyKey DateofEnrollment { get; private set; }
        public VocabularyKey GPA { get; private set; }
        public VocabularyKey Graduated { get; private set; }
        public VocabularyKey GraduationDate { get; private set; }
        public VocabularyKey LastDateofAttendance { get; private set; }
        public VocabularyKey Major { get; private set; }
        public VocabularyKey Rank { get; private set; }
    }
}