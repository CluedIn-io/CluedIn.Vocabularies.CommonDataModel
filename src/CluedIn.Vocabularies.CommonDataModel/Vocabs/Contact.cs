using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ContactVocabulary : SimpleVocabulary
    {
        public ContactVocabulary()
        {
            VocabularyName = "Contact";
            KeyPrefix = "commonDataModel.contact";
            KeySeparator = ".";
            Grouping = "/Contact";

            AddGroup("Contact Details", group =>
            {
                BirthDate = group.Add(new VocabularyKey(nameof(BirthDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Gdprconsent = group.Add(new VocabularyKey(nameof(Gdprconsent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GDPRIsChild = group.Add(new VocabularyKey(nameof(GDPRIsChild), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoNotTrack = group.Add(new VocabularyKey(nameof(DoNotTrack), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BirthDate { get; private set; }
        public VocabularyKey Gdprconsent { get; private set; }
        public VocabularyKey GDPRIsChild { get; private set; }
        public VocabularyKey DoNotTrack { get; private set; }
    }
}