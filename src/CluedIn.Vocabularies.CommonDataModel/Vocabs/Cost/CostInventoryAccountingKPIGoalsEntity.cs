using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CostInventoryAccountingKPIGoalsEntityVocabulary : SimpleVocabulary
    {
        public CostInventoryAccountingKPIGoalsEntityVocabulary()
        {
            VocabularyName = "Common Data Model CostInventoryAccountingKPIGoalsEntity";
            KeyPrefix = "commonDataModel.costinventoryaccountingkpigoalsentity";
            KeySeparator = ".";
            Grouping = "/CostInventoryAccountingKPIGoalsEntity";

            AddGroup("Common Data Model CostInventoryAccountingKPIGoalsEntity Details", group =>
            {
                AnnualInventoryTurn = group.Add(new VocabularyKey(nameof(AnnualInventoryTurn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryAccuracy = group.Add(new VocabularyKey(nameof(InventoryAccuracy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AnnualInventoryTurn { get; private set; }
        public VocabularyKey InventoryAccuracy { get; private set; }


    }
}