using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxRegistrationLegislationTypesEntityVocabulary : SimpleVocabulary
    {
        public TaxRegistrationLegislationTypesEntityVocabulary()
        {
            VocabularyName = "Tax Registration Legislation Types Entity";
            KeyPrefix = "commonDataModel.taxregistrationlegislationtypesentity";
            KeySeparator = ".";
            Grouping = "/TaxRegistrationLegislationTypesEntity";

            AddGroup("TaxRegistrationLegislationTypesEntity Details", group =>
            {
                TaxRegistrationTypeApplicabilityRule = group.Add(new VocabularyKey(nameof(TaxRegistrationTypeApplicabilityRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationTypesList = group.Add(new VocabularyKey(nameof(RegistrationTypesList), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegistrationTypeApplicabilityRule_TaxRegistrationType = group.Add(new VocabularyKey(nameof(TaxRegistrationTypeApplicabilityRule_TaxRegistrationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationType = group.Add(new VocabularyKey(nameof(RegistrationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TaxRegistrationTypeApplicabilityRule { get; private set; }
        public VocabularyKey RegistrationTypesList { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey TaxRegistrationTypeApplicabilityRule_TaxRegistrationType { get; private set; }
        public VocabularyKey RegistrationType { get; private set; }
    }
}