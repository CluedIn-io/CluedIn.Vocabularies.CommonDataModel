using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustEInvoiceErrorCodeEntityVocabulary : SimpleVocabulary
    {
        public CustEInvoiceErrorCodeEntityVocabulary()
        {
            VocabularyName = "Cust E Invoice Error Code Entity";
            KeyPrefix = "commonDataModel.custeinvoiceerrorcodeentity";
            KeySeparator = ".";
            Grouping = "/CustEInvoiceErrorCodeEntity";

            AddGroup("CustEInvoiceErrorCodeEntity Details", group =>
            {
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ErrorText = group.Add(new VocabularyKey(nameof(ErrorText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Change = group.Add(new VocabularyKey(nameof(Change), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey ErrorText { get; private set; }
        public VocabularyKey Change { get; private set; }
    }
}