using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdPeriodsEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdPeriodsEntityVocabulary()
        {
            VocabularyName = "Tax Withhold Periods Entity";
            KeyPrefix = "commonDataModel.taxwithholdperiodsentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdPeriodsEntity";

            AddGroup("TaxWithholdPeriodsEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettlementPeriod = group.Add(new VocabularyKey(nameof(SettlementPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodInterval = group.Add(new VocabularyKey(nameof(PeriodInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfUnits = group.Add(new VocabularyKey(nameof(NumberOfUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdAuthorities = group.Add(new VocabularyKey(nameof(TaxWithholdAuthorities), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxuthority = group.Add(new VocabularyKey(nameof(WithholdingTaxuthority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdAuthorities_TaxType = group.Add(new VocabularyKey(nameof(TaxWithholdAuthorities_TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey SettlementPeriod { get; private set; }
        public VocabularyKey PeriodInterval { get; private set; }
        public VocabularyKey NumberOfUnits { get; private set; }
        public VocabularyKey TaxType { get; private set; }
        public VocabularyKey TaxWithholdAuthorities { get; private set; }
        public VocabularyKey WithholdingTaxuthority { get; private set; }
        public VocabularyKey TaxWithholdAuthorities_TaxType { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey ToDate { get; private set; }
    }
}