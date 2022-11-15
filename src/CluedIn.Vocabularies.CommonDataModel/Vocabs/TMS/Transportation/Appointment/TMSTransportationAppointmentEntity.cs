using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationAppointmentEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationAppointmentEntityVocabulary()
        {
            VocabularyName = "TMS Transportation Appointment Entity";
            KeyPrefix = "commonDataModel.tmstransportationappointmententity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationAppointmentEntity";

            AddGroup("TMSTransportationAppointmentEntity Details", group =>
            {
                AppointmentSiteId = group.Add(new VocabularyKey(nameof(AppointmentSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppointmentWarehouseId = group.Add(new VocabularyKey(nameof(AppointmentWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppointmentWarehouseLocationId = group.Add(new VocabularyKey(nameof(AppointmentWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppointmentId = group.Add(new VocabularyKey(nameof(AppointmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppointmentName = group.Add(new VocabularyKey(nameof(AppointmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppointmentNote = group.Add(new VocabularyKey(nameof(AppointmentNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppointmentStatus = group.Add(new VocabularyKey(nameof(AppointmentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCustomerPickupAllowed = group.Add(new VocabularyKey(nameof(IsCustomerPickupAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadId = group.Add(new VocabularyKey(nameof(LoadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedEndDateTime = group.Add(new VocabularyKey(nameof(PlannedEndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlannedStartDateTime = group.Add(new VocabularyKey(nameof(PlannedStartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductMovementDirectionRule = group.Add(new VocabularyKey(nameof(ProductMovementDirectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingCarrierVendorAccountNumber = group.Add(new VocabularyKey(nameof(ShippingCarrierVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TractorNumber = group.Add(new VocabularyKey(nameof(TractorNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrailerNumber = group.Add(new VocabularyKey(nameof(TrailerNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationAppointmentRuleId = group.Add(new VocabularyKey(nameof(TransportationAppointmentRuleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationBrokerId = group.Add(new VocabularyKey(nameof(TransportationBrokerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationCarrierId = group.Add(new VocabularyKey(nameof(TransportationCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AppointmentSiteId { get; private set; }
        public VocabularyKey AppointmentWarehouseId { get; private set; }
        public VocabularyKey AppointmentWarehouseLocationId { get; private set; }
        public VocabularyKey AppointmentId { get; private set; }
        public VocabularyKey AppointmentName { get; private set; }
        public VocabularyKey AppointmentNote { get; private set; }
        public VocabularyKey AppointmentStatus { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey IsCustomerPickupAllowed { get; private set; }
        public VocabularyKey LoadId { get; private set; }
        public VocabularyKey PlannedEndDateTime { get; private set; }
        public VocabularyKey PlannedStartDateTime { get; private set; }
        public VocabularyKey ProductMovementDirectionRule { get; private set; }
        public VocabularyKey PurchaseOrderNumber { get; private set; }
        public VocabularyKey SalesOrderNumber { get; private set; }
        public VocabularyKey ShippingCarrierVendorAccountNumber { get; private set; }
        public VocabularyKey TractorNumber { get; private set; }
        public VocabularyKey TrailerNumber { get; private set; }
        public VocabularyKey TransportationAppointmentRuleId { get; private set; }
        public VocabularyKey TransportationBrokerId { get; private set; }
        public VocabularyKey TransportationCarrierId { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
    }
}