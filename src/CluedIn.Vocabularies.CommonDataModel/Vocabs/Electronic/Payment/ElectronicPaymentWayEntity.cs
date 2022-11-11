using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicPaymentWayEntityVocabulary : SimpleVocabulary
    {
        public ElectronicPaymentWayEntityVocabulary()
        {
            VocabularyName = "Common Data Model ElectronicPaymentWayEntity";
            KeyPrefix = "commonDataModel.electronicpaymentwayentity";
            KeySeparator = ".";
            Grouping = "/ElectronicPaymentWayEntity";

            AddGroup("Common Data Model ElectronicPaymentWayEntity Details", group =>
            {
                PaymentWay = group.Add(new VocabularyKey(nameof(PaymentWay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PaymentWay { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}