using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankReturnFormatErrorCodesEntityVocabulary : SimpleVocabulary
    {
        public BankReturnFormatErrorCodesEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankReturnFormatErrorCodesEntity";
            KeyPrefix = "commonDataModel.bankreturnformaterrorcodesentity";
            KeySeparator = ".";
            Grouping = "/BankReturnFormatErrorCodesEntity";

            AddGroup("Common Data Model BankReturnFormatErrorCodesEntity Details", group =>
            {
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}