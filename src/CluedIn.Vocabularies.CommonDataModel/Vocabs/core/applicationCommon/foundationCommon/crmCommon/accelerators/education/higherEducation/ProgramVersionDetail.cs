using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.HigherEducation
{
    public class ProgramVersionDetailVocabulary : SimpleVocabulary
    {
        public ProgramVersionDetailVocabulary()
        {
            VocabularyName = "Program Version Detail";
            KeyPrefix = "commonDataModel.programversiondetail.highereducation";
            KeySeparator = ".";
            Grouping = "/ProgramVersionDetail";

            AddGroup("ProgramVersionDetail Details for HigherEducation", group =>
            {
			    ProgramVersionDetailId = group.Add(new VocabularyKey(nameof(ProgramVersionDetailId), "Program Version Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Program Version Detail Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedGraduationDate = group.Add(new VocabularyKey(nameof(ExpectedGraduationDate), "Expected Graduation Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalIdentifier = group.Add(new VocabularyKey(nameof(ExternalIdentifier), "External Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalSourceSystem = group.Add(new VocabularyKey(nameof(ExternalSourceSystem), "External Source System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MidpointDate = group.Add(new VocabularyKey(nameof(MidpointDate), "Midpoint Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MustGraduateBefore = group.Add(new VocabularyKey(nameof(MustGraduateBefore), "Must Graduate Before", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ProgramVersionDetailId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey ExpectedGraduationDate { get; private set; }
        public VocabularyKey ExternalIdentifier { get; private set; }
        public VocabularyKey ExternalSourceSystem { get; private set; }
        public VocabularyKey MidpointDate { get; private set; }
        public VocabularyKey MustGraduateBefore { get; private set; }
        public VocabularyKey StartDate { get; private set; }
    }
}