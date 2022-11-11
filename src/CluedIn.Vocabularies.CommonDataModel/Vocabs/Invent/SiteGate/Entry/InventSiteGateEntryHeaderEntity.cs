using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventSiteGateEntryHeaderEntityVocabulary : SimpleVocabulary
    {
        public InventSiteGateEntryHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventSiteGateEntryHeaderEntity";
            KeyPrefix = "commonDataModel.inventsitegateentryheaderentity";
            KeySeparator = ".";
            Grouping = "/InventSiteGateEntryHeaderEntity";

            AddGroup("Common Data Model InventSiteGateEntryHeaderEntity Details", group =>
            {
                ApproverEmployee = group.Add(new VocabularyKey(nameof(ApproverEmployee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArrivalDateAndTime = group.Add(new VocabularyKey(nameof(ArrivalDateAndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChallanDate = group.Add(new VocabularyKey(nameof(ChallanDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChallanNumber = group.Add(new VocabularyKey(nameof(ChallanNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DriverMobilePhone = group.Add(new VocabularyKey(nameof(DriverMobilePhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GateEntry = group.Add(new VocabularyKey(nameof(GateEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExitDateAndTime = group.Add(new VocabularyKey(nameof(ExitDateAndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventLocationId = group.Add(new VocabularyKey(nameof(InventLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventSiteGate = group.Add(new VocabularyKey(nameof(InventSiteGate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Origin = group.Add(new VocabularyKey(nameof(Origin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceDocumentType = group.Add(new VocabularyKey(nameof(ReferenceDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceParty = group.Add(new VocabularyKey(nameof(ReferenceParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RGPNumber = group.Add(new VocabularyKey(nameof(RGPNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SkipMeasurement = group.Add(new VocabularyKey(nameof(SkipMeasurement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transporter = group.Add(new VocabularyKey(nameof(Transporter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DriverName = group.Add(new VocabularyKey(nameof(DriverName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationReceiptDate = group.Add(new VocabularyKey(nameof(TransportationReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationReceiptNumber = group.Add(new VocabularyKey(nameof(TransportationReceiptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GateEntryType = group.Add(new VocabularyKey(nameof(GateEntryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VehicleNumber = group.Add(new VocabularyKey(nameof(VehicleNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FactoryGate = group.Add(new VocabularyKey(nameof(FactoryGate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Site = group.Add(new VocabularyKey(nameof(Site), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ApproverEmployee { get; private set; }
        public VocabularyKey ArrivalDateAndTime { get; private set; }
        public VocabularyKey ChallanDate { get; private set; }
        public VocabularyKey ChallanNumber { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DriverMobilePhone { get; private set; }
        public VocabularyKey GateEntry { get; private set; }
        public VocabularyKey ExitDateAndTime { get; private set; }
        public VocabularyKey InventLocationId { get; private set; }
        public VocabularyKey InventSiteGate { get; private set; }
        public VocabularyKey Origin { get; private set; }
        public VocabularyKey ReferenceDocumentType { get; private set; }
        public VocabularyKey ReferenceParty { get; private set; }
        public VocabularyKey RGPNumber { get; private set; }
        public VocabularyKey SkipMeasurement { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Transporter { get; private set; }
        public VocabularyKey DriverName { get; private set; }
        public VocabularyKey TransportationReceiptDate { get; private set; }
        public VocabularyKey TransportationReceiptNumber { get; private set; }
        public VocabularyKey GateEntryType { get; private set; }
        public VocabularyKey VehicleNumber { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey FactoryGate { get; private set; }
        public VocabularyKey Site { get; private set; }


    }
}