using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FIDirectDebitVocabulary : SimpleVocabulary
    {
        public FIDirectDebitVocabulary()
        {
            VocabularyName = "Common Data Model FIDirectDebit";
            KeyPrefix = "commonDataModel.fidirectdebit";
            KeySeparator = ".";
            Grouping = "/FIDirectDebit";

            AddGroup("Common Data Model FIDirectDebit Details", group =>
            {
                fi_DirectDebitId = group.Add(new VocabularyKey(nameof(fi_DirectDebitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
creditoridentifier = group.Add(new VocabularyKey(nameof(creditoridentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
creditorname = group.Add(new VocabularyKey(nameof(creditorname), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
debtoraccount = group.Add(new VocabularyKey(nameof(debtoraccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
financialinstrumenttype = group.Add(new VocabularyKey(nameof(financialinstrumenttype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
integrationKey = group.Add(new VocabularyKey(nameof(integrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastitemamount = group.Add(new VocabularyKey(nameof(lastitemamount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastitemamount_Base = group.Add(new VocabularyKey(nameof(lastitemamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastitemamount_default = group.Add(new VocabularyKey(nameof(lastitemamount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastitemdate = group.Add(new VocabularyKey(nameof(lastitemdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastitemstatus = group.Add(new VocabularyKey(nameof(lastitemstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lastitemstatusreason = group.Add(new VocabularyKey(nameof(lastitemstatusreason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
mandateenddate = group.Add(new VocabularyKey(nameof(mandateenddate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
mandateid = group.Add(new VocabularyKey(nameof(mandateid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
mandatelimit = group.Add(new VocabularyKey(nameof(mandatelimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
mandatelimit_Base = group.Add(new VocabularyKey(nameof(mandatelimit_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
mandatelimit_default = group.Add(new VocabularyKey(nameof(mandatelimit_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
mandatestartdate = group.Add(new VocabularyKey(nameof(mandatestartdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
nextitemamount = group.Add(new VocabularyKey(nameof(nextitemamount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
nextitemamount_Base = group.Add(new VocabularyKey(nameof(nextitemamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
nextitemamount_default = group.Add(new VocabularyKey(nameof(nextitemamount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
nextitemdate = group.Add(new VocabularyKey(nameof(nextitemdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
orderenddate = group.Add(new VocabularyKey(nameof(orderenddate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
standingOrderAmount = group.Add(new VocabularyKey(nameof(standingOrderAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey fi_DirectDebitId { get; private set; }
public VocabularyKey createdOn { get; private set; }
public VocabularyKey modifiedOn { get; private set; }
public VocabularyKey statecode { get; private set; }
public VocabularyKey statuscode { get; private set; }
public VocabularyKey importSequenceNumber { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey creditoridentifier { get; private set; }
public VocabularyKey creditorname { get; private set; }
public VocabularyKey debtoraccount { get; private set; }
public VocabularyKey financialinstrumenttype { get; private set; }
public VocabularyKey integrationKey { get; private set; }
public VocabularyKey lastitemamount { get; private set; }
public VocabularyKey lastitemamount_Base { get; private set; }
public VocabularyKey lastitemamount_default { get; private set; }
public VocabularyKey lastitemdate { get; private set; }
public VocabularyKey lastitemstatus { get; private set; }
public VocabularyKey lastitemstatusreason { get; private set; }
public VocabularyKey mandateenddate { get; private set; }
public VocabularyKey mandateid { get; private set; }
public VocabularyKey mandatelimit { get; private set; }
public VocabularyKey mandatelimit_Base { get; private set; }
public VocabularyKey mandatelimit_default { get; private set; }
public VocabularyKey mandatestartdate { get; private set; }
public VocabularyKey nextitemamount { get; private set; }
public VocabularyKey nextitemamount_Base { get; private set; }
public VocabularyKey nextitemamount_default { get; private set; }
public VocabularyKey nextitemdate { get; private set; }
public VocabularyKey orderenddate { get; private set; }
public VocabularyKey standingOrderAmount { get; private set; }


    }
}