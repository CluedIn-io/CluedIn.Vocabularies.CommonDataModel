using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CFPSTableEntityVocabulary : SimpleVocabulary
    {
        public CFPSTableEntityVocabulary()
        {
            VocabularyName = "CFPSTableEntity";
            KeyPrefix = "commonDataModel.cfpstableentity";
            KeySeparator = ".";
            Grouping = "/CFPSTableEntity";

            AddGroup("CFPSTableEntity Details", group =>
            {
                CFPSCode = group.Add(new VocabularyKey(nameof(CFPSCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SearchName = group.Add(new VocabularyKey(nameof(SearchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CFPSCode { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SearchName { get; private set; }


    }
}