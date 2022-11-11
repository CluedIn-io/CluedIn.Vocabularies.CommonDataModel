using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDeliveryModeEntityVocabulary : SimpleVocabulary
    {
        public RetailDeliveryModeEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailDeliveryModeEntity";
            KeyPrefix = "commonDataModel.retaildeliverymodeentity";
            KeySeparator = ".";
            Grouping = "/RetailDeliveryModeEntity";

            AddGroup("Common Data Model RetailDeliveryModeEntity Details", group =>
            {
                DeliveryModeName = group.Add(new VocabularyKey(nameof(DeliveryModeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeId = group.Add(new VocabularyKey(nameof(DeliveryModeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DeliveryModeName { get; private set; }
        public VocabularyKey DeliveryModeId { get; private set; }


    }
}