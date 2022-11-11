using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesTradeAllowanceAgreementPeriodEntityVocabulary : SimpleVocabulary
    {
        public SalesTradeAllowanceAgreementPeriodEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesTradeAllowanceAgreementPeriodEntity";
            KeyPrefix = "commonDataModel.salestradeallowanceagreementperiodentity";
            KeySeparator = ".";
            Grouping = "/SalesTradeAllowanceAgreementPeriodEntity";

            AddGroup("Common Data Model SalesTradeAllowanceAgreementPeriodEntity Details", group =>
            {
                ToOrderDate = group.Add(new VocabularyKey(nameof(ToOrderDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromOrderDate = group.Add(new VocabularyKey(nameof(FromOrderDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToLumpSumPayoutDate = group.Add(new VocabularyKey(nameof(ToLumpSumPayoutDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromLumpSumPayoutDate = group.Add(new VocabularyKey(nameof(FromLumpSumPayoutDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodName = group.Add(new VocabularyKey(nameof(PeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToRequestedShipDate = group.Add(new VocabularyKey(nameof(ToRequestedShipDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromRequestedShipDate = group.Add(new VocabularyKey(nameof(FromRequestedShipDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToRequestedReceiptDate = group.Add(new VocabularyKey(nameof(ToRequestedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromRequestedReceiptDate = group.Add(new VocabularyKey(nameof(FromRequestedReceiptDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ToOrderDate { get; private set; }
        public VocabularyKey FromOrderDate { get; private set; }
        public VocabularyKey ToLumpSumPayoutDate { get; private set; }
        public VocabularyKey FromLumpSumPayoutDate { get; private set; }
        public VocabularyKey PeriodName { get; private set; }
        public VocabularyKey ToRequestedShipDate { get; private set; }
        public VocabularyKey FromRequestedShipDate { get; private set; }
        public VocabularyKey ToRequestedReceiptDate { get; private set; }
        public VocabularyKey FromRequestedReceiptDate { get; private set; }


    }
}