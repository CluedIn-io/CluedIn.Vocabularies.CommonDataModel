using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25LedgerAccountGroupEntityVocabulary : SimpleVocabulary
    {
        public RTax25LedgerAccountGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RTax25LedgerAccountGroupEntity";
            KeyPrefix = "commonDataModel.rtax25ledgeraccountgroupentity";
            KeySeparator = ".";
            Grouping = "/RTax25LedgerAccountGroupEntity";

            AddGroup("Common Data Model RTax25LedgerAccountGroupEntity Details", group =>
            {
                AccountForFATaxes = group.Add(new VocabularyKey(nameof(AccountForFATaxes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CTA = group.Add(new VocabularyKey(nameof(CTA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CTL = group.Add(new VocabularyKey(nameof(CTL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DTA = group.Add(new VocabularyKey(nameof(DTA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DTL = group.Add(new VocabularyKey(nameof(DTL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerPostingGroup = group.Add(new VocabularyKey(nameof(LedgerPostingGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WritingOffDTA = group.Add(new VocabularyKey(nameof(WritingOffDTA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WritingOffDTL = group.Add(new VocabularyKey(nameof(WritingOffDTL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountForFATaxesDisplayValue = group.Add(new VocabularyKey(nameof(AccountForFATaxesDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CTADisplayValue = group.Add(new VocabularyKey(nameof(CTADisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CTLDisplayValue = group.Add(new VocabularyKey(nameof(CTLDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DTADisplayValue = group.Add(new VocabularyKey(nameof(DTADisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DTLDisplayValue = group.Add(new VocabularyKey(nameof(DTLDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WritingOffDTADisplayValue = group.Add(new VocabularyKey(nameof(WritingOffDTADisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WritingOffDTLDisplayValue = group.Add(new VocabularyKey(nameof(WritingOffDTLDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountForFATaxes { get; private set; }
        public VocabularyKey CTA { get; private set; }
        public VocabularyKey CTL { get; private set; }
        public VocabularyKey DTA { get; private set; }
        public VocabularyKey DTL { get; private set; }
        public VocabularyKey LedgerPostingGroup { get; private set; }
        public VocabularyKey WritingOffDTA { get; private set; }
        public VocabularyKey WritingOffDTL { get; private set; }
        public VocabularyKey AccountForFATaxesDisplayValue { get; private set; }
        public VocabularyKey CTADisplayValue { get; private set; }
        public VocabularyKey CTLDisplayValue { get; private set; }
        public VocabularyKey DTADisplayValue { get; private set; }
        public VocabularyKey DTLDisplayValue { get; private set; }
        public VocabularyKey WritingOffDTADisplayValue { get; private set; }
        public VocabularyKey WritingOffDTLDisplayValue { get; private set; }


    }
}