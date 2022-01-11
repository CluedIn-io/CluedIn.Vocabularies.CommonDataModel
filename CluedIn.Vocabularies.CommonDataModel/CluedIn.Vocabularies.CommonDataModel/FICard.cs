using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FICardVocabulary : SimpleVocabulary
    {
        public FICardVocabulary()
        {
            VocabularyName = "Common Data Model FICard";
            KeyPrefix = "commonDataModel.ficard";
            KeySeparator = ".";
            Grouping = "/FICard";

            AddGroup("Common Data Model FICard Details", group =>
            {
                fi_CardId = group.Add(new VocabularyKey(nameof(fi_CardId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
activationDate = group.Add(new VocabularyKey(nameof(activationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
cardNetwork = group.Add(new VocabularyKey(nameof(cardNetwork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
cardnumber = group.Add(new VocabularyKey(nameof(cardnumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
cardType = group.Add(new VocabularyKey(nameof(cardType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
dateoflastcashwithdrawal = group.Add(new VocabularyKey(nameof(dateoflastcashwithdrawal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
dateoflasttransaction = group.Add(new VocabularyKey(nameof(dateoflasttransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
embossingName = group.Add(new VocabularyKey(nameof(embossingName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
expiryDate = group.Add(new VocabularyKey(nameof(expiryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
financialinstrumenttype = group.Add(new VocabularyKey(nameof(financialinstrumenttype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
integrationKey = group.Add(new VocabularyKey(nameof(integrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
issueDate = group.Add(new VocabularyKey(nameof(issueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
numberofcashwithdrawal = group.Add(new VocabularyKey(nameof(numberofcashwithdrawal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
numberoftransactions = group.Add(new VocabularyKey(nameof(numberoftransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
productName = group.Add(new VocabularyKey(nameof(productName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
purchasingLimit = group.Add(new VocabularyKey(nameof(purchasingLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
purchasinglimit_Base = group.Add(new VocabularyKey(nameof(purchasinglimit_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
purchasinglimit_default = group.Add(new VocabularyKey(nameof(purchasinglimit_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
status = group.Add(new VocabularyKey(nameof(status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
withdrawalLimit = group.Add(new VocabularyKey(nameof(withdrawalLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
withdrawallimit_Base = group.Add(new VocabularyKey(nameof(withdrawallimit_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
withdrawallimit_default = group.Add(new VocabularyKey(nameof(withdrawallimit_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey fi_CardId { get; private set; }
public VocabularyKey createdOn { get; private set; }
public VocabularyKey modifiedOn { get; private set; }
public VocabularyKey statecode { get; private set; }
public VocabularyKey statuscode { get; private set; }
public VocabularyKey importSequenceNumber { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey activationDate { get; private set; }
public VocabularyKey cardNetwork { get; private set; }
public VocabularyKey cardnumber { get; private set; }
public VocabularyKey cardType { get; private set; }
public VocabularyKey dateoflastcashwithdrawal { get; private set; }
public VocabularyKey dateoflasttransaction { get; private set; }
public VocabularyKey embossingName { get; private set; }
public VocabularyKey expiryDate { get; private set; }
public VocabularyKey financialinstrumenttype { get; private set; }
public VocabularyKey integrationKey { get; private set; }
public VocabularyKey issueDate { get; private set; }
public VocabularyKey numberofcashwithdrawal { get; private set; }
public VocabularyKey numberoftransactions { get; private set; }
public VocabularyKey productName { get; private set; }
public VocabularyKey purchasingLimit { get; private set; }
public VocabularyKey purchasinglimit_Base { get; private set; }
public VocabularyKey purchasinglimit_default { get; private set; }
public VocabularyKey status { get; private set; }
public VocabularyKey withdrawalLimit { get; private set; }
public VocabularyKey withdrawallimit_Base { get; private set; }
public VocabularyKey withdrawallimit_default { get; private set; }


    }
}