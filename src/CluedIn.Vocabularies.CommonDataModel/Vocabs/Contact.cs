using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Common Data Model Contact";
            KeyPrefix = "commonDataModel.contact";
            KeySeparator = ".";
            Grouping = "/Contact";

            AddGroup("Common Data Model Contact Details", group =>
            {
                birthDate = group.Add(new VocabularyKey(nameof(birthDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                gdprconsent = group.Add(new VocabularyKey(nameof(gdprconsent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GDPRIsChild = group.Add(new VocabularyKey(nameof(GDPRIsChild), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                doNotTrack = group.Add(new VocabularyKey(nameof(doNotTrack), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey birthDate { get; private set; }
        public VocabularyKey gdprconsent { get; private set; }
        public VocabularyKey GDPRIsChild { get; private set; }
        public VocabularyKey doNotTrack { get; private set; }


    }
}