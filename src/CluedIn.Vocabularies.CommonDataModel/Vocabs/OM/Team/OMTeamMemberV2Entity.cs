using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OMTeamMemberV2EntityVocabulary : SimpleVocabulary
    {
        public OMTeamMemberV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model OMTeamMemberV2Entity";
            KeyPrefix = "commonDataModel.omteammemberv2entity";
            KeySeparator = ".";
            Grouping = "/OMTeamMemberV2Entity";

            AddGroup("Common Data Model OMTeamMemberV2Entity Details", group =>
            {
                ChildParty = group.Add(new VocabularyKey(nameof(ChildParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentParty = group.Add(new VocabularyKey(nameof(ParentParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeamName = group.Add(new VocabularyKey(nameof(TeamName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeamMemberName = group.Add(new VocabularyKey(nameof(TeamMemberName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TeamMemberPartyNumber = group.Add(new VocabularyKey(nameof(TeamMemberPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTeamLead = group.Add(new VocabularyKey(nameof(IsTeamLead), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ChildParty { get; private set; }
        public VocabularyKey ParentParty { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey TeamName { get; private set; }
        public VocabularyKey TeamMemberName { get; private set; }
        public VocabularyKey TeamMemberPartyNumber { get; private set; }
        public VocabularyKey IsTeamLead { get; private set; }


    }
}