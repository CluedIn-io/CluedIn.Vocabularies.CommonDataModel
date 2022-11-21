using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OMTeamV2EntityVocabulary : SimpleVocabulary
    {
        public OMTeamV2EntityVocabulary()
        {
            VocabularyName = "OM Team V2 Entity";
            KeyPrefix = "commonDataModel.omteamv2entity";
            KeySeparator = ".";
            Grouping = "/OMTeamV2Entity";

            AddGroup("OMTeamV2Entity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeamType = group.Add(new VocabularyKey(nameof(TeamType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Administrator = group.Add(new VocabularyKey(nameof(Administrator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeamTypeName = group.Add(new VocabularyKey(nameof(TeamTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey TeamType { get; private set; }
        public VocabularyKey Administrator { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TeamTypeName { get; private set; }
    }
}