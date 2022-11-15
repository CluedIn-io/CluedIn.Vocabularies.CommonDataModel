using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSShipConsolidationPolicyV2EntityVocabulary : SimpleVocabulary
    {
        public WHSShipConsolidationPolicyV2EntityVocabulary()
        {
            VocabularyName = "WHS Ship Consolidation Policy V2 Entity";
            KeyPrefix = "commonDataModel.whsshipconsolidationpolicyv2entity";
            KeySeparator = ".";
            Grouping = "/WHSShipConsolidationPolicyV2Entity";

            AddGroup("WHSShipConsolidationPolicyV2Entity Details", group =>
            {
                ShipConsolidationPolicyName = group.Add(new VocabularyKey(nameof(ShipConsolidationPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipConsolidationPolicyType = group.Add(new VocabularyKey(nameof(ShipConsolidationPolicyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipConsolidationPolicySeqNum = group.Add(new VocabularyKey(nameof(ShipConsolidationPolicySeqNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipConsolidationPolicyQuery = group.Add(new VocabularyKey(nameof(ShipConsolidationPolicyQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShipConsolidationPolicyDesc = group.Add(new VocabularyKey(nameof(ShipConsolidationPolicyDesc), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Valid = group.Add(new VocabularyKey(nameof(Valid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsolidateWithExistingShipments = group.Add(new VocabularyKey(nameof(ConsolidateWithExistingShipments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ShipConsolidationPolicyName { get; private set; }
        public VocabularyKey ShipConsolidationPolicyType { get; private set; }
        public VocabularyKey ShipConsolidationPolicySeqNum { get; private set; }
        public VocabularyKey ShipConsolidationPolicyQuery { get; private set; }
        public VocabularyKey ShipConsolidationPolicyDesc { get; private set; }
        public VocabularyKey Valid { get; private set; }
        public VocabularyKey ConsolidateWithExistingShipments { get; private set; }
    }
}