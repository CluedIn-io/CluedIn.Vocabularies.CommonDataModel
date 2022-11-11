using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PSAVendPWPTxtEntityVocabulary : SimpleVocabulary
    {
        public PSAVendPWPTxtEntityVocabulary()
        {
            VocabularyName = "Common Data Model PSAVendPWPTxtEntity";
            KeyPrefix = "commonDataModel.psavendpwptxtentity";
            KeySeparator = ".";
            Grouping = "/PSAVendPWPTxtEntity";

            AddGroup("Common Data Model PSAVendPWPTxtEntity Details", group =>
            {
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayWhenPaidContractLanguage = group.Add(new VocabularyKey(nameof(PayWhenPaidContractLanguage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorRetentionContractLanguage = group.Add(new VocabularyKey(nameof(VendorRetentionContractLanguage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorGroup = group.Add(new VocabularyKey(nameof(VendorGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey VendorAccount { get; private set; }
        public VocabularyKey PayWhenPaidContractLanguage { get; private set; }
        public VocabularyKey VendorRetentionContractLanguage { get; private set; }
        public VocabularyKey VendorGroup { get; private set; }


    }
}