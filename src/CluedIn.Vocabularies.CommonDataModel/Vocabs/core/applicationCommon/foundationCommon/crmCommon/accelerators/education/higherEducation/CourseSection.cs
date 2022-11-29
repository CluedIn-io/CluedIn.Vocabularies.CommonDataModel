using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.HigherEducation
{
    public class CourseSectionVocabulary : SimpleVocabulary
    {
        public CourseSectionVocabulary()
        {
            VocabularyName = "Course Section";
            KeyPrefix = "commonDataModel.coursesection.highereducation";
            KeySeparator = ".";
            Grouping = "/CourseSection";

            AddGroup("CourseSection Details for HigherEducation", group =>
            {
			    CourseSectionId = group.Add(new VocabularyKey(nameof(CourseSectionId), "Course Section", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Course Section Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CourseDayTime = group.Add(new VocabularyKey(nameof(CourseDayTime), "Course Day/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Location = group.Add(new VocabularyKey(nameof(Location), "Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Prerequisites = group.Add(new VocabularyKey(nameof(Prerequisites), "Prerequisites", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CourseSectionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CourseDayTime { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey Prerequisites { get; private set; }
    }
}