using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.HigherEducation
{
    public class CourseVocabulary : SimpleVocabulary
    {
        public CourseVocabulary()
        {
            VocabularyName = "Course";
            KeyPrefix = "commonDataModel.course.highereducation";
            KeySeparator = ".";
            Grouping = "/Course";

            AddGroup("Course Details for HigherEducation", group =>
            {
			    CourseId = group.Add(new VocabularyKey(nameof(CourseId), "Course", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Course Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AcademicLevel = group.Add(new VocabularyKey(nameof(AcademicLevel), "Academic Level", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CourseNumber = group.Add(new VocabularyKey(nameof(CourseNumber), "Course Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalIdentifier = group.Add(new VocabularyKey(nameof(ExternalIdentifier), "External Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalSourceSystem = group.Add(new VocabularyKey(nameof(ExternalSourceSystem), "External Source System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Prerequisites = group.Add(new VocabularyKey(nameof(Prerequisites), "Prerequisites", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Section = group.Add(new VocabularyKey(nameof(Section), "Section", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Subject = group.Add(new VocabularyKey(nameof(Subject), "Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CourseId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AcademicLevel { get; private set; }
        public VocabularyKey CourseNumber { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey ExternalIdentifier { get; private set; }
        public VocabularyKey ExternalSourceSystem { get; private set; }
        public VocabularyKey Prerequisites { get; private set; }
        public VocabularyKey Section { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey Subject { get; private set; }
    }
}