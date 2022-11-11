using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PassVocabulary : SimpleVocabulary
    {
        public PassVocabulary()
        {
            VocabularyName = "Common Data Model Pass";
            KeyPrefix = "commonDataModel.pass";
            KeySeparator = ".";
            Grouping = "/Pass";

            AddGroup("Common Data Model Pass Details", group =>
            {
                exchangeRate = group.Add(new VocabularyKey(nameof(exchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                costPerUnit = group.Add(new VocabularyKey(nameof(costPerUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                costPerUnitBase = group.Add(new VocabularyKey(nameof(costPerUnitBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                descriptorSyncStatus = group.Add(new VocabularyKey(nameof(descriptorSyncStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                noOfPassesAllocated = group.Add(new VocabularyKey(nameof(noOfPassesAllocated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                noOfPassesLeft = group.Add(new VocabularyKey(nameof(noOfPassesLeft), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                noOfPassesSold = group.Add(new VocabularyKey(nameof(noOfPassesSold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                passId = group.Add(new VocabularyKey(nameof(passId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                passPrice = group.Add(new VocabularyKey(nameof(passPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                passPriceBase = group.Add(new VocabularyKey(nameof(passPriceBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                totalCost = group.Add(new VocabularyKey(nameof(totalCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                totalCostBase = group.Add(new VocabularyKey(nameof(totalCostBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey exchangeRate { get; private set; }
        public VocabularyKey costPerUnit { get; private set; }
        public VocabularyKey costPerUnitBase { get; private set; }
        public VocabularyKey descriptorSyncStatus { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey noOfPassesAllocated { get; private set; }
        public VocabularyKey noOfPassesLeft { get; private set; }
        public VocabularyKey noOfPassesSold { get; private set; }
        public VocabularyKey passId { get; private set; }
        public VocabularyKey passPrice { get; private set; }
        public VocabularyKey passPriceBase { get; private set; }
        public VocabularyKey totalCost { get; private set; }
        public VocabularyKey totalCostBase { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}