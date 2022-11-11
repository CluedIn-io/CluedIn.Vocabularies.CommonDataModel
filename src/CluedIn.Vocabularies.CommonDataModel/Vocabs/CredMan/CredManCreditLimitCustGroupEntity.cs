using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManCreditLimitCustGroupEntityVocabulary : SimpleVocabulary
    {
        public CredManCreditLimitCustGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model CredManCreditLimitCustGroupEntity";
            KeyPrefix = "commonDataModel.credmancreditlimitcustgroupentity";
            KeySeparator = ".";
            Grouping = "/CredManCreditLimitCustGroupEntity";

            AddGroup("Common Data Model CredManCreditLimitCustGroupEntity Details", group =>
            {
                CreditLimitId = group.Add(new VocabularyKey(nameof(CreditLimitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditMax = group.Add(new VocabularyKey(nameof(CreditMax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpiryDate = group.Add(new VocabularyKey(nameof(ExpiryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CreditLimitId { get; private set; }
        public VocabularyKey CreditMax { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExpiryDate { get; private set; }


    }
}