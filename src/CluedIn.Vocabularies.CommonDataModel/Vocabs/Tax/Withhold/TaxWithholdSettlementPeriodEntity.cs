using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdSettlementPeriodEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdSettlementPeriodEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxWithholdSettlementPeriodEntity";
            KeyPrefix = "commonDataModel.taxwithholdsettlementperiodentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdSettlementPeriodEntity";

            AddGroup("Common Data Model TaxWithholdSettlementPeriodEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentCode = group.Add(new VocabularyKey(nameof(PaymentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodUnit = group.Add(new VocabularyKey(nameof(PeriodUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QtyUnit = group.Add(new VocabularyKey(nameof(QtyUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAuthority = group.Add(new VocabularyKey(nameof(TaxAuthority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdPeriod = group.Add(new VocabularyKey(nameof(TaxWithholdPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdFromDate = group.Add(new VocabularyKey(nameof(TaxWithholdFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdToDate = group.Add(new VocabularyKey(nameof(TaxWithholdToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey PaymentCode { get; private set; }
        public VocabularyKey PeriodUnit { get; private set; }
        public VocabularyKey QtyUnit { get; private set; }
        public VocabularyKey TaxAuthority { get; private set; }
        public VocabularyKey TaxWithholdPeriod { get; private set; }
        public VocabularyKey TaxWithholdFromDate { get; private set; }
        public VocabularyKey TaxWithholdToDate { get; private set; }


    }
}