using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalDocumentHeaderEntityVocabulary : SimpleVocabulary
    {
        public FiscalDocumentHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiscalDocumentHeaderEntity";
            KeyPrefix = "commonDataModel.fiscaldocumentheaderentity";
            KeySeparator = ".";
            Grouping = "/FiscalDocumentHeaderEntity";

            AddGroup("Common Data Model FiscalDocumentHeaderEntity Details", group =>
            {
                FiscalDocumentNumber = group.Add(new VocabularyKey(nameof(FiscalDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Series = group.Add(new VocabularyKey(nameof(Series), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccessKey = group.Add(new VocabularyKey(nameof(AccessKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Model = group.Add(new VocabularyKey(nameof(Model), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Specie = group.Add(new VocabularyKey(nameof(Specie), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Direction = group.Add(new VocabularyKey(nameof(Direction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedDate = group.Add(new VocabularyKey(nameof(PostedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CancelAccountingDate = group.Add(new VocabularyKey(nameof(CancelAccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Issuer = group.Add(new VocabularyKey(nameof(Issuer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentCNPJorCPF = group.Add(new VocabularyKey(nameof(FiscalEstablishmentCNPJorCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentIE = group.Add(new VocabularyKey(nameof(FiscalEstablishmentIE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentCCM = group.Add(new VocabularyKey(nameof(FiscalEstablishmentCCM), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentName = group.Add(new VocabularyKey(nameof(FiscalEstablishmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentTaxSubstitutionRegistry = group.Add(new VocabularyKey(nameof(FiscalEstablishmentTaxSubstitutionRegistry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentTelephone = group.Add(new VocabularyKey(nameof(FiscalEstablishmentTelephone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentAddress = group.Add(new VocabularyKey(nameof(FiscalEstablishmentAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyAccountType = group.Add(new VocabularyKey(nameof(ThirdPartyAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyAccount = group.Add(new VocabularyKey(nameof(ThirdPartyAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyName = group.Add(new VocabularyKey(nameof(ThirdPartyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyCNPJorCPF = group.Add(new VocabularyKey(nameof(ThirdPartyCNPJorCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyIE = group.Add(new VocabularyKey(nameof(ThirdPartyIE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyCCM = group.Add(new VocabularyKey(nameof(ThirdPartyCCM), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyTelephone = group.Add(new VocabularyKey(nameof(ThirdPartyTelephone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyFax = group.Add(new VocabularyKey(nameof(ThirdPartyFax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyEmailAccount = group.Add(new VocabularyKey(nameof(ThirdPartyEmailAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyForeignerId = group.Add(new VocabularyKey(nameof(ThirdPartyForeignerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyIsICMSContributor = group.Add(new VocabularyKey(nameof(ThirdPartyIsICMSContributor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyAddress = group.Add(new VocabularyKey(nameof(ThirdPartyAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyAddressDescription = group.Add(new VocabularyKey(nameof(ThirdPartyAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyAddressStreet = group.Add(new VocabularyKey(nameof(ThirdPartyAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyAddressStreetNumber = group.Add(new VocabularyKey(nameof(ThirdPartyAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(ThirdPartyAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyAddressDistrictName = group.Add(new VocabularyKey(nameof(ThirdPartyAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyAddressCity = group.Add(new VocabularyKey(nameof(ThirdPartyAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyAddressState = group.Add(new VocabularyKey(nameof(ThirdPartyAddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyAddressCountryRegionId = group.Add(new VocabularyKey(nameof(ThirdPartyAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(ThirdPartyAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyAddressZipCode = group.Add(new VocabularyKey(nameof(ThirdPartyAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalAmount = group.Add(new VocabularyKey(nameof(TotalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalFreight = group.Add(new VocabularyKey(nameof(TotalFreight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalInsurance = group.Add(new VocabularyKey(nameof(TotalInsurance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalOtherCharges = group.Add(new VocabularyKey(nameof(TotalOtherCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalProductsAmount = group.Add(new VocabularyKey(nameof(TotalProductsAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalServicesAmount = group.Add(new VocabularyKey(nameof(TotalServicesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountAmount = group.Add(new VocabularyKey(nameof(TotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComplementaryFiscalDocumentType = group.Add(new VocabularyKey(nameof(ComplementaryFiscalDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComplementedFiscalDocument = group.Add(new VocabularyKey(nameof(ComplementedFiscalDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComplementedFiscalDocumentNumber = group.Add(new VocabularyKey(nameof(ComplementedFiscalDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComplementedFiscalDocumentSeries = group.Add(new VocabularyKey(nameof(ComplementedFiscalDocumentSeries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComplementedFiscalDocumentDirection = group.Add(new VocabularyKey(nameof(ComplementedFiscalDocumentDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComplementedFiscalDocumentStatus = group.Add(new VocabularyKey(nameof(ComplementedFiscalDocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComplementedFiscalDocumentFiscalEstablishmentId = group.Add(new VocabularyKey(nameof(ComplementedFiscalDocumentFiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComplementedFiscalDocumentThirdPartyCNPJorCPF = group.Add(new VocabularyKey(nameof(ComplementedFiscalDocumentThirdPartyCNPJorCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryCNPJorCPF = group.Add(new VocabularyKey(nameof(DeliveryCNPJorCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryIE = group.Add(new VocabularyKey(nameof(DeliveryIE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddress = group.Add(new VocabularyKey(nameof(DeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDistrictName = group.Add(new VocabularyKey(nameof(DeliveryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressState = group.Add(new VocabularyKey(nameof(DeliveryAddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightChargeTerms = group.Add(new VocabularyKey(nameof(FreightChargeTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTerms = group.Add(new VocabularyKey(nameof(DeliveryTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModeOfDelivery = group.Add(new VocabularyKey(nameof(ModeOfDelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VehicleNumber = group.Add(new VocabularyKey(nameof(VehicleNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VehicleStateRegistered = group.Add(new VocabularyKey(nameof(VehicleStateRegistered), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CTeType = group.Add(new VocabularyKey(nameof(CTeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Carrier = group.Add(new VocabularyKey(nameof(Carrier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarrierName = group.Add(new VocabularyKey(nameof(CarrierName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarrierCNPJorCPF = group.Add(new VocabularyKey(nameof(CarrierCNPJorCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarrierIE = group.Add(new VocabularyKey(nameof(CarrierIE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarrierAddress = group.Add(new VocabularyKey(nameof(CarrierAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CityWhereServicePerformed = group.Add(new VocabularyKey(nameof(CityWhereServicePerformed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CityKeyWhereServicePerformed = group.Add(new VocabularyKey(nameof(CityKeyWhereServicePerformed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFPSCode = group.Add(new VocabularyKey(nameof(CFPSCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonComment = group.Add(new VocabularyKey(nameof(ReasonComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManualICMSSTTaxAmount = group.Add(new VocabularyKey(nameof(ManualICMSSTTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportDeclaration = group.Add(new VocabularyKey(nameof(ImportDeclaration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportDeclarationNumber = group.Add(new VocabularyKey(nameof(ImportDeclarationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumericCode = group.Add(new VocabularyKey(nameof(NumericCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationDescription = group.Add(new VocabularyKey(nameof(OperationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Brand = group.Add(new VocabularyKey(nameof(Brand), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreviousVersion = group.Add(new VocabularyKey(nameof(PreviousVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Version = group.Add(new VocabularyKey(nameof(Version), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinalUser = group.Add(new VocabularyKey(nameof(FinalUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentDateTime = group.Add(new VocabularyKey(nameof(FiscalDocumentDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentDateTimeOffset = group.Add(new VocabularyKey(nameof(FiscalDocumentDateTimeOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PresenceType = group.Add(new VocabularyKey(nameof(PresenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalSUFRAMACOFINSDiscount = group.Add(new VocabularyKey(nameof(TotalSUFRAMACOFINSDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalSUFRAMAICMSDiscount = group.Add(new VocabularyKey(nameof(TotalSUFRAMAICMSDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalSUFRAMAPISDiscount = group.Add(new VocabularyKey(nameof(TotalSUFRAMAPISDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentFormat = group.Add(new VocabularyKey(nameof(FiscalDocumentFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentDocumentType = group.Add(new VocabularyKey(nameof(PaymentDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentNumberOfInstallments = group.Add(new VocabularyKey(nameof(PaymentNumberOfInstallments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentAmount = group.Add(new VocabularyKey(nameof(PaymentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentDueDate = group.Add(new VocabularyKey(nameof(PaymentDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FiscalDocumentNumber { get; private set; }
        public VocabularyKey Series { get; private set; }
        public VocabularyKey AccessKey { get; private set; }
        public VocabularyKey Model { get; private set; }
        public VocabularyKey Specie { get; private set; }
        public VocabularyKey Direction { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey PostedDate { get; private set; }
        public VocabularyKey CancelAccountingDate { get; private set; }
        public VocabularyKey Issuer { get; private set; }
        public VocabularyKey FiscalEstablishmentId { get; private set; }
        public VocabularyKey FiscalEstablishmentCNPJorCPF { get; private set; }
        public VocabularyKey FiscalEstablishmentIE { get; private set; }
        public VocabularyKey FiscalEstablishmentCCM { get; private set; }
        public VocabularyKey FiscalEstablishmentName { get; private set; }
        public VocabularyKey FiscalEstablishmentTaxSubstitutionRegistry { get; private set; }
        public VocabularyKey FiscalEstablishmentTelephone { get; private set; }
        public VocabularyKey FiscalEstablishmentAddress { get; private set; }
        public VocabularyKey ThirdPartyAccountType { get; private set; }
        public VocabularyKey ThirdPartyAccount { get; private set; }
        public VocabularyKey ThirdPartyName { get; private set; }
        public VocabularyKey ThirdPartyCNPJorCPF { get; private set; }
        public VocabularyKey ThirdPartyIE { get; private set; }
        public VocabularyKey ThirdPartyCCM { get; private set; }
        public VocabularyKey ThirdPartyTelephone { get; private set; }
        public VocabularyKey ThirdPartyFax { get; private set; }
        public VocabularyKey ThirdPartyEmailAccount { get; private set; }
        public VocabularyKey ThirdPartyForeignerId { get; private set; }
        public VocabularyKey ThirdPartyIsICMSContributor { get; private set; }
        public VocabularyKey ThirdPartyAddress { get; private set; }
        public VocabularyKey ThirdPartyAddressDescription { get; private set; }
        public VocabularyKey ThirdPartyAddressStreet { get; private set; }
        public VocabularyKey ThirdPartyAddressStreetNumber { get; private set; }
        public VocabularyKey ThirdPartyAddressBuildingCompliment { get; private set; }
        public VocabularyKey ThirdPartyAddressDistrictName { get; private set; }
        public VocabularyKey ThirdPartyAddressCity { get; private set; }
        public VocabularyKey ThirdPartyAddressState { get; private set; }
        public VocabularyKey ThirdPartyAddressCountryRegionId { get; private set; }
        public VocabularyKey ThirdPartyAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey ThirdPartyAddressZipCode { get; private set; }
        public VocabularyKey TotalAmount { get; private set; }
        public VocabularyKey TotalFreight { get; private set; }
        public VocabularyKey TotalInsurance { get; private set; }
        public VocabularyKey TotalOtherCharges { get; private set; }
        public VocabularyKey TotalProductsAmount { get; private set; }
        public VocabularyKey TotalServicesAmount { get; private set; }
        public VocabularyKey TotalDiscountAmount { get; private set; }
        public VocabularyKey ComplementaryFiscalDocumentType { get; private set; }
        public VocabularyKey ComplementedFiscalDocument { get; private set; }
        public VocabularyKey ComplementedFiscalDocumentNumber { get; private set; }
        public VocabularyKey ComplementedFiscalDocumentSeries { get; private set; }
        public VocabularyKey ComplementedFiscalDocumentDirection { get; private set; }
        public VocabularyKey ComplementedFiscalDocumentStatus { get; private set; }
        public VocabularyKey ComplementedFiscalDocumentFiscalEstablishmentId { get; private set; }
        public VocabularyKey ComplementedFiscalDocumentThirdPartyCNPJorCPF { get; private set; }
        public VocabularyKey DeliveryCNPJorCPF { get; private set; }
        public VocabularyKey DeliveryIE { get; private set; }
        public VocabularyKey DeliveryAddress { get; private set; }
        public VocabularyKey DeliveryAddressDescription { get; private set; }
        public VocabularyKey DeliveryAddressStreet { get; private set; }
        public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
        public VocabularyKey DeliveryAddressBuildingCompliment { get; private set; }
        public VocabularyKey DeliveryAddressDistrictName { get; private set; }
        public VocabularyKey DeliveryAddressCity { get; private set; }
        public VocabularyKey DeliveryAddressState { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
        public VocabularyKey DeliveryAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey DeliveryAddressZipCode { get; private set; }
        public VocabularyKey FreightChargeTerms { get; private set; }
        public VocabularyKey DeliveryTerms { get; private set; }
        public VocabularyKey ModeOfDelivery { get; private set; }
        public VocabularyKey VehicleNumber { get; private set; }
        public VocabularyKey VehicleStateRegistered { get; private set; }
        public VocabularyKey CTeType { get; private set; }
        public VocabularyKey Carrier { get; private set; }
        public VocabularyKey CarrierName { get; private set; }
        public VocabularyKey CarrierCNPJorCPF { get; private set; }
        public VocabularyKey CarrierIE { get; private set; }
        public VocabularyKey CarrierAddress { get; private set; }
        public VocabularyKey CityWhereServicePerformed { get; private set; }
        public VocabularyKey CityKeyWhereServicePerformed { get; private set; }
        public VocabularyKey CFPSCode { get; private set; }
        public VocabularyKey ReasonComment { get; private set; }
        public VocabularyKey ManualICMSSTTaxAmount { get; private set; }
        public VocabularyKey ImportDeclaration { get; private set; }
        public VocabularyKey ImportDeclarationNumber { get; private set; }
        public VocabularyKey NumericCode { get; private set; }
        public VocabularyKey OperationDescription { get; private set; }
        public VocabularyKey Brand { get; private set; }
        public VocabularyKey PreviousVersion { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey Version { get; private set; }
        public VocabularyKey FinalUser { get; private set; }
        public VocabularyKey FiscalDocumentDateTime { get; private set; }
        public VocabularyKey FiscalDocumentDateTimeOffset { get; private set; }
        public VocabularyKey PresenceType { get; private set; }
        public VocabularyKey TotalSUFRAMACOFINSDiscount { get; private set; }
        public VocabularyKey TotalSUFRAMAICMSDiscount { get; private set; }
        public VocabularyKey TotalSUFRAMAPISDiscount { get; private set; }
        public VocabularyKey FiscalDocumentFormat { get; private set; }
        public VocabularyKey PaymentDocumentType { get; private set; }
        public VocabularyKey PaymentNumberOfInstallments { get; private set; }
        public VocabularyKey PaymentAmount { get; private set; }
        public VocabularyKey PaymentDueDate { get; private set; }
        public VocabularyKey Voucher { get; private set; }


    }
}