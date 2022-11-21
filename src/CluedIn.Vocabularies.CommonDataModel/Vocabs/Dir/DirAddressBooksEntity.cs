using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DirAddressBooksEntityVocabulary : SimpleVocabulary
    {
        public DirAddressBooksEntityVocabulary()
        {
            VocabularyName = "Dir Address Books Entity";
            KeyPrefix = "commonDataModel.diraddressbooksentity";
            KeySeparator = ".";
            Grouping = "/DirAddressBooksEntity";

            AddGroup("DirAddressBooksEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                System = group.Add(new VocabularyKey(nameof(System), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey System { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}