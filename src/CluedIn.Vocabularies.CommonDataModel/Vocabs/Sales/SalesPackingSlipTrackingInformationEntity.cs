using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesPackingSlipTrackingInformationEntityVocabulary : SimpleVocabulary
    {
        public SalesPackingSlipTrackingInformationEntityVocabulary()
        {
            VocabularyName = "SalesPackingSlipTrackingInformationEntity";
            KeyPrefix = "commonDataModel.salespackingsliptrackinginformationentity";
            KeySeparator = ".";
            Grouping = "/SalesPackingSlipTrackingInformationEntity";

            AddGroup("SalesPackingSlipTrackingInformationEntity Details", group =>
            {
                SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingSlipNumber = group.Add(new VocabularyKey(nameof(PackingSlipNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryDate = group.Add(new VocabularyKey(nameof(DeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrackingNumber = group.Add(new VocabularyKey(nameof(TrackingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrackingURL = group.Add(new VocabularyKey(nameof(TrackingURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SalesOrderNumber { get; private set; }
        public VocabularyKey PackingSlipNumber { get; private set; }
        public VocabularyKey DeliveryDate { get; private set; }
        public VocabularyKey TrackingNumber { get; private set; }
        public VocabularyKey TrackingURL { get; private set; }


    }
}