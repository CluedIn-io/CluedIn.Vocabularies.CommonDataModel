using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DeliveryTermsEntityVocabulary : SimpleVocabulary
    {
        public DeliveryTermsEntityVocabulary()
        {
            VocabularyName = "Common Data Model DeliveryTermsEntity";
            KeyPrefix = "commonDataModel.deliverytermsentity";
            KeySeparator = ".";
            Grouping = "/DeliveryTermsEntity";

            AddGroup("Common Data Model DeliveryTermsEntity Details", group =>
            {
                TermsCode = group.Add(new VocabularyKey(nameof(TermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntrastatCode = group.Add(new VocabularyKey(nameof(IntrastatCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxLocationRole = group.Add(new VocabularyKey(nameof(SalesTaxLocationRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TermsDescription = group.Add(new VocabularyKey(nameof(TermsDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FreightChargeTerms = group.Add(new VocabularyKey(nameof(FreightChargeTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DoRetailSalesOrdersGetTransportationChargesAdded = group.Add(new VocabularyKey(nameof(DoRetailSalesOrdersGetTransportationChargesAdded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCashOnDelivery = group.Add(new VocabularyKey(nameof(IsCashOnDelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillShipmentConfirmationTransferCharges = group.Add(new VocabularyKey(nameof(WillShipmentConfirmationTransferCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceiptTransactionStatus = group.Add(new VocabularyKey(nameof(ReceiptTransactionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventoryProfile = group.Add(new VocabularyKey(nameof(InventoryProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TermsCode { get; private set; }
public VocabularyKey IntrastatCode { get; private set; }
public VocabularyKey SalesTaxLocationRole { get; private set; }
public VocabularyKey TermsDescription { get; private set; }
public VocabularyKey FreightChargeTerms { get; private set; }
public VocabularyKey DoRetailSalesOrdersGetTransportationChargesAdded { get; private set; }
public VocabularyKey IsCashOnDelivery { get; private set; }
public VocabularyKey WillShipmentConfirmationTransferCharges { get; private set; }
public VocabularyKey ReceiptTransactionStatus { get; private set; }
public VocabularyKey InventoryProfile { get; private set; }


    }
}