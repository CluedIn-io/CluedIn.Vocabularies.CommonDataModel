using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSShippingCarrierCustomerAccountCriterionEntityVocabulary : SimpleVocabulary
    {
        public TMSShippingCarrierCustomerAccountCriterionEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSShippingCarrierCustomerAccountCriterionEntity";
            KeyPrefix = "commonDataModel.tmsshippingcarriercustomeraccountcriterionentity";
            KeySeparator = ".";
            Grouping = "/TMSShippingCarrierCustomerAccountCriterionEntity";

            AddGroup("Common Data Model TMSShippingCarrierCustomerAccountCriterionEntity Details", group =>
            {
                ShippingCarrierServiceId = group.Add(new VocabularyKey(nameof(ShippingCarrierServiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingCarrierId = group.Add(new VocabularyKey(nameof(ShippingCarrierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingSiteId = group.Add(new VocabularyKey(nameof(ShippingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingWarehouseId = group.Add(new VocabularyKey(nameof(ShippingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingCarrierCustomerAccountNumber = group.Add(new VocabularyKey(nameof(ShippingCarrierCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ShippingCarrierServiceId { get; private set; }
public VocabularyKey ShippingCarrierId { get; private set; }
public VocabularyKey ShippingSiteId { get; private set; }
public VocabularyKey ShippingWarehouseId { get; private set; }
public VocabularyKey ShippingCarrierCustomerAccountNumber { get; private set; }


    }
}