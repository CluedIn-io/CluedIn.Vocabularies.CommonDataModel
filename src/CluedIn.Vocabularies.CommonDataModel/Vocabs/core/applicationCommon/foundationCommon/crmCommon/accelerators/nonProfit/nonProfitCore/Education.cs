using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class EducationVocabulary : SimpleVocabulary
    {
        public EducationVocabulary()
        {
            VocabularyName = "Education";
            KeyPrefix = "commonDataModel.education.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Education";

            AddGroup("Education Details for NonProfitCore", group =>
            {
			    ClassYear = group.Add(new VocabularyKey(nameof(ClassYear), "Class Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    CompletionYear = group.Add(new VocabularyKey(nameof(CompletionYear), "Completion Year", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DegreeOrCertificate = group.Add(new VocabularyKey(nameof(DegreeOrCertificate), "Degree Or Certificate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EducationId = group.Add(new VocabularyKey(nameof(EducationId), "Education", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FieldOfStudy1 = group.Add(new VocabularyKey(nameof(FieldOfStudy1), "Field of Study #1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FieldOfStudy2 = group.Add(new VocabularyKey(nameof(FieldOfStudy2), "Field of Study #2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstYearAttended = group.Add(new VocabularyKey(nameof(FirstYearAttended), "First Year Attended", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Grade = group.Add(new VocabularyKey(nameof(Grade), "Grade", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastYearAttended = group.Add(new VocabularyKey(nameof(LastYearAttended), "Last Year Attended", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ClassYear { get; private set; }
        public VocabularyKey CompletionYear { get; private set; }
        public VocabularyKey DegreeOrCertificate { get; private set; }
        public VocabularyKey EducationId { get; private set; }
        public VocabularyKey FieldOfStudy1 { get; private set; }
        public VocabularyKey FieldOfStudy2 { get; private set; }
        public VocabularyKey FirstYearAttended { get; private set; }
        public VocabularyKey Grade { get; private set; }
        public VocabularyKey LastYearAttended { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}