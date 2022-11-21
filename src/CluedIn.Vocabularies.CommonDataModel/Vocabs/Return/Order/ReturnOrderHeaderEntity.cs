using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReturnOrderHeaderEntityVocabulary : SimpleVocabulary
    {
        public ReturnOrderHeaderEntityVocabulary()
        {
            VocabularyName = "Return Order Header Entity";
            KeyPrefix = "commonDataModel.returnorderheaderentity";
            KeySeparator = ".";
            Grouping = "/ReturnOrderHeaderEntity";

            AddGroup("ReturnOrderHeaderEntity Details", group =>
            {
                ReturnOrderNumber = group.Add(new VocabularyKey(nameof(ReturnOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomersOrderReference = group.Add(new VocabularyKey(nameof(CustomersOrderReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReturnWarehouseId = group.Add(new VocabularyKey(nameof(DefaultReturnWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReturnSiteId = group.Add(new VocabularyKey(nameof(DefaultReturnSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReturnProcessingStopped = group.Add(new VocabularyKey(nameof(IsReturnProcessingStopped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRequisitionNumber = group.Add(new VocabularyKey(nameof(CustomerRequisitionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnDeadline = group.Add(new VocabularyKey(nameof(ReturnDeadline), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RMANumber = group.Add(new VocabularyKey(nameof(RMANumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerReturnReasonCode = group.Add(new VocabularyKey(nameof(CustomerReturnReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReplacementSalesOrderCreated = group.Add(new VocabularyKey(nameof(IsReplacementSalesOrderCreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplacementSalesOrderNumber = group.Add(new VocabularyKey(nameof(ReplacementSalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressName = group.Add(new VocabularyKey(nameof(ReturnAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnOrderStatus = group.Add(new VocabularyKey(nameof(ReturnOrderStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnPostalAddressRecId = group.Add(new VocabularyKey(nameof(ReturnPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReturnAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsReturnAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedReturnAddress = group.Add(new VocabularyKey(nameof(FormattedReturnAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(ReturnAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressCity = group.Add(new VocabularyKey(nameof(ReturnAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressCountryRegionId = group.Add(new VocabularyKey(nameof(ReturnAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(ReturnAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressCountyId = group.Add(new VocabularyKey(nameof(ReturnAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressDescription = group.Add(new VocabularyKey(nameof(ReturnAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressDistrictName = group.Add(new VocabularyKey(nameof(ReturnAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressDunsNumber = group.Add(new VocabularyKey(nameof(ReturnAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReturnAddressPrivate = group.Add(new VocabularyKey(nameof(IsReturnAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressLatitude = group.Add(new VocabularyKey(nameof(ReturnAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressLocationId = group.Add(new VocabularyKey(nameof(ReturnAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressLongitude = group.Add(new VocabularyKey(nameof(ReturnAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressPostBox = group.Add(new VocabularyKey(nameof(ReturnAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressStateId = group.Add(new VocabularyKey(nameof(ReturnAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressStreet = group.Add(new VocabularyKey(nameof(ReturnAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressStreetNumber = group.Add(new VocabularyKey(nameof(ReturnAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressValidFrom = group.Add(new VocabularyKey(nameof(ReturnAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressValidTo = group.Add(new VocabularyKey(nameof(ReturnAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressTimeZone = group.Add(new VocabularyKey(nameof(ReturnAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressZipCode = group.Add(new VocabularyKey(nameof(ReturnAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressCityInKana = group.Add(new VocabularyKey(nameof(ReturnAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnAddressStreetInKana = group.Add(new VocabularyKey(nameof(ReturnAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ReturnOrderNumber { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey CustomersOrderReference { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey DefaultReturnWarehouseId { get; private set; }
        public VocabularyKey DefaultReturnSiteId { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey IsReturnProcessingStopped { get; private set; }
        public VocabularyKey CustomerRequisitionNumber { get; private set; }
        public VocabularyKey ReturnDeadline { get; private set; }
        public VocabularyKey RMANumber { get; private set; }
        public VocabularyKey CustomerReturnReasonCode { get; private set; }
        public VocabularyKey IsReplacementSalesOrderCreated { get; private set; }
        public VocabularyKey ReplacementSalesOrderNumber { get; private set; }
        public VocabularyKey ReturnAddressName { get; private set; }
        public VocabularyKey ReturnOrderStatus { get; private set; }
        public VocabularyKey ReturnPostalAddressRecId { get; private set; }
        public VocabularyKey IsReturnAddressOrderSpecific { get; private set; }
        public VocabularyKey FormattedReturnAddress { get; private set; }
        public VocabularyKey ReturnAddressBuildingCompliment { get; private set; }
        public VocabularyKey ReturnAddressCity { get; private set; }
        public VocabularyKey ReturnAddressCountryRegionId { get; private set; }
        public VocabularyKey ReturnAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey ReturnAddressCountyId { get; private set; }
        public VocabularyKey ReturnAddressDescription { get; private set; }
        public VocabularyKey ReturnAddressDistrictName { get; private set; }
        public VocabularyKey ReturnAddressDunsNumber { get; private set; }
        public VocabularyKey IsReturnAddressPrivate { get; private set; }
        public VocabularyKey ReturnAddressLatitude { get; private set; }
        public VocabularyKey ReturnAddressLocationId { get; private set; }
        public VocabularyKey ReturnAddressLongitude { get; private set; }
        public VocabularyKey ReturnAddressPostBox { get; private set; }
        public VocabularyKey ReturnAddressStateId { get; private set; }
        public VocabularyKey ReturnAddressStreet { get; private set; }
        public VocabularyKey ReturnAddressStreetNumber { get; private set; }
        public VocabularyKey ReturnAddressValidFrom { get; private set; }
        public VocabularyKey ReturnAddressValidTo { get; private set; }
        public VocabularyKey ReturnAddressTimeZone { get; private set; }
        public VocabularyKey ReturnAddressZipCode { get; private set; }
        public VocabularyKey ReturnAddressCityInKana { get; private set; }
        public VocabularyKey ReturnAddressStreetInKana { get; private set; }
    }
}