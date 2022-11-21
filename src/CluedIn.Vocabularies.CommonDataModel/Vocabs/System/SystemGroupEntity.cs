using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemGroupEntityVocabulary : SimpleVocabulary
    {
        public SystemGroupEntityVocabulary()
        {
            VocabularyName = "System Group Entity";
            KeyPrefix = "commonDataModel.systemgroupentity";
            KeySeparator = ".";
            Grouping = "/SystemGroupEntity";

            AddGroup("SystemGroupEntity Details", group =>
            {
                UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ObjectID = group.Add(new VocabularyKey(nameof(ObjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Enabled = group.Add(new VocabularyKey(nameof(Enabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreferredTimeZone = group.Add(new VocabularyKey(nameof(PreferredTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreferredCalendar = group.Add(new VocabularyKey(nameof(PreferredCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey UserId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ObjectID { get; private set; }
        public VocabularyKey Enabled { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey PreferredTimeZone { get; private set; }
        public VocabularyKey PreferredCalendar { get; private set; }
    }
}