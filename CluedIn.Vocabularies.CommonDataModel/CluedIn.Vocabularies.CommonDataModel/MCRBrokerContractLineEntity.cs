using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRBrokerContractLineEntityVocabulary : SimpleVocabulary
    {
        public MCRBrokerContractLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRBrokerContractLineEntity";
            KeyPrefix = "commonDataModel.mcrbrokercontractlineentity";
            KeySeparator = ".";
            Grouping = "/MCRBrokerContractLineEntity";

            AddGroup("Common Data Model MCRBrokerContractLineEntity Details", group =>
            {
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrokerFeeBreakValue = group.Add(new VocabularyKey(nameof(BrokerFeeBreakValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrokerFeeBreakBasis = group.Add(new VocabularyKey(nameof(BrokerFeeBreakBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrokerContractId = group.Add(new VocabularyKey(nameof(BrokerContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrokerSalesChargeCode = group.Add(new VocabularyKey(nameof(BrokerSalesChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrokerFeeValue = group.Add(new VocabularyKey(nameof(BrokerFeeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrokerFeeValueType = group.Add(new VocabularyKey(nameof(BrokerFeeValueType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerGroupId = group.Add(new VocabularyKey(nameof(CustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrokerVendorAccountNumber = group.Add(new VocabularyKey(nameof(BrokerVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrokerFeeBreakQuantity = group.Add(new VocabularyKey(nameof(BrokerFeeBreakQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrokerFeeBreakAmount = group.Add(new VocabularyKey(nameof(BrokerFeeBreakAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrokerFeeAmountPerProductUnitSold = group.Add(new VocabularyKey(nameof(BrokerFeeAmountPerProductUnitSold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrokerFeeChargeAmount = group.Add(new VocabularyKey(nameof(BrokerFeeChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrokerFeePercentage = group.Add(new VocabularyKey(nameof(BrokerFeePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountCode { get; private set; }
public VocabularyKey AccountRelation { get; private set; }
public VocabularyKey BrokerFeeBreakValue { get; private set; }
public VocabularyKey BrokerFeeBreakBasis { get; private set; }
public VocabularyKey BrokerContractId { get; private set; }
public VocabularyKey ItemCode { get; private set; }
public VocabularyKey ItemRelation { get; private set; }
public VocabularyKey BrokerSalesChargeCode { get; private set; }
public VocabularyKey SalesTaxGroupCode { get; private set; }
public VocabularyKey BrokerFeeValue { get; private set; }
public VocabularyKey BrokerFeeValueType { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }
public VocabularyKey CustomerGroupId { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey ProductGroupId { get; private set; }
public VocabularyKey BrokerVendorAccountNumber { get; private set; }
public VocabularyKey BrokerFeeBreakQuantity { get; private set; }
public VocabularyKey BrokerFeeBreakAmount { get; private set; }
public VocabularyKey BrokerFeeAmountPerProductUnitSold { get; private set; }
public VocabularyKey BrokerFeeChargeAmount { get; private set; }
public VocabularyKey BrokerFeePercentage { get; private set; }


    }
}