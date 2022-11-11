using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PdsProductSafetyDataSheetValidityEntityVocabulary : SimpleVocabulary
    {
        public PdsProductSafetyDataSheetValidityEntityVocabulary()
        {
            VocabularyName = "Common Data Model PdsProductSafetyDataSheetValidityEntity";
            KeyPrefix = "commonDataModel.pdsproductsafetydatasheetvalidityentity";
            KeySeparator = ".";
            Grouping = "/PdsProductSafetyDataSheetValidityEntity";

            AddGroup("Common Data Model PdsProductSafetyDataSheetValidityEntity Details", group =>
            {
                ApplicableCountryRegionId = group.Add(new VocabularyKey(nameof(ApplicableCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDays = group.Add(new VocabularyKey(nameof(ExpirationDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidityDays = group.Add(new VocabularyKey(nameof(ValidityDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMinorRevisionEnforced = group.Add(new VocabularyKey(nameof(IsMinorRevisionEnforced), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ApplicableCountryRegionId { get; private set; }
        public VocabularyKey ExpirationDays { get; private set; }
        public VocabularyKey ValidityDays { get; private set; }
        public VocabularyKey IsMinorRevisionEnforced { get; private set; }


    }
}