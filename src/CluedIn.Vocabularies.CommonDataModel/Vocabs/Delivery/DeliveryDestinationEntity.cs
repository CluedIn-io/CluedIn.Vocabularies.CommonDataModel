using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DeliveryDestinationEntityVocabulary : SimpleVocabulary
    {
        public DeliveryDestinationEntityVocabulary()
        {
            VocabularyName = "DeliveryDestinationEntity";
            KeyPrefix = "commonDataModel.deliverydestinationentity";
            KeySeparator = ".";
            Grouping = "/DeliveryDestinationEntity";

            AddGroup("DeliveryDestinationEntity Details", group =>
            {
                DestinationDescription = group.Add(new VocabularyKey(nameof(DestinationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DestinationCode = group.Add(new VocabularyKey(nameof(DestinationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DestinationDescription { get; private set; }
        public VocabularyKey DestinationCode { get; private set; }


    }
}