using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PassVocabulary : SimpleVocabulary
    {
        public PassVocabulary()
        {
            VocabularyName = "Pass";
            KeyPrefix = "commonDataModel.pass";
            KeySeparator = ".";
            Grouping = "/Pass";

            AddGroup("Pass Details", group =>
            {
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPerUnit = group.Add(new VocabularyKey(nameof(CostPerUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPerUnitBase = group.Add(new VocabularyKey(nameof(CostPerUnitBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DescriptorSyncStatus = group.Add(new VocabularyKey(nameof(DescriptorSyncStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NoOfPassesAllocated = group.Add(new VocabularyKey(nameof(NoOfPassesAllocated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NoOfPassesLeft = group.Add(new VocabularyKey(nameof(NoOfPassesLeft), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NoOfPassesSold = group.Add(new VocabularyKey(nameof(NoOfPassesSold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PassId = group.Add(new VocabularyKey(nameof(PassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PassPrice = group.Add(new VocabularyKey(nameof(PassPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PassPriceBase = group.Add(new VocabularyKey(nameof(PassPriceBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalCost = group.Add(new VocabularyKey(nameof(TotalCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalCostBase = group.Add(new VocabularyKey(nameof(TotalCostBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CostPerUnit { get; private set; }
        public VocabularyKey CostPerUnitBase { get; private set; }
        public VocabularyKey DescriptorSyncStatus { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NoOfPassesAllocated { get; private set; }
        public VocabularyKey NoOfPassesLeft { get; private set; }
        public VocabularyKey NoOfPassesSold { get; private set; }
        public VocabularyKey PassId { get; private set; }
        public VocabularyKey PassPrice { get; private set; }
        public VocabularyKey PassPriceBase { get; private set; }
        public VocabularyKey TotalCost { get; private set; }
        public VocabularyKey TotalCostBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}