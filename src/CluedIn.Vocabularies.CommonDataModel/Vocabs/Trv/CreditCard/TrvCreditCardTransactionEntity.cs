using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvCreditCardTransactionEntityVocabulary : SimpleVocabulary
    {
        public TrvCreditCardTransactionEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvCreditCardTransactionEntity";
            KeyPrefix = "commonDataModel.trvcreditcardtransactionentity";
            KeySeparator = ".";
            Grouping = "/TrvCreditCardTransactionEntity";

            AddGroup("Common Data Model TrvCreditCardTransactionEntity Details", group =>
            {
                Amount_CreditCardCurrency = group.Add(new VocabularyKey(nameof(Amount_CreditCardCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount_LocalCurrency = group.Add(new VocabularyKey(nameof(Amount_LocalCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessName = group.Add(new VocabularyKey(nameof(BusinessName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardNumber = group.Add(new VocabularyKey(nameof(CardNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardNumberNIKS = group.Add(new VocabularyKey(nameof(CardNumberNIKS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardType = group.Add(new VocabularyKey(nameof(CardType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryCode = group.Add(new VocabularyKey(nameof(CategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryCodesDescription = group.Add(new VocabularyKey(nameof(CategoryCodesDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CCTransUniqueID = group.Add(new VocabularyKey(nameof(CCTransUniqueID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostType = group.Add(new VocabularyKey(nameof(CostType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey(nameof(Country), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmpPayMethodRecId = group.Add(new VocabularyKey(nameof(EmpPayMethodRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchCode_CreditCardCurrency = group.Add(new VocabularyKey(nameof(ExchCode_CreditCardCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchCode_LocalCurrency = group.Add(new VocabularyKey(nameof(ExchCode_LocalCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MerchantCategoryCode = group.Add(new VocabularyKey(nameof(MerchantCategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentMethod = group.Add(new VocabularyKey(nameof(PaymentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reference = group.Add(new VocabularyKey(nameof(Reference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Town = group.Add(new VocabularyKey(nameof(Town), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transferred = group.Add(new VocabularyKey(nameof(Transferred), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TravelNo = group.Add(new VocabularyKey(nameof(TravelNo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarRentalCheckOutDate = group.Add(new VocabularyKey(nameof(CarRentalCheckOutDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckOutLocation = group.Add(new VocabularyKey(nameof(CheckOutLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DailyRentalRate = group.Add(new VocabularyKey(nameof(DailyRentalRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DaysRented = group.Add(new VocabularyKey(nameof(DaysRented), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MonthlyRentalRate = group.Add(new VocabularyKey(nameof(MonthlyRentalRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegularMileageCharges = group.Add(new VocabularyKey(nameof(RegularMileageCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RenterName = group.Add(new VocabularyKey(nameof(RenterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReservationNumber = group.Add(new VocabularyKey(nameof(ReservationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnLocation = group.Add(new VocabularyKey(nameof(ReturnLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnDate = group.Add(new VocabularyKey(nameof(ReturnDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalMiles = group.Add(new VocabularyKey(nameof(TotalMiles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VehicleClass = group.Add(new VocabularyKey(nameof(VehicleClass), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WeeklyRentalRate = group.Add(new VocabularyKey(nameof(WeeklyRentalRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepartureDate = group.Add(new VocabularyKey(nameof(DepartureDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DomesticIndicator = group.Add(new VocabularyKey(nameof(DomesticIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeTicketNumber = group.Add(new VocabularyKey(nameof(ExchangeTicketNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IssuingCarrier = group.Add(new VocabularyKey(nameof(IssuingCarrier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfLegs = group.Add(new VocabularyKey(nameof(NumberOfLegs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalTicketNumber = group.Add(new VocabularyKey(nameof(OriginalTicketNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PassengerName = group.Add(new VocabularyKey(nameof(PassengerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TicketIssueDate = group.Add(new VocabularyKey(nameof(TicketIssueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TravelAgencyCode = group.Add(new VocabularyKey(nameof(TravelAgencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TravelAgencyInvoiceNumber = group.Add(new VocabularyKey(nameof(TravelAgencyInvoiceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TravelAgencyName = group.Add(new VocabularyKey(nameof(TravelAgencyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArrivalDate = group.Add(new VocabularyKey(nameof(ArrivalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarrierCode = group.Add(new VocabularyKey(nameof(CarrierCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CityOfOrigin = group.Add(new VocabularyKey(nameof(CityOfOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepartureTax = group.Add(new VocabularyKey(nameof(DepartureTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationCity = group.Add(new VocabularyKey(nameof(DestinationCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FareAmount = group.Add(new VocabularyKey(nameof(FareAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeAmount = group.Add(new VocabularyKey(nameof(FeeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FlightNumber = group.Add(new VocabularyKey(nameof(FlightNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrvEnhancedTripLegDetail_ItineraryRecId = group.Add(new VocabularyKey(nameof(TrvEnhancedTripLegDetail_ItineraryRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceClass = group.Add(new VocabularyKey(nameof(ServiceClass), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StopOverCity = group.Add(new VocabularyKey(nameof(StopOverCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmount = group.Add(new VocabularyKey(nameof(TaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TravelDate = group.Add(new VocabularyKey(nameof(TravelDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TripLegNumber = group.Add(new VocabularyKey(nameof(TripLegNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckInDate = group.Add(new VocabularyKey(nameof(CheckInDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckOutDate = group.Add(new VocabularyKey(nameof(CheckOutDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FolioNumber = group.Add(new VocabularyKey(nameof(FolioNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GuestName = group.Add(new VocabularyKey(nameof(GuestName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GuestNumber = group.Add(new VocabularyKey(nameof(GuestNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalRoomNights = group.Add(new VocabularyKey(nameof(TotalRoomNights), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalRoomRent = group.Add(new VocabularyKey(nameof(TotalRoomRent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalTaxAmount = group.Add(new VocabularyKey(nameof(TotalTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NoShowIndicator = group.Add(new VocabularyKey(nameof(NoShowIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarRental_PBSRecid = group.Add(new VocabularyKey(nameof(CarRental_PBSRecid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Itinerary_PBSRecid = group.Add(new VocabularyKey(nameof(Itinerary_PBSRecid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Hotel_PBSRecid = group.Add(new VocabularyKey(nameof(Hotel_PBSRecid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HashedCCNumber = group.Add(new VocabularyKey(nameof(HashedCCNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Amount_CreditCardCurrency { get; private set; }
        public VocabularyKey Amount_LocalCurrency { get; private set; }
        public VocabularyKey BusinessName { get; private set; }
        public VocabularyKey CardNumber { get; private set; }
        public VocabularyKey CardNumberNIKS { get; private set; }
        public VocabularyKey CardType { get; private set; }
        public VocabularyKey CategoryCode { get; private set; }
        public VocabularyKey CategoryCodesDescription { get; private set; }
        public VocabularyKey CCTransUniqueID { get; private set; }
        public VocabularyKey CostType { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey EmpPayMethodRecId { get; private set; }
        public VocabularyKey ExchCode_CreditCardCurrency { get; private set; }
        public VocabularyKey ExchCode_LocalCurrency { get; private set; }
        public VocabularyKey MerchantCategoryCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PaymentMethod { get; private set; }
        public VocabularyKey Posted { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey Town { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey Transferred { get; private set; }
        public VocabularyKey TravelNo { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey CarRentalCheckOutDate { get; private set; }
        public VocabularyKey CheckOutLocation { get; private set; }
        public VocabularyKey DailyRentalRate { get; private set; }
        public VocabularyKey DaysRented { get; private set; }
        public VocabularyKey MonthlyRentalRate { get; private set; }
        public VocabularyKey RegularMileageCharges { get; private set; }
        public VocabularyKey RenterName { get; private set; }
        public VocabularyKey ReservationNumber { get; private set; }
        public VocabularyKey ReturnLocation { get; private set; }
        public VocabularyKey ReturnDate { get; private set; }
        public VocabularyKey TotalMiles { get; private set; }
        public VocabularyKey VehicleClass { get; private set; }
        public VocabularyKey WeeklyRentalRate { get; private set; }
        public VocabularyKey DepartureDate { get; private set; }
        public VocabularyKey DomesticIndicator { get; private set; }
        public VocabularyKey ExchangeTicketNumber { get; private set; }
        public VocabularyKey IssuingCarrier { get; private set; }
        public VocabularyKey NumberOfLegs { get; private set; }
        public VocabularyKey OriginalTicketNumber { get; private set; }
        public VocabularyKey PassengerName { get; private set; }
        public VocabularyKey TicketIssueDate { get; private set; }
        public VocabularyKey TravelAgencyCode { get; private set; }
        public VocabularyKey TravelAgencyInvoiceNumber { get; private set; }
        public VocabularyKey TravelAgencyName { get; private set; }
        public VocabularyKey ArrivalDate { get; private set; }
        public VocabularyKey CarrierCode { get; private set; }
        public VocabularyKey CityOfOrigin { get; private set; }
        public VocabularyKey DepartureTax { get; private set; }
        public VocabularyKey DestinationCity { get; private set; }
        public VocabularyKey FareAmount { get; private set; }
        public VocabularyKey FeeAmount { get; private set; }
        public VocabularyKey FlightNumber { get; private set; }
        public VocabularyKey TrvEnhancedTripLegDetail_ItineraryRecId { get; private set; }
        public VocabularyKey ServiceClass { get; private set; }
        public VocabularyKey StopOverCity { get; private set; }
        public VocabularyKey TaxAmount { get; private set; }
        public VocabularyKey TravelDate { get; private set; }
        public VocabularyKey TripLegNumber { get; private set; }
        public VocabularyKey CheckInDate { get; private set; }
        public VocabularyKey CheckOutDate { get; private set; }
        public VocabularyKey FolioNumber { get; private set; }
        public VocabularyKey GuestName { get; private set; }
        public VocabularyKey GuestNumber { get; private set; }
        public VocabularyKey TotalRoomNights { get; private set; }
        public VocabularyKey TotalRoomRent { get; private set; }
        public VocabularyKey TotalTaxAmount { get; private set; }
        public VocabularyKey NoShowIndicator { get; private set; }
        public VocabularyKey CarRental_PBSRecid { get; private set; }
        public VocabularyKey Itinerary_PBSRecid { get; private set; }
        public VocabularyKey Hotel_PBSRecid { get; private set; }
        public VocabularyKey HashedCCNumber { get; private set; }


    }
}