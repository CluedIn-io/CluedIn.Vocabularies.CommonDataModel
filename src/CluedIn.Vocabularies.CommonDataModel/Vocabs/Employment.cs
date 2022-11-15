using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EmploymentVocabulary : SimpleVocabulary
    {
        public EmploymentVocabulary()
        {
            VocabularyName = "Employment";
            KeyPrefix = "commonDataModel.employment";
            KeySeparator = ".";
            Grouping = "/Employment";

            AddGroup("Employment Details", group =>
            {
                EmploymentId = group.Add(new VocabularyKey(nameof(EmploymentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statecode = group.Add(new VocabularyKey(nameof(Statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statuscode = group.Add(new VocabularyKey(nameof(Statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmployerName = group.Add(new VocabularyKey(nameof(EmployerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentEndDate = group.Add(new VocabularyKey(nameof(EmploymentEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentStartDate = group.Add(new VocabularyKey(nameof(EmploymentStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentType = group.Add(new VocabularyKey(nameof(EmploymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCurrentJob = group.Add(new VocabularyKey(nameof(IsCurrentJob), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobTitle = group.Add(new VocabularyKey(nameof(JobTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MonthsInThisTypeOfWork = group.Add(new VocabularyKey(nameof(MonthsInThisTypeOfWork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateProvince = group.Add(new VocabularyKey(nameof(StateProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Street1 = group.Add(new VocabularyKey(nameof(Street1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Street2 = group.Add(new VocabularyKey(nameof(Street2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Street3 = group.Add(new VocabularyKey(nameof(Street3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipPostalCode = group.Add(new VocabularyKey(nameof(ZipPostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentWorkMonths = group.Add(new VocabularyKey(nameof(EmploymentWorkMonths), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EmploymentId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey EmployerName { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CountryRegion { get; private set; }
        public VocabularyKey EmploymentEndDate { get; private set; }
        public VocabularyKey EmploymentStartDate { get; private set; }
        public VocabularyKey EmploymentType { get; private set; }
        public VocabularyKey IsCurrentJob { get; private set; }
        public VocabularyKey JobTitle { get; private set; }
        public VocabularyKey MonthsInThisTypeOfWork { get; private set; }
        public VocabularyKey StateProvince { get; private set; }
        public VocabularyKey Street1 { get; private set; }
        public VocabularyKey Street2 { get; private set; }
        public VocabularyKey Street3 { get; private set; }
        public VocabularyKey ZipPostalCode { get; private set; }
        public VocabularyKey EmploymentWorkMonths { get; private set; }
    }
}