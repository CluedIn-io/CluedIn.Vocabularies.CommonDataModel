using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailReturnPolicyLineEntityVocabulary : SimpleVocabulary
    {
        public RetailReturnPolicyLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailReturnPolicyLineEntity";
            KeyPrefix = "commonDataModel.retailreturnpolicylineentity";
            KeySeparator = ".";
            Grouping = "/RetailReturnPolicyLineEntity";

            AddGroup("Common Data Model RetailReturnPolicyLineEntity Details", group =>
            {
                BlockItem = group.Add(new VocabularyKey(nameof(BlockItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Warehouse = group.Add(new VocabularyKey(nameof(Warehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Policy = group.Add(new VocabularyKey(nameof(Policy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyNumber = group.Add(new VocabularyKey(nameof(PolicyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailStoreTable = group.Add(new VocabularyKey(nameof(RetailStoreTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BlockItem { get; private set; }
        public VocabularyKey Warehouse { get; private set; }
        public VocabularyKey Policy { get; private set; }
        public VocabularyKey LocationId { get; private set; }
        public VocabularyKey PolicyNumber { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }
        public VocabularyKey RetailStoreTable { get; private set; }
        public VocabularyKey LineNumber { get; private set; }


    }
}