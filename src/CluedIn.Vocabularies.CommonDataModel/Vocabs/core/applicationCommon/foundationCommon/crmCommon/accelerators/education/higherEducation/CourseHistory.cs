using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.HigherEducation
{
    public class CourseHistoryVocabulary : SimpleVocabulary
    {
        public CourseHistoryVocabulary()
        {
            VocabularyName = "Course History";
            KeyPrefix = "commonDataModel.coursehistory.highereducation";
            KeySeparator = ".";
            Grouping = "/CourseHistory";

            AddGroup("CourseHistory Details for HigherEducation", group =>
            {
			    CourseHistoryId = group.Add(new VocabularyKey(nameof(CourseHistoryId), "Course History", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Course History Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContinuingEducation = group.Add(new VocabularyKey(nameof(ContinuingEducation), "Continuing Education", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreditsAttempted = group.Add(new VocabularyKey(nameof(CreditsAttempted), "Credits Attempted", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CreditsEarrned = group.Add(new VocabularyKey(nameof(CreditsEarrned), "Credits Earrned", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    GradePoints = group.Add(new VocabularyKey(nameof(GradePoints), "Grade Points", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    LastDateofAttendance = group.Add(new VocabularyKey(nameof(LastDateofAttendance), "Last Date of Attendance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LetterGrade = group.Add(new VocabularyKey(nameof(LetterGrade), "Letter Grade", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MidTermLetterGrade = group.Add(new VocabularyKey(nameof(MidTermLetterGrade), "Mid Term Letter Grade", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MidTermNumericGrade = group.Add(new VocabularyKey(nameof(MidTermNumericGrade), "Mid Term Numeric Grade", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CourseHistoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ContinuingEducation { get; private set; }
        public VocabularyKey CreditsAttempted { get; private set; }
        public VocabularyKey CreditsEarrned { get; private set; }
        public VocabularyKey GradePoints { get; private set; }
        public VocabularyKey LastDateofAttendance { get; private set; }
        public VocabularyKey LetterGrade { get; private set; }
        public VocabularyKey MidTermLetterGrade { get; private set; }
        public VocabularyKey MidTermNumericGrade { get; private set; }
    }
}