using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxRegistrationBaseEntityVocabulary : SimpleVocabulary
    {
        public TaxRegistrationBaseEntityVocabulary()
        {
            VocabularyName = "Tax Registration Base Entity";
            KeyPrefix = "commonDataModel.taxregistrationbaseentity";
            KeySeparator = ".";
            Grouping = "/TaxRegistrationBaseEntity";

            AddGroup("TaxRegistrationBaseEntity Details", group =>
            {
                TaxRegstrationType = group.Add(new VocabularyKey(nameof(TaxRegstrationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNumber = group.Add(new VocabularyKey(nameof(RegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirPartyLocation_Party = group.Add(new VocabularyKey(nameof(DirPartyLocation_Party), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirPartyLocation = group.Add(new VocabularyKey(nameof(DirPartyLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegistrationTypeApplicabilityRule = group.Add(new VocabularyKey(nameof(TaxRegistrationTypeApplicabilityRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Issuer = group.Add(new VocabularyKey(nameof(Issuer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IssueDate = group.Add(new VocabularyKey(nameof(IssueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Section = group.Add(new VocabularyKey(nameof(Section), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BranchNumber = group.Add(new VocabularyKey(nameof(BranchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxNatureOfAddress = group.Add(new VocabularyKey(nameof(TaxNatureOfAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TaxRegstrationType { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey LocationId { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey RegistrationNumber { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DirPartyLocation_Party { get; private set; }
        public VocabularyKey DirPartyLocation { get; private set; }
        public VocabularyKey TaxRegistrationTypeApplicabilityRule { get; private set; }
        public VocabularyKey Issuer { get; private set; }
        public VocabularyKey IssueDate { get; private set; }
        public VocabularyKey Section { get; private set; }
        public VocabularyKey BranchNumber { get; private set; }
        public VocabularyKey TaxNatureOfAddress { get; private set; }
    }
}