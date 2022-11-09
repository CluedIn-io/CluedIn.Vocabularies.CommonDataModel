using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesAgreementConfirmationLineEntityVocabulary : SimpleVocabulary
    {
        public SalesAgreementConfirmationLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesAgreementConfirmationLineEntity";
            KeyPrefix = "commonDataModel.salesagreementconfirmationlineentity";
            KeySeparator = ".";
            Grouping = "/SalesAgreementConfirmationLineEntity";

            AddGroup("Common Data Model SalesAgreementConfirmationLineEntity Details", group =>
            {
                SalesAgreementRecId = group.Add(new VocabularyKey(nameof(SalesAgreementRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesAgreementLegalEntityId = group.Add(new VocabularyKey(nameof(SalesAgreementLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesAgreementId = group.Add(new VocabularyKey(nameof(SalesAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommitmentType = group.Add(new VocabularyKey(nameof(CommitmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesProductCategoryRecId = group.Add(new VocabularyKey(nameof(SalesProductCategoryRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesProductCategoryName = group.Add(new VocabularyKey(nameof(SalesProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingSiteId = group.Add(new VocabularyKey(nameof(ShippingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingWarehouseId = group.Add(new VocabularyKey(nameof(ShippingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryProfileId = group.Add(new VocabularyKey(nameof(InventoryProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommittedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(CommittedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommittedQuantity = group.Add(new VocabularyKey(nameof(CommittedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommittedAmount = group.Add(new VocabularyKey(nameof(CommittedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Price = group.Add(new VocabularyKey(nameof(Price), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceQuantity = group.Add(new VocabularyKey(nameof(PriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDiscountPercentage = group.Add(new VocabularyKey(nameof(LineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDiscountAmount = group.Add(new VocabularyKey(nameof(LineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPriceAndDiscountFixed = group.Add(new VocabularyKey(nameof(IsPriceAndDiscountFixed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCommitmentMaximumEnforced = group.Add(new VocabularyKey(nameof(IsCommitmentMaximumEnforced), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumReleaseAmount = group.Add(new VocabularyKey(nameof(MinimumReleaseAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumReleaseAmount = group.Add(new VocabularyKey(nameof(MaximumReleaseAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectActivityNumber = group.Add(new VocabularyKey(nameof(ProjectActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CommissionSalesRepresentativeGroupId = group.Add(new VocabularyKey(nameof(CommissionSalesRepresentativeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AgreementCustomerAccountNumber = group.Add(new VocabularyKey(nameof(AgreementCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConfirmationNumber = group.Add(new VocabularyKey(nameof(ConfirmationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesAgreementConfirmationNumber = group.Add(new VocabularyKey(nameof(SalesAgreementConfirmationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConfirmationCreationDateTime = group.Add(new VocabularyKey(nameof(ConfirmationCreationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SalesAgreementRecId { get; private set; }
public VocabularyKey SalesAgreementLegalEntityId { get; private set; }
public VocabularyKey SalesAgreementId { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey CommitmentType { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey SalesProductCategoryRecId { get; private set; }
public VocabularyKey SalesProductCategoryName { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey ShippingSiteId { get; private set; }
public VocabularyKey ShippingWarehouseId { get; private set; }
public VocabularyKey InventoryProfileId { get; private set; }
public VocabularyKey CommittedCatchWeightQuantity { get; private set; }
public VocabularyKey CommittedQuantity { get; private set; }
public VocabularyKey UnitSymbol { get; private set; }
public VocabularyKey CommittedAmount { get; private set; }
public VocabularyKey Price { get; private set; }
public VocabularyKey PriceQuantity { get; private set; }
public VocabularyKey LineDiscountPercentage { get; private set; }
public VocabularyKey LineDiscountAmount { get; private set; }
public VocabularyKey IsPriceAndDiscountFixed { get; private set; }
public VocabularyKey EffectiveDate { get; private set; }
public VocabularyKey ExpirationDate { get; private set; }
public VocabularyKey IsCommitmentMaximumEnforced { get; private set; }
public VocabularyKey MinimumReleaseAmount { get; private set; }
public VocabularyKey MaximumReleaseAmount { get; private set; }
public VocabularyKey DefaultLedgerDimension { get; private set; }
public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
public VocabularyKey ProjectId { get; private set; }
public VocabularyKey ProjectActivityNumber { get; private set; }
public VocabularyKey ProjectCategoryId { get; private set; }
public VocabularyKey CommissionSalesRepresentativeGroupId { get; private set; }
public VocabularyKey DeliveryModeCode { get; private set; }
public VocabularyKey AgreementCustomerAccountNumber { get; private set; }
public VocabularyKey InvoiceCustomerAccountNumber { get; private set; }
public VocabularyKey ConfirmationNumber { get; private set; }
public VocabularyKey SalesAgreementConfirmationNumber { get; private set; }
public VocabularyKey ConfirmationCreationDateTime { get; private set; }


    }
}