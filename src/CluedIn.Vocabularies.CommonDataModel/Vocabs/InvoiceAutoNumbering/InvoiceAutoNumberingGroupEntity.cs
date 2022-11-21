using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InvoiceAutoNumberingGroupEntityVocabulary : SimpleVocabulary
    {
        public InvoiceAutoNumberingGroupEntityVocabulary()
        {
            VocabularyName = "Invoice Auto Numbering Group Entity";
            KeyPrefix = "commonDataModel.invoiceautonumberinggroupentity";
            KeySeparator = ".";
            Grouping = "/InvoiceAutoNumberingGroupEntity";

            AddGroup("InvoiceAutoNumberingGroupEntity Details", group =>
            {
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutoNumbering = group.Add(new VocabularyKey(nameof(AutoNumbering), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Module = group.Add(new VocabularyKey(nameof(Module), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey AutoNumbering { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey Module { get; private set; }
    }
}