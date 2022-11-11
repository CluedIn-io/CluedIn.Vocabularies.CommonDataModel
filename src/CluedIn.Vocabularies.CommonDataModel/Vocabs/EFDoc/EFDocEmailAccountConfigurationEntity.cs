using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EFDocEmailAccountConfigurationEntityVocabulary : SimpleVocabulary
    {
        public EFDocEmailAccountConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model EFDocEmailAccountConfigurationEntity";
            KeyPrefix = "commonDataModel.efdocemailaccountconfigurationentity";
            KeySeparator = ".";
            Grouping = "/EFDocEmailAccountConfigurationEntity";

            AddGroup("Common Data Model EFDocEmailAccountConfigurationEntity Details", group =>
            {
                ServerAddress = group.Add(new VocabularyKey(nameof(ServerAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Port = group.Add(new VocabularyKey(nameof(Port), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseSsl = group.Add(new VocabularyKey(nameof(UseSsl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Username = group.Add(new VocabularyKey(nameof(Username), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ServerAddress { get; private set; }
        public VocabularyKey Port { get; private set; }
        public VocabularyKey UseSsl { get; private set; }
        public VocabularyKey Username { get; private set; }


    }
}