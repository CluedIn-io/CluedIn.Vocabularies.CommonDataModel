using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankDocumentPostingEntityVocabulary : SimpleVocabulary
    {
        public BankDocumentPostingEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankDocumentPostingEntity";
            KeyPrefix = "commonDataModel.bankdocumentpostingentity";
            KeySeparator = ".";
            Grouping = "/BankDocumentPostingEntity";

            AddGroup("Common Data Model BankDocumentPostingEntity Details", group =>
            {
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FacilityGroup = group.Add(new VocabularyKey(nameof(FacilityGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FacilityType = group.Add(new VocabularyKey(nameof(FacilityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LGLiquidationLedgerAccount = group.Add(new VocabularyKey(nameof(LGLiquidationLedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarginLedgerAccount = group.Add(new VocabularyKey(nameof(MarginLedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiscChargesLedgerAccount = group.Add(new VocabularyKey(nameof(MiscChargesLedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettleLedgerAccount = group.Add(new VocabularyKey(nameof(SettleLedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey FacilityGroup { get; private set; }
        public VocabularyKey FacilityType { get; private set; }
        public VocabularyKey LGLiquidationLedgerAccount { get; private set; }
        public VocabularyKey MarginLedgerAccount { get; private set; }
        public VocabularyKey MiscChargesLedgerAccount { get; private set; }
        public VocabularyKey SettleLedgerAccount { get; private set; }


    }
}