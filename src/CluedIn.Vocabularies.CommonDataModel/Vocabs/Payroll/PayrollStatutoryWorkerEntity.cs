using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollStatutoryWorkerEntityVocabulary : SimpleVocabulary
    {
        public PayrollStatutoryWorkerEntityVocabulary()
        {
            VocabularyName = "Payroll Statutory Worker Entity";
            KeyPrefix = "commonDataModel.payrollstatutoryworkerentity";
            KeySeparator = ".";
            Grouping = "/PayrollStatutoryWorkerEntity";

            AddGroup("PayrollStatutoryWorkerEntity Details", group =>
            {
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstName = group.Add(new VocabularyKey(nameof(FirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastName = group.Add(new VocabularyKey(nameof(LastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Affix = group.Add(new VocabularyKey(nameof(Affix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetNumber = group.Add(new VocabularyKey(nameof(StreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Street = group.Add(new VocabularyKey(nameof(Street), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipCode = group.Add(new VocabularyKey(nameof(ZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                County = group.Add(new VocabularyKey(nameof(County), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Phone = group.Add(new VocabularyKey(nameof(Phone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SocialSecurityNumber = group.Add(new VocabularyKey(nameof(SocialSecurityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameValidFrom = group.Add(new VocabularyKey(nameof(NameValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameValidTo = group.Add(new VocabularyKey(nameof(NameValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey LastName { get; private set; }
        public VocabularyKey Affix { get; private set; }
        public VocabularyKey StreetNumber { get; private set; }
        public VocabularyKey Street { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey ZipCode { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey SocialSecurityNumber { get; private set; }
        public VocabularyKey NameValidFrom { get; private set; }
        public VocabularyKey NameValidTo { get; private set; }
        public VocabularyKey AddressValidFrom { get; private set; }
        public VocabularyKey AddressValidTo { get; private set; }
    }
}