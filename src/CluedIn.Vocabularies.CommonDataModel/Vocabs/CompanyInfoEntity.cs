using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CompanyInfoEntityVocabulary : SimpleVocabulary
    {
        public CompanyInfoEntityVocabulary()
        {
            VocabularyName = "CompanyInfoEntity";
            KeyPrefix = "commonDataModel.companyinfoentity";
            KeySeparator = ".";
            Grouping = "/CompanyInfoEntity";

            AddGroup("CompanyInfoEntity Details", group =>
            {
                KnownAs = group.Add(new VocabularyKey(nameof(KnownAs), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataArea = group.Add(new VocabularyKey(nameof(DataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey KnownAs { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey DataArea { get; private set; }


    }
}