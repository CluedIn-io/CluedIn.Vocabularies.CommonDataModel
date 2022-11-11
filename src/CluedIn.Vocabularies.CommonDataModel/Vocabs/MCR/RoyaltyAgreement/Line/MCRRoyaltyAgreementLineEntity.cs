using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRRoyaltyAgreementLineEntityVocabulary : SimpleVocabulary
    {
        public MCRRoyaltyAgreementLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRRoyaltyAgreementLineEntity";
            KeyPrefix = "commonDataModel.mcrroyaltyagreementlineentity";
            KeySeparator = ".";
            Grouping = "/MCRRoyaltyAgreementLineEntity";

            AddGroup("Common Data Model MCRRoyaltyAgreementLineEntity Details", group =>
            {
                RoyaltyAgreementLineId = group.Add(new VocabularyKey(nameof(RoyaltyAgreementLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoyaltyAgreementId = group.Add(new VocabularyKey(nameof(RoyaltyAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalculationSearchDateType = group.Add(new VocabularyKey(nameof(CalculationSearchDateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgreementLineDescription = group.Add(new VocabularyKey(nameof(AgreementLineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgreementLineNotes = group.Add(new VocabularyKey(nameof(AgreementLineNotes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnitSymbol = group.Add(new VocabularyKey(nameof(SalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RoyaltyAgreementLineId { get; private set; }
        public VocabularyKey RoyaltyAgreementId { get; private set; }
        public VocabularyKey CalculationSearchDateType { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey AgreementLineDescription { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey AgreementLineNotes { get; private set; }
        public VocabularyKey SalesUnitSymbol { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }


    }
}