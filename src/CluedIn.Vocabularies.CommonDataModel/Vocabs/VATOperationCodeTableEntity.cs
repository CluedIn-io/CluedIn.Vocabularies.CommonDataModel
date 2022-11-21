using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VATOperationCodeTableEntityVocabulary : SimpleVocabulary
    {
        public VATOperationCodeTableEntityVocabulary()
        {
            VocabularyName = "VAT Operation Code Table Entity";
            KeyPrefix = "commonDataModel.vatoperationcodetableentity";
            KeySeparator = ".";
            Grouping = "/VATOperationCodeTableEntity";

            AddGroup("VATOperationCodeTableEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATOperationCode = group.Add(new VocabularyKey(nameof(VATOperationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey VATOperationCode { get; private set; }
    }
}