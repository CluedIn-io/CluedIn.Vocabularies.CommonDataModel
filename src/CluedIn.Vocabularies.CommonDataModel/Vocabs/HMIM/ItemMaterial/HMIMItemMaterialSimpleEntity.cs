using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMItemMaterialSimpleEntityVocabulary : SimpleVocabulary
    {
        public HMIMItemMaterialSimpleEntityVocabulary()
        {
            VocabularyName = "Common Data Model HMIMItemMaterialSimpleEntity";
            KeyPrefix = "commonDataModel.hmimitemmaterialsimpleentity";
            KeySeparator = ".";
            Grouping = "/HMIMItemMaterialSimpleEntity";

            AddGroup("Common Data Model HMIMItemMaterialSimpleEntity Details", group =>
            {
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaterialCode = group.Add(new VocabularyKey(nameof(MaterialCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaterialDescription = group.Add(new VocabularyKey(nameof(MaterialDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassGroupCode = group.Add(new VocabularyKey(nameof(ClassGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingPrintText = group.Add(new VocabularyKey(nameof(ShippingPrintText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Qty = group.Add(new VocabularyKey(nameof(Qty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Multiplier = group.Add(new VocabularyKey(nameof(Multiplier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasure = group.Add(new VocabularyKey(nameof(UnitOfMeasure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackCode = group.Add(new VocabularyKey(nameof(PackCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentificationCode = group.Add(new VocabularyKey(nameof(IdentificationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TechnicalNameCode = group.Add(new VocabularyKey(nameof(TechnicalNameCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TunnelCode = group.Add(new VocabularyKey(nameof(TunnelCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarinePollutant = group.Add(new VocabularyKey(nameof(MarinePollutant), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnviroDangerous = group.Add(new VocabularyKey(nameof(EnviroDangerous), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LimitedQty = group.Add(new VocabularyKey(nameof(LimitedQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportCategoryCode = group.Add(new VocabularyKey(nameof(TransportCategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DivisionCode = group.Add(new VocabularyKey(nameof(DivisionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassCode = group.Add(new VocabularyKey(nameof(ClassCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingGroupCode = group.Add(new VocabularyKey(nameof(PackingGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegCode = group.Add(new VocabularyKey(nameof(RegCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LabelCode = group.Add(new VocabularyKey(nameof(LabelCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NOS = group.Add(new VocabularyKey(nameof(NOS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StowageCode = group.Add(new VocabularyKey(nameof(StowageCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IATAStar = group.Add(new VocabularyKey(nameof(IATAStar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EMSCode = group.Add(new VocabularyKey(nameof(EMSCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AirType = group.Add(new VocabularyKey(nameof(AirType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackInstCodePassenger = group.Add(new VocabularyKey(nameof(PackInstCodePassenger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackInstCodeCargo = group.Add(new VocabularyKey(nameof(PackInstCodeCargo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey MaterialCode { get; private set; }
        public VocabularyKey MaterialDescription { get; private set; }
        public VocabularyKey ClassGroupCode { get; private set; }
        public VocabularyKey ShippingPrintText { get; private set; }
        public VocabularyKey Qty { get; private set; }
        public VocabularyKey Multiplier { get; private set; }
        public VocabularyKey UnitOfMeasure { get; private set; }
        public VocabularyKey PackCode { get; private set; }
        public VocabularyKey IdentificationCode { get; private set; }
        public VocabularyKey TechnicalNameCode { get; private set; }
        public VocabularyKey TunnelCode { get; private set; }
        public VocabularyKey MarinePollutant { get; private set; }
        public VocabularyKey EnviroDangerous { get; private set; }
        public VocabularyKey LimitedQty { get; private set; }
        public VocabularyKey TransportCategoryCode { get; private set; }
        public VocabularyKey DivisionCode { get; private set; }
        public VocabularyKey ClassCode { get; private set; }
        public VocabularyKey PackingGroupCode { get; private set; }
        public VocabularyKey RegCode { get; private set; }
        public VocabularyKey LabelCode { get; private set; }
        public VocabularyKey NOS { get; private set; }
        public VocabularyKey StowageCode { get; private set; }
        public VocabularyKey IATAStar { get; private set; }
        public VocabularyKey EMSCode { get; private set; }
        public VocabularyKey AirType { get; private set; }
        public VocabularyKey PackInstCodePassenger { get; private set; }
        public VocabularyKey PackInstCodeCargo { get; private set; }


    }
}