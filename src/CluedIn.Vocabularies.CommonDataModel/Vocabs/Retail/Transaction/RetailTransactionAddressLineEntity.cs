using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionAddressLineEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionAddressLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTransactionAddressLineEntity";
            KeyPrefix = "commonDataModel.retailtransactionaddresslineentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionAddressLineEntity";

            AddGroup("Common Data Model RetailTransactionAddressLineEntity Details", group =>
            {
                AttentionToAddressLine = group.Add(new VocabularyKey(nameof(AttentionToAddressLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                County = group.Add(new VocabularyKey(nameof(County), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryName = group.Add(new VocabularyKey(nameof(DeliveryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DistrictName = group.Add(new VocabularyKey(nameof(DistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telephone = group.Add(new VocabularyKey(nameof(Telephone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Street = group.Add(new VocabularyKey(nameof(Street), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetNumber = group.Add(new VocabularyKey(nameof(StreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipCode = group.Add(new VocabularyKey(nameof(ZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelTableOMOperatingUnitId = group.Add(new VocabularyKey(nameof(RetailChannelTableOMOperatingUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AttentionToAddressLine { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey DeliveryName { get; private set; }
        public VocabularyKey DistrictName { get; private set; }
        public VocabularyKey Telephone { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey Street { get; private set; }
        public VocabularyKey StreetNumber { get; private set; }
        public VocabularyKey Terminal { get; private set; }
        public VocabularyKey TransactionNumber { get; private set; }
        public VocabularyKey ZipCode { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey RetailChannelTableOMOperatingUnitId { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }


    }
}