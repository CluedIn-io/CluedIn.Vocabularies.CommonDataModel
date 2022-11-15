using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicTaxICPDeclarationEntityVocabulary : SimpleVocabulary
    {
        public ElectronicTaxICPDeclarationEntityVocabulary()
        {
            VocabularyName = "Electronic Tax ICP Declaration Entity";
            KeyPrefix = "commonDataModel.electronictaxicpdeclarationentity";
            KeySeparator = ".";
            Grouping = "/ElectronicTaxICPDeclarationEntity";

            AddGroup("ElectronicTaxICPDeclarationEntity Details", group =>
            {
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactID = group.Add(new VocabularyKey(nameof(ContactID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telephone = group.Add(new VocabularyKey(nameof(Telephone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactType = group.Add(new VocabularyKey(nameof(ContactType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateOfCreation = group.Add(new VocabularyKey(nameof(DateOfCreation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileName = group.Add(new VocabularyKey(nameof(FileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalGroup = group.Add(new VocabularyKey(nameof(FiscalGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoutingNumber = group.Add(new VocabularyKey(nameof(RoutingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MessageID = group.Add(new VocabularyKey(nameof(MessageID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Message = group.Add(new VocabularyKey(nameof(Message), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestId = group.Add(new VocabularyKey(nameof(RequestId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Period = group.Add(new VocabularyKey(nameof(Period), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Version = group.Add(new VocabularyKey(nameof(Version), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Year = group.Add(new VocabularyKey(nameof(Year), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactInitials = group.Add(new VocabularyKey(nameof(ContactInitials), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPrefix = group.Add(new VocabularyKey(nameof(ContactPrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAmount = group.Add(new VocabularyKey(nameof(ServiceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxIntraCommTable_NL = group.Add(new VocabularyKey(nameof(TaxIntraCommTable_NL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TriangularTrade = group.Add(new VocabularyKey(nameof(TriangularTrade), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VatNum = group.Add(new VocabularyKey(nameof(VatNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressFormat = group.Add(new VocabularyKey(nameof(AddressFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ISOcode = group.Add(new VocabularyKey(nameof(ISOcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LongName = group.Add(new VocabularyKey(nameof(LongName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentCountryRegion = group.Add(new VocabularyKey(nameof(ParentCountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShortName = group.Add(new VocabularyKey(nameof(ShortName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZone = group.Add(new VocabularyKey(nameof(TimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseZipPlus4 = group.Add(new VocabularyKey(nameof(UseZipPlus4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionAmount = group.Add(new VocabularyKey(nameof(CorrectionAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionCountryRegionId = group.Add(new VocabularyKey(nameof(CorrectionCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionServiceAmount = group.Add(new VocabularyKey(nameof(CorrectionServiceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionTaxIntraCommTable_NL = group.Add(new VocabularyKey(nameof(CorrectionTaxIntraCommTable_NL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionTaxPeriod = group.Add(new VocabularyKey(nameof(CorrectionTaxPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionTriangularTrade = group.Add(new VocabularyKey(nameof(CorrectionTriangularTrade), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionVatNum = group.Add(new VocabularyKey(nameof(CorrectionVatNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionUseZipPlus4 = group.Add(new VocabularyKey(nameof(CorrectionUseZipPlus4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionAddressFormat = group.Add(new VocabularyKey(nameof(CorrectionAddressFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionCountryRegion = group.Add(new VocabularyKey(nameof(CorrectionCountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionCurrencyCode = group.Add(new VocabularyKey(nameof(CorrectionCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionISOcode = group.Add(new VocabularyKey(nameof(CorrectionISOcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionLanguageId = group.Add(new VocabularyKey(nameof(CorrectionLanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionLongName = group.Add(new VocabularyKey(nameof(CorrectionLongName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionParentCountryRegion = group.Add(new VocabularyKey(nameof(CorrectionParentCountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionShortName = group.Add(new VocabularyKey(nameof(CorrectionShortName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectionTimeZone = group.Add(new VocabularyKey(nameof(CorrectionTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyTaxID = group.Add(new VocabularyKey(nameof(CompanyTaxID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ID { get; private set; }
        public VocabularyKey ContactID { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Telephone { get; private set; }
        public VocabularyKey ContactType { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey DateOfCreation { get; private set; }
        public VocabularyKey FileName { get; private set; }
        public VocabularyKey FiscalGroup { get; private set; }
        public VocabularyKey RoutingNumber { get; private set; }
        public VocabularyKey MessageID { get; private set; }
        public VocabularyKey Message { get; private set; }
        public VocabularyKey RequestId { get; private set; }
        public VocabularyKey Period { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Version { get; private set; }
        public VocabularyKey Year { get; private set; }
        public VocabularyKey UserId { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey ContactInitials { get; private set; }
        public VocabularyKey ContactPrefix { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey ServiceAmount { get; private set; }
        public VocabularyKey TaxIntraCommTable_NL { get; private set; }
        public VocabularyKey TriangularTrade { get; private set; }
        public VocabularyKey VatNum { get; private set; }
        public VocabularyKey AddressFormat { get; private set; }
        public VocabularyKey CountryRegion { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey ISOcode { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey LongName { get; private set; }
        public VocabularyKey ParentCountryRegion { get; private set; }
        public VocabularyKey ShortName { get; private set; }
        public VocabularyKey TimeZone { get; private set; }
        public VocabularyKey UseZipPlus4 { get; private set; }
        public VocabularyKey CorrectionAmount { get; private set; }
        public VocabularyKey CorrectionCountryRegionId { get; private set; }
        public VocabularyKey CorrectionServiceAmount { get; private set; }
        public VocabularyKey CorrectionTaxIntraCommTable_NL { get; private set; }
        public VocabularyKey CorrectionTaxPeriod { get; private set; }
        public VocabularyKey CorrectionTriangularTrade { get; private set; }
        public VocabularyKey CorrectionVatNum { get; private set; }
        public VocabularyKey CorrectionUseZipPlus4 { get; private set; }
        public VocabularyKey CorrectionAddressFormat { get; private set; }
        public VocabularyKey CorrectionCountryRegion { get; private set; }
        public VocabularyKey CorrectionCurrencyCode { get; private set; }
        public VocabularyKey CorrectionISOcode { get; private set; }
        public VocabularyKey CorrectionLanguageId { get; private set; }
        public VocabularyKey CorrectionLongName { get; private set; }
        public VocabularyKey CorrectionParentCountryRegion { get; private set; }
        public VocabularyKey CorrectionShortName { get; private set; }
        public VocabularyKey CorrectionTimeZone { get; private set; }
        public VocabularyKey CompanyTaxID { get; private set; }
    }
}