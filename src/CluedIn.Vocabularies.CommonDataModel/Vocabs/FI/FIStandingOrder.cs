using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FIStandingOrderVocabulary : SimpleVocabulary
    {
        public FIStandingOrderVocabulary()
        {
            VocabularyName = "FIStandingOrder";
            KeyPrefix = "commonDataModel.fistandingorder";
            KeySeparator = ".";
            Grouping = "/FIStandingOrder";

            AddGroup("FIStandingOrder Details", group =>
            {
                fi_StandingOrderId = group.Add(new VocabularyKey(nameof(fi_StandingOrderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                creditoraccount = group.Add(new VocabularyKey(nameof(creditoraccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                creditorname = group.Add(new VocabularyKey(nameof(creditorname), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                dayofmonth = group.Add(new VocabularyKey(nameof(dayofmonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                dayofweek = group.Add(new VocabularyKey(nameof(dayofweek), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                debtoraccount = group.Add(new VocabularyKey(nameof(debtoraccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                financialinstrumenttype = group.Add(new VocabularyKey(nameof(financialinstrumenttype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                firstpaymentdate = group.Add(new VocabularyKey(nameof(firstpaymentdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                frequency = group.Add(new VocabularyKey(nameof(frequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                integrationKey = group.Add(new VocabularyKey(nameof(integrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastitemamount = group.Add(new VocabularyKey(nameof(lastitemamount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastitemamount_Base = group.Add(new VocabularyKey(nameof(lastitemamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastitemamount_default = group.Add(new VocabularyKey(nameof(lastitemamount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastitemdate = group.Add(new VocabularyKey(nameof(lastitemdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastitemstatus = group.Add(new VocabularyKey(nameof(lastitemstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastitemstatusreason = group.Add(new VocabularyKey(nameof(lastitemstatusreason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                nextitemamount = group.Add(new VocabularyKey(nameof(nextitemamount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                nextitemamount_Base = group.Add(new VocabularyKey(nameof(nextitemamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                nextitemamount_default = group.Add(new VocabularyKey(nameof(nextitemamount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                nextitemdate = group.Add(new VocabularyKey(nameof(nextitemdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                standingOrderAmount = group.Add(new VocabularyKey(nameof(standingOrderAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey fi_StandingOrderId { get; private set; }
        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey statecode { get; private set; }
        public VocabularyKey statuscode { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey creditoraccount { get; private set; }
        public VocabularyKey creditorname { get; private set; }
        public VocabularyKey dayofmonth { get; private set; }
        public VocabularyKey dayofweek { get; private set; }
        public VocabularyKey debtoraccount { get; private set; }
        public VocabularyKey financialinstrumenttype { get; private set; }
        public VocabularyKey firstpaymentdate { get; private set; }
        public VocabularyKey frequency { get; private set; }
        public VocabularyKey integrationKey { get; private set; }
        public VocabularyKey lastitemamount { get; private set; }
        public VocabularyKey lastitemamount_Base { get; private set; }
        public VocabularyKey lastitemamount_default { get; private set; }
        public VocabularyKey lastitemdate { get; private set; }
        public VocabularyKey lastitemstatus { get; private set; }
        public VocabularyKey lastitemstatusreason { get; private set; }
        public VocabularyKey nextitemamount { get; private set; }
        public VocabularyKey nextitemamount_Base { get; private set; }
        public VocabularyKey nextitemamount_default { get; private set; }
        public VocabularyKey nextitemdate { get; private set; }
        public VocabularyKey standingOrderAmount { get; private set; }


    }
}