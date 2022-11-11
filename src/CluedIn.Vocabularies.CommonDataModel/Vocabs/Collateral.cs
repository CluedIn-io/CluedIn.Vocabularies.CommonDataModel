using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CollateralVocabulary : SimpleVocabulary
    {
        public CollateralVocabulary()
        {
            VocabularyName = "Common Data Model Collateral";
            KeyPrefix = "commonDataModel.collateral";
            KeySeparator = ".";
            Grouping = "/Collateral";

            AddGroup("Common Data Model Collateral Details", group =>
            {
                collateralId = group.Add(new VocabularyKey(nameof(collateralId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressLine1 = group.Add(new VocabularyKey(nameof(addressLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressLine2 = group.Add(new VocabularyKey(nameof(addressLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressLine3 = group.Add(new VocabularyKey(nameof(addressLine3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                category = group.Add(new VocabularyKey(nameof(category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                city = group.Add(new VocabularyKey(nameof(city), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                countryRegion = group.Add(new VocabularyKey(nameof(countryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                latitude = group.Add(new VocabularyKey(nameof(latitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                legalDescription = group.Add(new VocabularyKey(nameof(legalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                longitude = group.Add(new VocabularyKey(nameof(longitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                numberofUnits = group.Add(new VocabularyKey(nameof(numberofUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                realEstateType = group.Add(new VocabularyKey(nameof(realEstateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateProvince = group.Add(new VocabularyKey(nameof(stateProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                yearBuilt = group.Add(new VocabularyKey(nameof(yearBuilt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZIPPostalCode = group.Add(new VocabularyKey(nameof(ZIPPostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey collateralId { get; private set; }
        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey statecode { get; private set; }
        public VocabularyKey statuscode { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey addressLine1 { get; private set; }
        public VocabularyKey addressLine2 { get; private set; }
        public VocabularyKey addressLine3 { get; private set; }
        public VocabularyKey category { get; private set; }
        public VocabularyKey city { get; private set; }
        public VocabularyKey countryRegion { get; private set; }
        public VocabularyKey latitude { get; private set; }
        public VocabularyKey legalDescription { get; private set; }
        public VocabularyKey longitude { get; private set; }
        public VocabularyKey numberofUnits { get; private set; }
        public VocabularyKey realEstateType { get; private set; }
        public VocabularyKey stateProvince { get; private set; }
        public VocabularyKey yearBuilt { get; private set; }
        public VocabularyKey ZIPPostalCode { get; private set; }


    }
}