using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FIDirectDebitVocabulary : SimpleVocabulary
    {
        public FIDirectDebitVocabulary()
        {
            VocabularyName = "FI Direct Debit";
            KeyPrefix = "commonDataModel.fidirectdebit";
            KeySeparator = ".";
            Grouping = "/FIDirectDebit";

            AddGroup("FIDirectDebit Details", group =>
            {
                Fi_DirectDebitId = group.Add(new VocabularyKey(nameof(Fi_DirectDebitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statecode = group.Add(new VocabularyKey(nameof(Statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statuscode = group.Add(new VocabularyKey(nameof(Statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Creditoridentifier = group.Add(new VocabularyKey(nameof(Creditoridentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Creditorname = group.Add(new VocabularyKey(nameof(Creditorname), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Debtoraccount = group.Add(new VocabularyKey(nameof(Debtoraccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Financialinstrumenttype = group.Add(new VocabularyKey(nameof(Financialinstrumenttype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegrationKey = group.Add(new VocabularyKey(nameof(IntegrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lastitemamount = group.Add(new VocabularyKey(nameof(Lastitemamount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lastitemamount_Base = group.Add(new VocabularyKey(nameof(Lastitemamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lastitemamount_default = group.Add(new VocabularyKey(nameof(Lastitemamount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lastitemdate = group.Add(new VocabularyKey(nameof(Lastitemdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lastitemstatus = group.Add(new VocabularyKey(nameof(Lastitemstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lastitemstatusreason = group.Add(new VocabularyKey(nameof(Lastitemstatusreason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Mandateenddate = group.Add(new VocabularyKey(nameof(Mandateenddate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Mandateid = group.Add(new VocabularyKey(nameof(Mandateid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Mandatelimit = group.Add(new VocabularyKey(nameof(Mandatelimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Mandatelimit_Base = group.Add(new VocabularyKey(nameof(Mandatelimit_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Mandatelimit_default = group.Add(new VocabularyKey(nameof(Mandatelimit_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Mandatestartdate = group.Add(new VocabularyKey(nameof(Mandatestartdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Nextitemamount = group.Add(new VocabularyKey(nameof(Nextitemamount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Nextitemamount_Base = group.Add(new VocabularyKey(nameof(Nextitemamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Nextitemamount_default = group.Add(new VocabularyKey(nameof(Nextitemamount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Nextitemdate = group.Add(new VocabularyKey(nameof(Nextitemdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Orderenddate = group.Add(new VocabularyKey(nameof(Orderenddate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StandingOrderAmount = group.Add(new VocabularyKey(nameof(StandingOrderAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Fi_DirectDebitId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Creditoridentifier { get; private set; }
        public VocabularyKey Creditorname { get; private set; }
        public VocabularyKey Debtoraccount { get; private set; }
        public VocabularyKey Financialinstrumenttype { get; private set; }
        public VocabularyKey IntegrationKey { get; private set; }
        public VocabularyKey Lastitemamount { get; private set; }
        public VocabularyKey Lastitemamount_Base { get; private set; }
        public VocabularyKey Lastitemamount_default { get; private set; }
        public VocabularyKey Lastitemdate { get; private set; }
        public VocabularyKey Lastitemstatus { get; private set; }
        public VocabularyKey Lastitemstatusreason { get; private set; }
        public VocabularyKey Mandateenddate { get; private set; }
        public VocabularyKey Mandateid { get; private set; }
        public VocabularyKey Mandatelimit { get; private set; }
        public VocabularyKey Mandatelimit_Base { get; private set; }
        public VocabularyKey Mandatelimit_default { get; private set; }
        public VocabularyKey Mandatestartdate { get; private set; }
        public VocabularyKey Nextitemamount { get; private set; }
        public VocabularyKey Nextitemamount_Base { get; private set; }
        public VocabularyKey Nextitemamount_default { get; private set; }
        public VocabularyKey Nextitemdate { get; private set; }
        public VocabularyKey Orderenddate { get; private set; }
        public VocabularyKey StandingOrderAmount { get; private set; }
    }
}