using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FIOverdraftVocabulary : SimpleVocabulary
    {
        public FIOverdraftVocabulary()
        {
            VocabularyName = "FI Overdraft";
            KeyPrefix = "commonDataModel.fioverdraft";
            KeySeparator = ".";
            Grouping = "/FIOverdraft";

            AddGroup("FIOverdraft Details", group =>
            {
                Fi_OverdraftId = group.Add(new VocabularyKey(nameof(Fi_OverdraftId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statecode = group.Add(new VocabularyKey(nameof(Statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statuscode = group.Add(new VocabularyKey(nameof(Statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Financialinstrumenttype = group.Add(new VocabularyKey(nameof(Financialinstrumenttype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegrationKey = group.Add(new VocabularyKey(nameof(IntegrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverdraftLimit = group.Add(new VocabularyKey(nameof(OverdraftLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Overdraftlimit_Base = group.Add(new VocabularyKey(nameof(Overdraftlimit_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Overdraftlimit_default = group.Add(new VocabularyKey(nameof(Overdraftlimit_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverdraftLimitUsed = group.Add(new VocabularyKey(nameof(OverdraftLimitUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Overdraftlimitused_Base = group.Add(new VocabularyKey(nameof(Overdraftlimitused_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Overdraftlimitused_default = group.Add(new VocabularyKey(nameof(Overdraftlimitused_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverdraftRate = group.Add(new VocabularyKey(nameof(OverdraftRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Fi_OverdraftId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Financialinstrumenttype { get; private set; }
        public VocabularyKey IntegrationKey { get; private set; }
        public VocabularyKey OverdraftLimit { get; private set; }
        public VocabularyKey Overdraftlimit_Base { get; private set; }
        public VocabularyKey Overdraftlimit_default { get; private set; }
        public VocabularyKey OverdraftLimitUsed { get; private set; }
        public VocabularyKey Overdraftlimitused_Base { get; private set; }
        public VocabularyKey Overdraftlimitused_default { get; private set; }
        public VocabularyKey OverdraftRate { get; private set; }
    }
}