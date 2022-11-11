using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMItemMaterialDetailEntityVocabulary : SimpleVocabulary
    {
        public HMIMItemMaterialDetailEntityVocabulary()
        {
            VocabularyName = "Common Data Model HMIMItemMaterialDetailEntity";
            KeyPrefix = "commonDataModel.hmimitemmaterialdetailentity";
            KeySeparator = ".";
            Grouping = "/HMIMItemMaterialDetailEntity";

            AddGroup("Common Data Model HMIMItemMaterialDetailEntity Details", group =>
            {
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaterialDescription = group.Add(new VocabularyKey(nameof(MaterialDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingPrintText = group.Add(new VocabularyKey(nameof(ShippingPrintText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Qty = group.Add(new VocabularyKey(nameof(Qty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Multiplier = group.Add(new VocabularyKey(nameof(Multiplier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasure = group.Add(new VocabularyKey(nameof(UnitOfMeasure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackCode = group.Add(new VocabularyKey(nameof(PackCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackCodeDescription = group.Add(new VocabularyKey(nameof(PackCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentificationCode = group.Add(new VocabularyKey(nameof(IdentificationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentificationCodeDescription = group.Add(new VocabularyKey(nameof(IdentificationCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TechnicalNameCode = group.Add(new VocabularyKey(nameof(TechnicalNameCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TechnicalNameCodeDescription = group.Add(new VocabularyKey(nameof(TechnicalNameCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TunnelCode = group.Add(new VocabularyKey(nameof(TunnelCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TunnelCodeDescription = group.Add(new VocabularyKey(nameof(TunnelCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarinePollutant = group.Add(new VocabularyKey(nameof(MarinePollutant), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnviroDangerous = group.Add(new VocabularyKey(nameof(EnviroDangerous), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LimitedQty = group.Add(new VocabularyKey(nameof(LimitedQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportCategoryCode = group.Add(new VocabularyKey(nameof(TransportCategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportCategoryCodeDescription = group.Add(new VocabularyKey(nameof(TransportCategoryCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DivisionCode = group.Add(new VocabularyKey(nameof(DivisionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DivisionCodeDescription = group.Add(new VocabularyKey(nameof(DivisionCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassCode = group.Add(new VocabularyKey(nameof(ClassCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClassCodeDescription = group.Add(new VocabularyKey(nameof(ClassCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingGroupCode = group.Add(new VocabularyKey(nameof(PackingGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingGroupCodeDescription = group.Add(new VocabularyKey(nameof(PackingGroupCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegCode = group.Add(new VocabularyKey(nameof(RegCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LabelCode = group.Add(new VocabularyKey(nameof(LabelCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LabelCodeDescription = group.Add(new VocabularyKey(nameof(LabelCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NOS = group.Add(new VocabularyKey(nameof(NOS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StowageCode = group.Add(new VocabularyKey(nameof(StowageCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StowageCodeDescription = group.Add(new VocabularyKey(nameof(StowageCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IATAStar = group.Add(new VocabularyKey(nameof(IATAStar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EMSCode = group.Add(new VocabularyKey(nameof(EMSCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EMSCodeDescription = group.Add(new VocabularyKey(nameof(EMSCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AirType = group.Add(new VocabularyKey(nameof(AirType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackInstCodePassenger = group.Add(new VocabularyKey(nameof(PackInstCodePassenger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackInstCodePassengerDescription = group.Add(new VocabularyKey(nameof(PackInstCodePassengerDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackInstCodeCargo = group.Add(new VocabularyKey(nameof(PackInstCodeCargo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackInstCodeCargoDescription = group.Add(new VocabularyKey(nameof(PackInstCodeCargoDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey MaterialDescription { get; private set; }
        public VocabularyKey ShippingPrintText { get; private set; }
        public VocabularyKey Qty { get; private set; }
        public VocabularyKey Multiplier { get; private set; }
        public VocabularyKey UnitOfMeasure { get; private set; }
        public VocabularyKey PackCode { get; private set; }
        public VocabularyKey PackCodeDescription { get; private set; }
        public VocabularyKey IdentificationCode { get; private set; }
        public VocabularyKey IdentificationCodeDescription { get; private set; }
        public VocabularyKey TechnicalNameCode { get; private set; }
        public VocabularyKey TechnicalNameCodeDescription { get; private set; }
        public VocabularyKey TunnelCode { get; private set; }
        public VocabularyKey TunnelCodeDescription { get; private set; }
        public VocabularyKey MarinePollutant { get; private set; }
        public VocabularyKey EnviroDangerous { get; private set; }
        public VocabularyKey LimitedQty { get; private set; }
        public VocabularyKey TransportCategoryCode { get; private set; }
        public VocabularyKey TransportCategoryCodeDescription { get; private set; }
        public VocabularyKey DivisionCode { get; private set; }
        public VocabularyKey DivisionCodeDescription { get; private set; }
        public VocabularyKey ClassCode { get; private set; }
        public VocabularyKey ClassCodeDescription { get; private set; }
        public VocabularyKey PackingGroupCode { get; private set; }
        public VocabularyKey PackingGroupCodeDescription { get; private set; }
        public VocabularyKey RegCode { get; private set; }
        public VocabularyKey LabelCode { get; private set; }
        public VocabularyKey LabelCodeDescription { get; private set; }
        public VocabularyKey NOS { get; private set; }
        public VocabularyKey StowageCode { get; private set; }
        public VocabularyKey StowageCodeDescription { get; private set; }
        public VocabularyKey IATAStar { get; private set; }
        public VocabularyKey EMSCode { get; private set; }
        public VocabularyKey EMSCodeDescription { get; private set; }
        public VocabularyKey AirType { get; private set; }
        public VocabularyKey PackInstCodePassenger { get; private set; }
        public VocabularyKey PackInstCodePassengerDescription { get; private set; }
        public VocabularyKey PackInstCodeCargo { get; private set; }
        public VocabularyKey PackInstCodeCargoDescription { get; private set; }


    }
}