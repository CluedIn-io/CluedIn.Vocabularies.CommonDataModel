using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BOMBillOfMaterialsParametersEntityVocabulary : SimpleVocabulary
    {
        public BOMBillOfMaterialsParametersEntityVocabulary()
        {
            VocabularyName = "BOMBillOfMaterialsParametersEntity";
            KeyPrefix = "commonDataModel.bombillofmaterialsparametersentity";
            KeySeparator = ".";
            Grouping = "/BOMBillOfMaterialsParametersEntity";

            AddGroup("BOMBillOfMaterialsParametersEntity Details", group =>
            {
                CircularityCheckLevel = group.Add(new VocabularyKey(nameof(CircularityCheckLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumBOMLevel = group.Add(new VocabularyKey(nameof(MaximumBOMLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreQuantitiesOnBOMLinesAndDatesOnBOMVersionMandatory = group.Add(new VocabularyKey(nameof(AreQuantitiesOnBOMLinesAndDatesOnBOMVersionMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBOMAndVersionApprovalRemovalBlocked = group.Add(new VocabularyKey(nameof(IsBOMAndVersionApprovalRemovalBlocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBOMEditingBlocked = group.Add(new VocabularyKey(nameof(IsBOMEditingBlocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CircularityCheckStrategy = group.Add(new VocabularyKey(nameof(CircularityCheckStrategy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FallbackCostCalculationGroupId = group.Add(new VocabularyKey(nameof(FallbackCostCalculationGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CircularityCheckLevel { get; private set; }
        public VocabularyKey MaximumBOMLevel { get; private set; }
        public VocabularyKey AreQuantitiesOnBOMLinesAndDatesOnBOMVersionMandatory { get; private set; }
        public VocabularyKey IsBOMAndVersionApprovalRemovalBlocked { get; private set; }
        public VocabularyKey IsBOMEditingBlocked { get; private set; }
        public VocabularyKey CircularityCheckStrategy { get; private set; }
        public VocabularyKey FallbackCostCalculationGroupId { get; private set; }


    }
}