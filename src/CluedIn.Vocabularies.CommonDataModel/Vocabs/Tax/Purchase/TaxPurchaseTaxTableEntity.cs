using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxPurchaseTaxTableEntityVocabulary : SimpleVocabulary
    {
        public TaxPurchaseTaxTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxPurchaseTaxTableEntity";
            KeyPrefix = "commonDataModel.taxpurchasetaxtableentity";
            KeySeparator = ".";
            Grouping = "/TaxPurchaseTaxTableEntity";

            AddGroup("Common Data Model TaxPurchaseTaxTableEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAccount = group.Add(new VocabularyKey(nameof(CostAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettleAccount = group.Add(new VocabularyKey(nameof(SettleAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAuthority = group.Add(new VocabularyKey(nameof(TaxAuthority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DutyAccount = group.Add(new VocabularyKey(nameof(DutyAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseDuty = group.Add(new VocabularyKey(nameof(PurchaseDuty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAccountDisplayValue = group.Add(new VocabularyKey(nameof(CostAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettleAccountDisplayValue = group.Add(new VocabularyKey(nameof(SettleAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DutyAccountDisplayValue = group.Add(new VocabularyKey(nameof(DutyAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Percent = group.Add(new VocabularyKey(nameof(Percent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxLimitMin = group.Add(new VocabularyKey(nameof(TaxLimitMin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxLimitMax = group.Add(new VocabularyKey(nameof(TaxLimitMax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCalcMode = group.Add(new VocabularyKey(nameof(TaxCalcMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey CostAccount { get; private set; }
        public VocabularyKey SettleAccount { get; private set; }
        public VocabularyKey TaxAuthority { get; private set; }
        public VocabularyKey DutyAccount { get; private set; }
        public VocabularyKey PurchaseDuty { get; private set; }
        public VocabularyKey CostAccountDisplayValue { get; private set; }
        public VocabularyKey SettleAccountDisplayValue { get; private set; }
        public VocabularyKey DutyAccountDisplayValue { get; private set; }
        public VocabularyKey Percent { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey TaxLimitMin { get; private set; }
        public VocabularyKey TaxLimitMax { get; private set; }
        public VocabularyKey TaxCalcMode { get; private set; }


    }
}