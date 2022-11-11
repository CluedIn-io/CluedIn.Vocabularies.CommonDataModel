using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PSNPurchasingCardBankEntityVocabulary : SimpleVocabulary
    {
        public PSNPurchasingCardBankEntityVocabulary()
        {
            VocabularyName = "Common Data Model PSNPurchasingCardBankEntity";
            KeyPrefix = "commonDataModel.psnpurchasingcardbankentity";
            KeySeparator = ".";
            Grouping = "/PSNPurchasingCardBankEntity";

            AddGroup("Common Data Model PSNPurchasingCardBankEntity Details", group =>
            {
                BankAccountId = group.Add(new VocabularyKey(nameof(BankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardHolderName = group.Add(new VocabularyKey(nameof(CardHolderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditLimit = group.Add(new VocabularyKey(nameof(CreditLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpiryDate = group.Add(new VocabularyKey(nameof(ExpiryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmployeeRecId = group.Add(new VocabularyKey(nameof(EmployeeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardReferenceNumber = group.Add(new VocabularyKey(nameof(CardReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmployeePersonnelNumber = group.Add(new VocabularyKey(nameof(EmployeePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BankAccountId { get; private set; }
        public VocabularyKey CardHolderName { get; private set; }
        public VocabularyKey CreditLimit { get; private set; }
        public VocabularyKey ExpiryDate { get; private set; }
        public VocabularyKey EmployeeRecId { get; private set; }
        public VocabularyKey CardReferenceNumber { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey EmployeePersonnelNumber { get; private set; }


    }
}