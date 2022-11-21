using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCreditCardEntityVocabulary : SimpleVocabulary
    {
        public CustCreditCardEntityVocabulary()
        {
            VocabularyName = "Cust Credit Card Entity";
            KeyPrefix = "commonDataModel.custcreditcardentity";
            KeySeparator = ".";
            Grouping = "/CustCreditCardEntity";

            AddGroup("CustCreditCardEntity Details", group =>
            {
                CustomerAccountNum = group.Add(new VocabularyKey(nameof(CustomerAccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardNumber = group.Add(new VocabularyKey(nameof(CardNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditCardTypeName = group.Add(new VocabularyKey(nameof(CreditCardTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpiryDate = group.Add(new VocabularyKey(nameof(ExpiryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UniqueCardId = group.Add(new VocabularyKey(nameof(UniqueCardId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Street = group.Add(new VocabularyKey(nameof(Street), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardToken = group.Add(new VocabularyKey(nameof(CardToken), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey(nameof(Country), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomerAccountNum { get; private set; }
        public VocabularyKey CardNumber { get; private set; }
        public VocabularyKey CreditCardTypeName { get; private set; }
        public VocabularyKey ExpiryDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey UniqueCardId { get; private set; }
        public VocabularyKey Street { get; private set; }
        public VocabularyKey CardToken { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey Country { get; private set; }
    }
}