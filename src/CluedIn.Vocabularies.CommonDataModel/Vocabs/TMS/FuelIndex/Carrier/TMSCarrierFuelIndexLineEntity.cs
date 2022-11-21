using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSCarrierFuelIndexLineEntityVocabulary : SimpleVocabulary
    {
        public TMSCarrierFuelIndexLineEntityVocabulary()
        {
            VocabularyName = "TMS Carrier Fuel Index Line Entity";
            KeyPrefix = "commonDataModel.tmscarrierfuelindexlineentity";
            KeySeparator = ".";
            Grouping = "/TMSCarrierFuelIndexLineEntity";

            AddGroup("TMSCarrierFuelIndexLineEntity Details", group =>
            {
                CarrierFuelIndexCode = group.Add(new VocabularyKey(nameof(CarrierFuelIndexCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDateTime = group.Add(new VocabularyKey(nameof(EffectiveDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromGallonPrice = group.Add(new VocabularyKey(nameof(FromGallonPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToGallonPrice = group.Add(new VocabularyKey(nameof(ToGallonPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceCurrencyCode = group.Add(new VocabularyKey(nameof(PriceCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccessorialUnitPercentage = group.Add(new VocabularyKey(nameof(AccessorialUnitPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightSurchargeFlatRate = group.Add(new VocabularyKey(nameof(FreightSurchargeFlatRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CarrierFuelIndexCode { get; private set; }
        public VocabularyKey EffectiveDateTime { get; private set; }
        public VocabularyKey FromGallonPrice { get; private set; }
        public VocabularyKey ToGallonPrice { get; private set; }
        public VocabularyKey PriceCurrencyCode { get; private set; }
        public VocabularyKey AccessorialUnitPercentage { get; private set; }
        public VocabularyKey FreightSurchargeFlatRate { get; private set; }
    }
}