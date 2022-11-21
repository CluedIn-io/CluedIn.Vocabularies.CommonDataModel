using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TSTimesheetLineEntityVocabulary : SimpleVocabulary
    {
        public TSTimesheetLineEntityVocabulary()
        {
            VocabularyName = "TS Timesheet Line Entity";
            KeyPrefix = "commonDataModel.tstimesheetlineentity";
            KeySeparator = ".";
            Grouping = "/TSTimesheetLineEntity";

            AddGroup("TSTimesheetLineEntity Details", group =>
            {
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineProperty = group.Add(new VocabularyKey(nameof(LineProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectDataArea = group.Add(new VocabularyKey(nameof(ProjectDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Timesheet = group.Add(new VocabularyKey(nameof(Timesheet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimesheetNumber = group.Add(new VocabularyKey(nameof(TimesheetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Favorites = group.Add(new VocabularyKey(nameof(Favorites), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjPeriodTimesheetWeek = group.Add(new VocabularyKey(nameof(ProjPeriodTimesheetWeek), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroupId = group.Add(new VocabularyKey(nameof(TaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxItemGroup = group.Add(new VocabularyKey(nameof(TaxItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalComments = group.Add(new VocabularyKey(nameof(ExternalComments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Hours = group.Add(new VocabularyKey(nameof(Hours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalComments = group.Add(new VocabularyKey(nameof(InternalComments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey LineProperty { get; private set; }
        public VocabularyKey ProjectDataArea { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey Timesheet { get; private set; }
        public VocabularyKey TimesheetNumber { get; private set; }
        public VocabularyKey Favorites { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey ActivityNumber { get; private set; }
        public VocabularyKey ProjPeriodTimesheetWeek { get; private set; }
        public VocabularyKey TaxGroupId { get; private set; }
        public VocabularyKey TaxItemGroup { get; private set; }
        public VocabularyKey ExternalComments { get; private set; }
        public VocabularyKey Hours { get; private set; }
        public VocabularyKey InternalComments { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
    }
}