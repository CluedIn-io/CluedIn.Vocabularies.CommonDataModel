using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmBIWorkerTrendEntityVocabulary : SimpleVocabulary
    {
        public HcmBIWorkerTrendEntityVocabulary()
        {
            VocabularyName = "Hcm BI Worker Trend Entity";
            KeyPrefix = "commonDataModel.hcmbiworkertrendentity";
            KeySeparator = ".";
            Grouping = "/HcmBIWorkerTrendEntity";

            AddGroup("HcmBIWorkerTrendEntity Details", group =>
            {
                Age = group.Add(new VocabularyKey(nameof(Age), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Benefit = group.Add(new VocabularyKey(nameof(Benefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Compensation = group.Add(new VocabularyKey(nameof(Compensation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Demographics = group.Add(new VocabularyKey(nameof(Demographics), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Employment = group.Add(new VocabularyKey(nameof(Employment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeographicLocation = group.Add(new VocabularyKey(nameof(GeographicLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Job = group.Add(new VocabularyKey(nameof(Job), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Performance = group.Add(new VocabularyKey(nameof(Performance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportsTo = group.Add(new VocabularyKey(nameof(ReportsTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Title = group.Add(new VocabularyKey(nameof(Title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrendDate = group.Add(new VocabularyKey(nameof(TrendDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearsOfService = group.Add(new VocabularyKey(nameof(YearsOfService), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobDetailValidTo = group.Add(new VocabularyKey(nameof(JobDetailValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobDetailValidFrom = group.Add(new VocabularyKey(nameof(JobDetailValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionDetailValidFrom = group.Add(new VocabularyKey(nameof(PositionDetailValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionDetailValidTo = group.Add(new VocabularyKey(nameof(PositionDetailValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonDetailsValidFrom = group.Add(new VocabularyKey(nameof(PersonDetailsValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonDetailsValidTo = group.Add(new VocabularyKey(nameof(PersonDetailsValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentDetailValidFrom = group.Add(new VocabularyKey(nameof(EmploymentDetailValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentDetailValidTo = group.Add(new VocabularyKey(nameof(EmploymentDetailValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Age { get; private set; }
        public VocabularyKey Benefit { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey Compensation { get; private set; }
        public VocabularyKey Demographics { get; private set; }
        public VocabularyKey Employment { get; private set; }
        public VocabularyKey GeographicLocation { get; private set; }
        public VocabularyKey Job { get; private set; }
        public VocabularyKey Performance { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey ReportsTo { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey TrendDate { get; private set; }
        public VocabularyKey YearsOfService { get; private set; }
        public VocabularyKey JobDetailValidTo { get; private set; }
        public VocabularyKey JobDetailValidFrom { get; private set; }
        public VocabularyKey PositionDetailValidFrom { get; private set; }
        public VocabularyKey PositionDetailValidTo { get; private set; }
        public VocabularyKey PersonDetailsValidFrom { get; private set; }
        public VocabularyKey PersonDetailsValidTo { get; private set; }
        public VocabularyKey EmploymentDetailValidFrom { get; private set; }
        public VocabularyKey EmploymentDetailValidTo { get; private set; }
    }
}