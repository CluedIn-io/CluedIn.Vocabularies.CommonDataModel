using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvEmpCreditCardEntityVocabulary : SimpleVocabulary
    {
        public TrvEmpCreditCardEntityVocabulary()
        {
            VocabularyName = "TrvEmpCreditCardEntity";
            KeyPrefix = "commonDataModel.trvempcreditcardentity";
            KeySeparator = ".";
            Grouping = "/TrvEmpCreditCardEntity";

            AddGroup("TrvEmpCreditCardEntity Details", group =>
            {
                PaymentMethod = group.Add(new VocabularyKey(nameof(PaymentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardType = group.Add(new VocabularyKey(nameof(CardType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Employee = group.Add(new VocabularyKey(nameof(Employee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardId = group.Add(new VocabularyKey(nameof(CardId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PaymentMethod { get; private set; }
        public VocabularyKey CardType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Employee { get; private set; }
        public VocabularyKey CardId { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }


    }
}