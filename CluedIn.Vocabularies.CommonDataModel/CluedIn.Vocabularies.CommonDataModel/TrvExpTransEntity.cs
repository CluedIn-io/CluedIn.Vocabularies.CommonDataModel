using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvExpTransEntityVocabulary : SimpleVocabulary
    {
        public TrvExpTransEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvExpTransEntity";
            KeyPrefix = "commonDataModel.trvexptransentity";
            KeySeparator = ".";
            Grouping = "/TrvExpTransEntity";

            AddGroup("Common Data Model TrvExpTransEntity Details", group =>
            {
                ExpenseTransactionNumber = group.Add(new VocabularyKey(nameof(ExpenseTransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Reconciled = group.Add(new VocabularyKey(nameof(Reconciled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AdditionalInformation = group.Add(new VocabularyKey(nameof(AdditionalInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionAmount = group.Add(new VocabularyKey(nameof(TransactionAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountMST = group.Add(new VocabularyKey(nameof(AmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ApplyAction = group.Add(new VocabularyKey(nameof(ApplyAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ApprovalStatus = group.Add(new VocabularyKey(nameof(ApprovalStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DateApproved = group.Add(new VocabularyKey(nameof(DateApproved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashAdvanceRecId = group.Add(new VocabularyKey(nameof(CashAdvanceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActualSalesTaxAmount = group.Add(new VocabularyKey(nameof(ActualSalesTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxAmountInCompanyCurrency = group.Add(new VocabularyKey(nameof(SalesTaxAmountInCompanyCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CostOwner = group.Add(new VocabularyKey(nameof(CostOwner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseCategory = group.Add(new VocabularyKey(nameof(ExpenseCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Employee = group.Add(new VocabularyKey(nameof(Employee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditCardLocalCurrency = group.Add(new VocabularyKey(nameof(CreditCardLocalCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditCardLocalAmount = group.Add(new VocabularyKey(nameof(CreditCardLocalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PerDiemFromDate = group.Add(new VocabularyKey(nameof(PerDiemFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PerDiemToDate = group.Add(new VocabularyKey(nameof(PerDiemToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MealReduction = group.Add(new VocabularyKey(nameof(MealReduction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Breakfast = group.Add(new VocabularyKey(nameof(Breakfast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Dinner = group.Add(new VocabularyKey(nameof(Dinner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Lunch = group.Add(new VocabularyKey(nameof(Lunch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryDescription = group.Add(new VocabularyKey(nameof(CategoryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LocationOfEntertainment = group.Add(new VocabularyKey(nameof(LocationOfEntertainment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseReportNumber = group.Add(new VocabularyKey(nameof(ExpenseReportNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseType = group.Add(new VocabularyKey(nameof(ExpenseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntercompanyBilled = group.Add(new VocabularyKey(nameof(IntercompanyBilled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntercompanyProjectCategory = group.Add(new VocabularyKey(nameof(IntercompanyProjectCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntercompanyLegalEntity = group.Add(new VocabularyKey(nameof(IntercompanyLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntercompanyCurrency = group.Add(new VocabularyKey(nameof(IntercompanyCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntercompanySalesPrice = group.Add(new VocabularyKey(nameof(IntercompanySalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntercompanyTransferCurrency = group.Add(new VocabularyKey(nameof(IntercompanyTransferCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntercompanyCostPrice = group.Add(new VocabularyKey(nameof(IntercompanyCostPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceAmount = group.Add(new VocabularyKey(nameof(InvoiceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPreAuthorized = group.Add(new VocabularyKey(nameof(IsPreAuthorized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSplitToPersonal = group.Add(new VocabularyKey(nameof(IsSplitToPersonal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Mileage = group.Add(new VocabularyKey(nameof(Mileage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RatePerMile = group.Add(new VocabularyKey(nameof(RatePerMile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseLineType = group.Add(new VocabularyKey(nameof(ExpenseLineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MappedToRequisitionLine = group.Add(new VocabularyKey(nameof(MappedToRequisitionLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Merchant = group.Add(new VocabularyKey(nameof(Merchant), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MileageFromAddress = group.Add(new VocabularyKey(nameof(MileageFromAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MileageToAddress = group.Add(new VocabularyKey(nameof(MileageToAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NetTransactionAmount = group.Add(new VocabularyKey(nameof(NetTransactionAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DateRejected = group.Add(new VocabularyKey(nameof(DateRejected), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberOfPassengers = group.Add(new VocabularyKey(nameof(NumberOfPassengers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalReceiptsReceived = group.Add(new VocabularyKey(nameof(OriginalReceiptsReceived), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalSourceDocumentLine = group.Add(new VocabularyKey(nameof(OriginalSourceDocumentLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RecIdOfItemizedHeader = group.Add(new VocabularyKey(nameof(RecIdOfItemizedHeader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentMethod = group.Add(new VocabularyKey(nameof(PaymentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ImportedCreditCard = group.Add(new VocabularyKey(nameof(ImportedCreditCard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PBSRecId = group.Add(new VocabularyKey(nameof(PBSRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostingErrors = group.Add(new VocabularyKey(nameof(PostingErrors), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Billable = group.Add(new VocabularyKey(nameof(Billable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceiptNumber = group.Add(new VocabularyKey(nameof(ReceiptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceiptRequired = group.Add(new VocabularyKey(nameof(ReceiptRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceiptsAttached = group.Add(new VocabularyKey(nameof(ReceiptsAttached), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReimbursementAmount = group.Add(new VocabularyKey(nameof(ReimbursementAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceDocumentLine = group.Add(new VocabularyKey(nameof(SourceDocumentLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseSubcategory = group.Add(new VocabularyKey(nameof(ExpenseSubcategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxIncluded = group.Add(new VocabularyKey(nameof(TaxIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TicketClass = group.Add(new VocabularyKey(nameof(TicketClass), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TicketNumber = group.Add(new VocabularyKey(nameof(TicketNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TicketUsed = group.Add(new VocabularyKey(nameof(TicketUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InternalNote = group.Add(new VocabularyKey(nameof(InternalNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransRowNum = group.Add(new VocabularyKey(nameof(TransRowNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseReportRecId = group.Add(new VocabularyKey(nameof(ExpenseReportRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VehicleType = group.Add(new VocabularyKey(nameof(VehicleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MobileStatement = group.Add(new VocabularyKey(nameof(MobileStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectTransactionID = group.Add(new VocabularyKey(nameof(ProjectTransactionID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseLineLevelPosting = group.Add(new VocabularyKey(nameof(ExpenseLineLevelPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostAccountIdentification = group.Add(new VocabularyKey(nameof(PostAccountIdentification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostOffsetAccountType = group.Add(new VocabularyKey(nameof(PostOffsetAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SplitLineType = group.Add(new VocabularyKey(nameof(SplitLineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCityName = group.Add(new VocabularyKey(nameof(AddressCityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressZipCodeDetails = group.Add(new VocabularyKey(nameof(AddressZipCodeDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashAdvanceNumber = group.Add(new VocabularyKey(nameof(CashAdvanceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemizedLineTransNumber = group.Add(new VocabularyKey(nameof(ItemizedLineTransNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntityDataAreaId = group.Add(new VocabularyKey(nameof(LegalEntityDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SubCategoryCostType = group.Add(new VocabularyKey(nameof(SubCategoryCostType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SharedSubCategory = group.Add(new VocabularyKey(nameof(SharedSubCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SharedSubCategoryName = group.Add(new VocabularyKey(nameof(SharedSubCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntityRecId = group.Add(new VocabularyKey(nameof(LegalEntityRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmployeePersonnelNumber = group.Add(new VocabularyKey(nameof(EmployeePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LocationsLocation = group.Add(new VocabularyKey(nameof(LocationsLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LocationsCountryRegionId = group.Add(new VocabularyKey(nameof(LocationsCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LocationsStateId = group.Add(new VocabularyKey(nameof(LocationsStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ExpenseTransactionNumber { get; private set; }
public VocabularyKey Currency { get; private set; }
public VocabularyKey Amount { get; private set; }
public VocabularyKey Reconciled { get; private set; }
public VocabularyKey AdditionalInformation { get; private set; }
public VocabularyKey AddressCity { get; private set; }
public VocabularyKey AddressZipCode { get; private set; }
public VocabularyKey TransactionAmount { get; private set; }
public VocabularyKey AmountMST { get; private set; }
public VocabularyKey ApplyAction { get; private set; }
public VocabularyKey ApprovalStatus { get; private set; }
public VocabularyKey DateApproved { get; private set; }
public VocabularyKey Purpose { get; private set; }
public VocabularyKey CashAdvanceRecId { get; private set; }
public VocabularyKey City { get; private set; }
public VocabularyKey ActualSalesTaxAmount { get; private set; }
public VocabularyKey SalesTaxAmountInCompanyCurrency { get; private set; }
public VocabularyKey CostOwner { get; private set; }
public VocabularyKey ExpenseCategory { get; private set; }
public VocabularyKey CountryRegion { get; private set; }
public VocabularyKey Employee { get; private set; }
public VocabularyKey CreditCardLocalCurrency { get; private set; }
public VocabularyKey CreditCardLocalAmount { get; private set; }
public VocabularyKey PerDiemFromDate { get; private set; }
public VocabularyKey PerDiemToDate { get; private set; }
public VocabularyKey MealReduction { get; private set; }
public VocabularyKey Breakfast { get; private set; }
public VocabularyKey Dinner { get; private set; }
public VocabularyKey Lunch { get; private set; }
public VocabularyKey Dimension { get; private set; }
public VocabularyKey CategoryDescription { get; private set; }
public VocabularyKey LocationOfEntertainment { get; private set; }
public VocabularyKey ExchangeRate { get; private set; }
public VocabularyKey ExpenseReportNumber { get; private set; }
public VocabularyKey ExpenseType { get; private set; }
public VocabularyKey IntercompanyBilled { get; private set; }
public VocabularyKey IntercompanyProjectCategory { get; private set; }
public VocabularyKey IntercompanyLegalEntity { get; private set; }
public VocabularyKey IntercompanyCurrency { get; private set; }
public VocabularyKey IntercompanySalesPrice { get; private set; }
public VocabularyKey IntercompanyTransferCurrency { get; private set; }
public VocabularyKey IntercompanyCostPrice { get; private set; }
public VocabularyKey InvoiceAmount { get; private set; }
public VocabularyKey IsPreAuthorized { get; private set; }
public VocabularyKey IsSplitToPersonal { get; private set; }
public VocabularyKey Mileage { get; private set; }
public VocabularyKey RatePerMile { get; private set; }
public VocabularyKey LegalEntity { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey ExpenseLineType { get; private set; }
public VocabularyKey MappedToRequisitionLine { get; private set; }
public VocabularyKey Merchant { get; private set; }
public VocabularyKey MileageFromAddress { get; private set; }
public VocabularyKey MileageToAddress { get; private set; }
public VocabularyKey NetTransactionAmount { get; private set; }
public VocabularyKey DateRejected { get; private set; }
public VocabularyKey NumberOfPassengers { get; private set; }
public VocabularyKey OriginalReceiptsReceived { get; private set; }
public VocabularyKey OriginalSourceDocumentLine { get; private set; }
public VocabularyKey RecIdOfItemizedHeader { get; private set; }
public VocabularyKey PaymentMethod { get; private set; }
public VocabularyKey ImportedCreditCard { get; private set; }
public VocabularyKey PBSRecId { get; private set; }
public VocabularyKey PostingErrors { get; private set; }
public VocabularyKey ActivityNumber { get; private set; }
public VocabularyKey ProjectID { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey Billable { get; private set; }
public VocabularyKey ReceiptNumber { get; private set; }
public VocabularyKey ReceiptRequired { get; private set; }
public VocabularyKey ReceiptsAttached { get; private set; }
public VocabularyKey Company { get; private set; }
public VocabularyKey ReimbursementAmount { get; private set; }
public VocabularyKey SourceDocumentLine { get; private set; }
public VocabularyKey ExpenseSubcategory { get; private set; }
public VocabularyKey SalesTaxGroup { get; private set; }
public VocabularyKey TaxIncluded { get; private set; }
public VocabularyKey ItemSalesTaxGroup { get; private set; }
public VocabularyKey TicketClass { get; private set; }
public VocabularyKey TicketNumber { get; private set; }
public VocabularyKey TicketUsed { get; private set; }
public VocabularyKey InternalNote { get; private set; }
public VocabularyKey TransactionDate { get; private set; }
public VocabularyKey TransRowNum { get; private set; }
public VocabularyKey ExpenseReportRecId { get; private set; }
public VocabularyKey Location { get; private set; }
public VocabularyKey VehicleType { get; private set; }
public VocabularyKey Voucher { get; private set; }
public VocabularyKey MobileStatement { get; private set; }
public VocabularyKey ProjectTransactionID { get; private set; }
public VocabularyKey AddressState { get; private set; }
public VocabularyKey ExpenseLineLevelPosting { get; private set; }
public VocabularyKey PostAccountIdentification { get; private set; }
public VocabularyKey PostOffsetAccountType { get; private set; }
public VocabularyKey SplitLineType { get; private set; }
public VocabularyKey AddressCityName { get; private set; }
public VocabularyKey AddressZipCodeDetails { get; private set; }
public VocabularyKey CashAdvanceNumber { get; private set; }
public VocabularyKey ItemizedLineTransNumber { get; private set; }
public VocabularyKey LegalEntityDataAreaId { get; private set; }
public VocabularyKey SubCategoryCostType { get; private set; }
public VocabularyKey SharedSubCategory { get; private set; }
public VocabularyKey SharedSubCategoryName { get; private set; }
public VocabularyKey LegalEntityRecId { get; private set; }
public VocabularyKey EmployeePersonnelNumber { get; private set; }
public VocabularyKey LocationsLocation { get; private set; }
public VocabularyKey LocationsCountryRegionId { get; private set; }
public VocabularyKey LocationsStateId { get; private set; }
public VocabularyKey DimensionDisplayValue { get; private set; }


    }
}