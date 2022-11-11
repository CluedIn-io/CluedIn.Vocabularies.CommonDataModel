using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseMobileDeviceMenuItemSystemDirectedWorkSequenceQueryV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseMobileDeviceMenuItemSystemDirectedWorkSequenceQueryV2EntityVocabulary()
        {
            VocabularyName = "WHSWarehouseMobileDeviceMenuItemSystemDirectedWorkSequenceQueryV2Entity";
            KeyPrefix = "commonDataModel.whswarehousemobiledevicemenuitemsystemdirectedworksequencequeryv2entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseMobileDeviceMenuItemSystemDirectedWorkSequenceQueryV2Entity";

            AddGroup("WHSWarehouseMobileDeviceMenuItemSystemDirectedWorkSequenceQueryV2Entity Details", group =>
            {
                QueryDescription = group.Add(new VocabularyKey(nameof(QueryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkSequenceQuery = group.Add(new VocabularyKey(nameof(WorkSequenceQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseMobileDeviceMenuItemId = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceMenuItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey QueryDescription { get; private set; }
        public VocabularyKey WorkSequenceQuery { get; private set; }
        public VocabularyKey WarehouseMobileDeviceMenuItemId { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }


    }
}