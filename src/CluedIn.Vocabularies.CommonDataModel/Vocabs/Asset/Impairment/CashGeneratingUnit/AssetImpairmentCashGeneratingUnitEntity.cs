using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetImpairmentCashGeneratingUnitEntityVocabulary : SimpleVocabulary
    {
        public AssetImpairmentCashGeneratingUnitEntityVocabulary()
        {
            VocabularyName = "AssetImpairmentCashGeneratingUnitEntity";
            KeyPrefix = "commonDataModel.assetimpairmentcashgeneratingunitentity";
            KeySeparator = ".";
            Grouping = "/AssetImpairmentCashGeneratingUnitEntity";

            AddGroup("AssetImpairmentCashGeneratingUnitEntity Details", group =>
            {
                CashGeneratingUnitNumber = group.Add(new VocabularyKey(nameof(CashGeneratingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CGUGroup = group.Add(new VocabularyKey(nameof(CGUGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CGUGroupName = group.Add(new VocabularyKey(nameof(CGUGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImpairmentAllocationBasis = group.Add(new VocabularyKey(nameof(ImpairmentAllocationBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecoverableAmount = group.Add(new VocabularyKey(nameof(RecoverableAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecoverableAmountLastUpdatedDate = group.Add(new VocabularyKey(nameof(RecoverableAmountLastUpdatedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UndiscountedCashFlow = group.Add(new VocabularyKey(nameof(UndiscountedCashFlow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UndiscountedCashFlowLastUpdatedDate = group.Add(new VocabularyKey(nameof(UndiscountedCashFlowLastUpdatedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CashGeneratingUnitNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CGUGroup { get; private set; }
        public VocabularyKey CGUGroupName { get; private set; }
        public VocabularyKey ImpairmentAllocationBasis { get; private set; }
        public VocabularyKey RecoverableAmount { get; private set; }
        public VocabularyKey RecoverableAmountLastUpdatedDate { get; private set; }
        public VocabularyKey UndiscountedCashFlow { get; private set; }
        public VocabularyKey UndiscountedCashFlowLastUpdatedDate { get; private set; }


    }
}