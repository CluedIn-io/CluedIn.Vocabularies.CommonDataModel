using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressStreetEntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressStreetEntityVocabulary()
        {
            VocabularyName = "Logistics Address Street Entity";
            KeyPrefix = "commonDataModel.logisticsaddressstreetentity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressStreetEntity";

            AddGroup("LogisticsAddressStreetEntity Details", group =>
            {
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                County = group.Add(new VocabularyKey(nameof(County), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                District = group.Add(new VocabularyKey(nameof(District), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Properties = group.Add(new VocabularyKey(nameof(Properties), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City_FK_Name = group.Add(new VocabularyKey(nameof(City_FK_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                District_FK_Name = group.Add(new VocabularyKey(nameof(District_FK_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Properties_FK_AddressTypeTable_RU = group.Add(new VocabularyKey(nameof(Properties_FK_AddressTypeTable_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Properties_FK_GniCode = group.Add(new VocabularyKey(nameof(Properties_FK_GniCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Properties_FK_IMNSDistrict = group.Add(new VocabularyKey(nameof(Properties_FK_IMNSDistrict), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Properties_FK_ObjectStatus = group.Add(new VocabularyKey(nameof(Properties_FK_ObjectStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Properties_FK_OKATO = group.Add(new VocabularyKey(nameof(Properties_FK_OKATO), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Properties_FK_ZipCode = group.Add(new VocabularyKey(nameof(Properties_FK_ZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressTypeTable_RU_AddrTypeCode = group.Add(new VocabularyKey(nameof(AddressTypeTable_RU_AddrTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipCode_FK_ZipCode = group.Add(new VocabularyKey(nameof(ZipCode_FK_ZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CountryRegion { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey District { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Properties { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey City_FK_Name { get; private set; }
        public VocabularyKey District_FK_Name { get; private set; }
        public VocabularyKey Properties_FK_AddressTypeTable_RU { get; private set; }
        public VocabularyKey Properties_FK_GniCode { get; private set; }
        public VocabularyKey Properties_FK_IMNSDistrict { get; private set; }
        public VocabularyKey Properties_FK_ObjectStatus { get; private set; }
        public VocabularyKey Properties_FK_OKATO { get; private set; }
        public VocabularyKey Properties_FK_ZipCode { get; private set; }
        public VocabularyKey AddressTypeTable_RU_AddrTypeCode { get; private set; }
        public VocabularyKey ZipCode_FK_ZipCode { get; private set; }
    }
}