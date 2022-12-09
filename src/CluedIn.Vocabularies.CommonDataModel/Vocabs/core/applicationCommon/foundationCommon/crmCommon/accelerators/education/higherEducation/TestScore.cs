using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class TestScoreVocabulary : SimpleVocabulary
    {
        public TestScoreVocabulary()
        {
            VocabularyName = "Test Score";
            KeyPrefix = "commonDataModel.testscore";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.TestScore;

            AddGroup("TestScore Details for HigherEducation", group =>
            {
			    TestScoreId = group.Add(new VocabularyKey(nameof(TestScoreId), "Test Score", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Test Score Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ACTComposite = group.Add(new VocabularyKey(nameof(ACTComposite), "ACT - Composite", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ACTELA = group.Add(new VocabularyKey(nameof(ACTELA), "ACT - ELA", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ACTEnglish = group.Add(new VocabularyKey(nameof(ACTEnglish), "ACT - English", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ACTEquivalentScore = group.Add(new VocabularyKey(nameof(ACTEquivalentScore), "ACT Equivalent Score", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ACTMath = group.Add(new VocabularyKey(nameof(ACTMath), "ACT - Math", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ACTReading = group.Add(new VocabularyKey(nameof(ACTReading), "ACT - Reading", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ACTScience = group.Add(new VocabularyKey(nameof(ACTScience), "ACT - Science", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ACTSTEM = group.Add(new VocabularyKey(nameof(ACTSTEM), "ACT - STEM", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ACTWriting = group.Add(new VocabularyKey(nameof(ACTWriting), "ACT - Writing", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AlevelArt = group.Add(new VocabularyKey(nameof(AlevelArt), "A-level Art", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    GMATAnalyticalWriting = group.Add(new VocabularyKey(nameof(GMATAnalyticalWriting), "GMAT - Analytical Writing", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    GMATIntegratedReasoning = group.Add(new VocabularyKey(nameof(GMATIntegratedReasoning), "GMAT - Integrated Reasoning", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    GMATQuantitativeReasoning = group.Add(new VocabularyKey(nameof(GMATQuantitativeReasoning), "GMAT - Quantitative Reasoning", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    GMATTotal = group.Add(new VocabularyKey(nameof(GMATTotal), "GMAT - Total", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    GMATVerbalReasoning = group.Add(new VocabularyKey(nameof(GMATVerbalReasoning), "GMAT - Verbal Reasoning", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    GREAnalyticalReasoning = group.Add(new VocabularyKey(nameof(GREAnalyticalReasoning), "GRE - Analytical Reasoning", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    GREQuantitativeReasoning = group.Add(new VocabularyKey(nameof(GREQuantitativeReasoning), "GRE - Quantitative Reasoning", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    GRETotalScore = group.Add(new VocabularyKey(nameof(GRETotalScore), "GRE - Total Score", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    GREVerbalReasoning = group.Add(new VocabularyKey(nameof(GREVerbalReasoning), "GRE - Verbal Reasoning", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    IELTSCEFR = group.Add(new VocabularyKey(nameof(IELTSCEFR), "IELTS - CEFR", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IELTSListening = group.Add(new VocabularyKey(nameof(IELTSListening), "IELTS - Listening", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    IELTSOverallBandScore = group.Add(new VocabularyKey(nameof(IELTSOverallBandScore), "IELTS - Overall Band Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    IELTSReading = group.Add(new VocabularyKey(nameof(IELTSReading), "IELTS - Reading", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    IELTSSpeakingScore = group.Add(new VocabularyKey(nameof(IELTSSpeakingScore), "IELTS - Speaking Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    IELTSWriting = group.Add(new VocabularyKey(nameof(IELTSWriting), "IELTS - Writing", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SATEssayAnalysis = group.Add(new VocabularyKey(nameof(SATEssayAnalysis), "SAT Essay - Analysis", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    SATEssayReading = group.Add(new VocabularyKey(nameof(SATEssayReading), "SAT Essay - Reading", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    SATEssayWriting = group.Add(new VocabularyKey(nameof(SATEssayWriting), "SAT Essay - Writing", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    SATEvidenceBasedReadingandWritingSection = group.Add(new VocabularyKey(nameof(SATEvidenceBasedReadingandWritingSection), "SAT - Evidence-Based Reading and Writing Section", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    SATMathSection = group.Add(new VocabularyKey(nameof(SATMathSection), "SAT - Math Section", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    SATTotalScore = group.Add(new VocabularyKey(nameof(SATTotalScore), "SAT - Total Score", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TestDate = group.Add(new VocabularyKey(nameof(TestDate), "Test Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TestLocation = group.Add(new VocabularyKey(nameof(TestLocation), "Test Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TestScoreValue = group.Add(new VocabularyKey(nameof(TestScoreValue), "Test Score Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TestSource = group.Add(new VocabularyKey(nameof(TestSource), "Test Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TOEFLListeningSection = group.Add(new VocabularyKey(nameof(TOEFLListeningSection), "TOEFL - Listening Section", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TOEFLReadingSection = group.Add(new VocabularyKey(nameof(TOEFLReadingSection), "TOEFL - Reading Section", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TOEFLSpeakingSection = group.Add(new VocabularyKey(nameof(TOEFLSpeakingSection), "TOEFL - Speaking Section", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TOEFLTotalScore = group.Add(new VocabularyKey(nameof(TOEFLTotalScore), "TOEFL - Total Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    TOEFLWritingSection = group.Add(new VocabularyKey(nameof(TOEFLWritingSection), "TOEFL - Writing Section", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="StudentID"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TestTypeId"/> to Vocab 'TestType.cdm.json/TestType' with Property 'TestTypeId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ACTComposite { get; private set; }
        public VocabularyKey ACTELA { get; private set; }
        public VocabularyKey ACTEnglish { get; private set; }
        public VocabularyKey ACTEquivalentScore { get; private set; }
        public VocabularyKey ACTMath { get; private set; }
        public VocabularyKey ACTReading { get; private set; }
        public VocabularyKey ACTScience { get; private set; }
        public VocabularyKey ACTSTEM { get; private set; }
        public VocabularyKey ACTWriting { get; private set; }
        public VocabularyKey AlevelArt { get; private set; }
        public VocabularyKey GMATAnalyticalWriting { get; private set; }
        public VocabularyKey GMATIntegratedReasoning { get; private set; }
        public VocabularyKey GMATQuantitativeReasoning { get; private set; }
        public VocabularyKey GMATTotal { get; private set; }
        public VocabularyKey GMATVerbalReasoning { get; private set; }
        public VocabularyKey GREAnalyticalReasoning { get; private set; }
        public VocabularyKey GREQuantitativeReasoning { get; private set; }
        public VocabularyKey GRETotalScore { get; private set; }
        public VocabularyKey GREVerbalReasoning { get; private set; }
        public VocabularyKey IELTSCEFR { get; private set; }
        public VocabularyKey IELTSListening { get; private set; }
        public VocabularyKey IELTSOverallBandScore { get; private set; }
        public VocabularyKey IELTSReading { get; private set; }
        public VocabularyKey IELTSSpeakingScore { get; private set; }
        public VocabularyKey IELTSWriting { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SATEssayAnalysis { get; private set; }
        public VocabularyKey SATEssayReading { get; private set; }
        public VocabularyKey SATEssayWriting { get; private set; }
        public VocabularyKey SATEvidenceBasedReadingandWritingSection { get; private set; }
        public VocabularyKey SATMathSection { get; private set; }
        public VocabularyKey SATTotalScore { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TestDate { get; private set; }
        public VocabularyKey TestLocation { get; private set; }
        public VocabularyKey TestScoreId { get; private set; }
        public VocabularyKey TestScoreValue { get; private set; }
        public VocabularyKey TestSource { get; private set; }
        public VocabularyKey TOEFLListeningSection { get; private set; }
        public VocabularyKey TOEFLReadingSection { get; private set; }
        public VocabularyKey TOEFLSpeakingSection { get; private set; }
        public VocabularyKey TOEFLTotalScore { get; private set; }
        public VocabularyKey TOEFLWritingSection { get; private set; }
    }
}