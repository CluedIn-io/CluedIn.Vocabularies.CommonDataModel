using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventSiteGateEntryLineEntityVocabulary : SimpleVocabulary
    {
        public InventSiteGateEntryLineEntityVocabulary()
        {
            VocabularyName = "Invent Site Gate Entry Line Entity";
            KeyPrefix = "commonDataModel.inventsitegateentrylineentity";
            KeySeparator = ".";
            Grouping = "/InventSiteGateEntryLineEntity";

            AddGroup("InventSiteGateEntryLineEntity Details", group =>
            {
                ChallanQty = group.Add(new VocabularyKey(nameof(ChallanQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryUnit = group.Add(new VocabularyKey(nameof(InventoryUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventSiteGateEntry = group.Add(new VocabularyKey(nameof(InventSiteGateEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MeasuredQty = group.Add(new VocabularyKey(nameof(MeasuredQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MeasuringInstrumentId = group.Add(new VocabularyKey(nameof(MeasuringInstrumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MeasuringRunningNumber = group.Add(new VocabularyKey(nameof(MeasuringRunningNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TareQty = group.Add(new VocabularyKey(nameof(TareQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TareWeightUnit = group.Add(new VocabularyKey(nameof(TareWeightUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasurement = group.Add(new VocabularyKey(nameof(UnitOfMeasurement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GateEntry = group.Add(new VocabularyKey(nameof(GateEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChallanDate = group.Add(new VocabularyKey(nameof(ChallanDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChallanNumber = group.Add(new VocabularyKey(nameof(ChallanNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ChallanQty { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey InventoryUnit { get; private set; }
        public VocabularyKey InventSiteGateEntry { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey MeasuredQty { get; private set; }
        public VocabularyKey MeasuringInstrumentId { get; private set; }
        public VocabularyKey MeasuringRunningNumber { get; private set; }
        public VocabularyKey TareQty { get; private set; }
        public VocabularyKey TareWeightUnit { get; private set; }
        public VocabularyKey UnitOfMeasurement { get; private set; }
        public VocabularyKey GateEntry { get; private set; }
        public VocabularyKey ChallanDate { get; private set; }
        public VocabularyKey ChallanNumber { get; private set; }
    }
}