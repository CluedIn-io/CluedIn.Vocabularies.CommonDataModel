using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FIOverdraftVocabulary : SimpleVocabulary
    {
        public FIOverdraftVocabulary()
        {
            VocabularyName = "Common Data Model FIOverdraft";
            KeyPrefix = "commonDataModel.fioverdraft";
            KeySeparator = ".";
            Grouping = "/FIOverdraft";

            AddGroup("Common Data Model FIOverdraft Details", group =>
            {
                fi_OverdraftId = group.Add(new VocabularyKey(nameof(fi_OverdraftId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
financialinstrumenttype = group.Add(new VocabularyKey(nameof(financialinstrumenttype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
integrationKey = group.Add(new VocabularyKey(nameof(integrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overdraftLimit = group.Add(new VocabularyKey(nameof(overdraftLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overdraftlimit_Base = group.Add(new VocabularyKey(nameof(overdraftlimit_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overdraftlimit_default = group.Add(new VocabularyKey(nameof(overdraftlimit_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overdraftLimitUsed = group.Add(new VocabularyKey(nameof(overdraftLimitUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overdraftlimitused_Base = group.Add(new VocabularyKey(nameof(overdraftlimitused_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overdraftlimitused_default = group.Add(new VocabularyKey(nameof(overdraftlimitused_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overdraftRate = group.Add(new VocabularyKey(nameof(overdraftRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey fi_OverdraftId { get; private set; }
public VocabularyKey createdOn { get; private set; }
public VocabularyKey modifiedOn { get; private set; }
public VocabularyKey statecode { get; private set; }
public VocabularyKey statuscode { get; private set; }
public VocabularyKey importSequenceNumber { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey financialinstrumenttype { get; private set; }
public VocabularyKey integrationKey { get; private set; }
public VocabularyKey overdraftLimit { get; private set; }
public VocabularyKey overdraftlimit_Base { get; private set; }
public VocabularyKey overdraftlimit_default { get; private set; }
public VocabularyKey overdraftLimitUsed { get; private set; }
public VocabularyKey overdraftlimitused_Base { get; private set; }
public VocabularyKey overdraftlimitused_default { get; private set; }
public VocabularyKey overdraftRate { get; private set; }


    }
}