using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxRegistrationTypeEntityVocabulary : SimpleVocabulary
    {
        public TaxRegistrationTypeEntityVocabulary()
        {
            VocabularyName = "Tax Registration Type Entity";
            KeyPrefix = "commonDataModel.taxregistrationtypeentity";
            KeySeparator = ".";
            Grouping = "/TaxRegistrationTypeEntity";

            AddGroup("TaxRegistrationTypeEntity Details", group =>
            {
                RegistrationType = group.Add(new VocabularyKey(nameof(RegistrationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Format = group.Add(new VocabularyKey(nameof(Format), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimaryAddressRestricted = group.Add(new VocabularyKey(nameof(IsPrimaryAddressRestricted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRegistrationNumberUnique = group.Add(new VocabularyKey(nameof(IsRegistrationNumberUnique), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRegistrationNumberUpdateable = group.Add(new VocabularyKey(nameof(IsRegistrationNumberUpdateable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyTypeRestriction = group.Add(new VocabularyKey(nameof(PartyTypeRestriction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationAuthority = group.Add(new VocabularyKey(nameof(RegistrationAuthority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegistrationType = group.Add(new VocabularyKey(nameof(TaxRegistrationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RegistrationType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey Format { get; private set; }
        public VocabularyKey IsPrimaryAddressRestricted { get; private set; }
        public VocabularyKey IsRegistrationNumberUnique { get; private set; }
        public VocabularyKey IsRegistrationNumberUpdateable { get; private set; }
        public VocabularyKey PartyTypeRestriction { get; private set; }
        public VocabularyKey RegistrationAuthority { get; private set; }
        public VocabularyKey TaxRegistrationType { get; private set; }
    }
}