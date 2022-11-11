using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EinvoicePACEntityVocabulary : SimpleVocabulary
    {
        public EinvoicePACEntityVocabulary()
        {
            VocabularyName = "Common Data Model EinvoicePACEntity";
            KeyPrefix = "commonDataModel.einvoicepacentity";
            KeySeparator = ".";
            Grouping = "/EinvoicePACEntity";

            AddGroup("Common Data Model EinvoicePACEntity Details", group =>
            {
                PACAccountId = group.Add(new VocabularyKey(nameof(PACAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PACAccountName = group.Add(new VocabularyKey(nameof(PACAccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFCNumber = group.Add(new VocabularyKey(nameof(RFCNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Environment = group.Add(new VocabularyKey(nameof(Environment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                URL = group.Add(new VocabularyKey(nameof(URL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebService = group.Add(new VocabularyKey(nameof(WebService), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebServiceMethod = group.Add(new VocabularyKey(nameof(WebServiceMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PACAccountId { get; private set; }
        public VocabularyKey PACAccountName { get; private set; }
        public VocabularyKey RFCNumber { get; private set; }
        public VocabularyKey Environment { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey WebService { get; private set; }
        public VocabularyKey WebServiceMethod { get; private set; }


    }
}