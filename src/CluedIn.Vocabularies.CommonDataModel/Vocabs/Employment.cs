using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EmploymentVocabulary : SimpleVocabulary
    {
        public EmploymentVocabulary()
        {
            VocabularyName = "Common Data Model Employment";
            KeyPrefix = "commonDataModel.employment";
            KeySeparator = ".";
            Grouping = "/Employment";

            AddGroup("Common Data Model Employment Details", group =>
            {
                employmentId = group.Add(new VocabularyKey(nameof(employmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                employerName = group.Add(new VocabularyKey(nameof(employerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                city = group.Add(new VocabularyKey(nameof(city), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                countryRegion = group.Add(new VocabularyKey(nameof(countryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                employmentEndDate = group.Add(new VocabularyKey(nameof(employmentEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                employmentStartDate = group.Add(new VocabularyKey(nameof(employmentStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                employmentType = group.Add(new VocabularyKey(nameof(employmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isCurrentJob = group.Add(new VocabularyKey(nameof(isCurrentJob), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                jobTitle = group.Add(new VocabularyKey(nameof(jobTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                monthsInThisTypeOfWork = group.Add(new VocabularyKey(nameof(monthsInThisTypeOfWork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateProvince = group.Add(new VocabularyKey(nameof(stateProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                street1 = group.Add(new VocabularyKey(nameof(street1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                street2 = group.Add(new VocabularyKey(nameof(street2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                street3 = group.Add(new VocabularyKey(nameof(street3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                zipPostalCode = group.Add(new VocabularyKey(nameof(zipPostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                employmentWorkMonths = group.Add(new VocabularyKey(nameof(employmentWorkMonths), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey employmentId { get; private set; }
        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey statecode { get; private set; }
        public VocabularyKey statuscode { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey employerName { get; private set; }
        public VocabularyKey city { get; private set; }
        public VocabularyKey countryRegion { get; private set; }
        public VocabularyKey employmentEndDate { get; private set; }
        public VocabularyKey employmentStartDate { get; private set; }
        public VocabularyKey employmentType { get; private set; }
        public VocabularyKey isCurrentJob { get; private set; }
        public VocabularyKey jobTitle { get; private set; }
        public VocabularyKey monthsInThisTypeOfWork { get; private set; }
        public VocabularyKey stateProvince { get; private set; }
        public VocabularyKey street1 { get; private set; }
        public VocabularyKey street2 { get; private set; }
        public VocabularyKey street3 { get; private set; }
        public VocabularyKey zipPostalCode { get; private set; }
        public VocabularyKey employmentWorkMonths { get; private set; }


    }
}