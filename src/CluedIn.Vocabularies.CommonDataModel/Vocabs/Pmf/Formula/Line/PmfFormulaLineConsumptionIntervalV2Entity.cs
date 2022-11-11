using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PmfFormulaLineConsumptionIntervalV2EntityVocabulary : SimpleVocabulary
    {
        public PmfFormulaLineConsumptionIntervalV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model PmfFormulaLineConsumptionIntervalV2Entity";
            KeyPrefix = "commonDataModel.pmfformulalineconsumptionintervalv2entity";
            KeySeparator = ".";
            Grouping = "/PmfFormulaLineConsumptionIntervalV2Entity";

            AddGroup("Common Data Model PmfFormulaLineConsumptionIntervalV2Entity Details", group =>
            {
                ConsumptionQuantity = group.Add(new VocabularyKey(nameof(ConsumptionQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromQuantity = group.Add(new VocabularyKey(nameof(FromQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CatchWeightConsumptionQuantity = group.Add(new VocabularyKey(nameof(CatchWeightConsumptionQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormulaId = group.Add(new VocabularyKey(nameof(FormulaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineRecordId = group.Add(new VocabularyKey(nameof(LineRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineCreationSequenceNumber = group.Add(new VocabularyKey(nameof(LineCreationSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ConsumptionQuantity { get; private set; }
        public VocabularyKey FromQuantity { get; private set; }
        public VocabularyKey CatchWeightConsumptionQuantity { get; private set; }
        public VocabularyKey FormulaId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey LineRecordId { get; private set; }
        public VocabularyKey LineCreationSequenceNumber { get; private set; }


    }
}