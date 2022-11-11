using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentDayCdsEntityVocabulary : SimpleVocabulary
    {
        public PaymentDayCdsEntityVocabulary()
        {
            VocabularyName = "PaymentDayCdsEntity";
            KeyPrefix = "commonDataModel.paymentdaycdsentity";
            KeySeparator = ".";
            Grouping = "/PaymentDayCdsEntity";

            AddGroup("PaymentDayCdsEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}