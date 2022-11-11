using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManCreditLimitAdvancedEntityVocabulary : SimpleVocabulary
    {
        public CredManCreditLimitAdvancedEntityVocabulary()
        {
            VocabularyName = "Common Data Model CredManCreditLimitAdvancedEntity";
            KeyPrefix = "commonDataModel.credmancreditlimitadvancedentity";
            KeySeparator = ".";
            Grouping = "/CredManCreditLimitAdvancedEntity";

            AddGroup("Common Data Model CredManCreditLimitAdvancedEntity Details", group =>
            {
                CreditLimitId = group.Add(new VocabularyKey(nameof(CreditLimitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditMax = group.Add(new VocabularyKey(nameof(CreditMax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustAccount = group.Add(new VocabularyKey(nameof(CustAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustAccountDataArea = group.Add(new VocabularyKey(nameof(CustAccountDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CreditLimitId { get; private set; }
        public VocabularyKey CreditMax { get; private set; }
        public VocabularyKey CustAccount { get; private set; }
        public VocabularyKey CustAccountDataArea { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey ToDate { get; private set; }


    }
}