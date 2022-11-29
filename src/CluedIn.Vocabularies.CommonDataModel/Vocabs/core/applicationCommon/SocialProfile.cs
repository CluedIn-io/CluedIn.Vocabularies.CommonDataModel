using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class SocialProfileVocabulary : SimpleVocabulary
    {
        public SocialProfileVocabulary()
        {
            VocabularyName = "Social Profile";
            KeyPrefix = "commonDataModel.socialprofile.applicationcommon";
            KeySeparator = ".";
            Grouping = "/SocialProfile";

            AddGroup("SocialProfile Details for ApplicationCommon", group =>
            {
			    SocialProfileId = group.Add(new VocabularyKey(nameof(SocialProfileId), "Social Profile ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProfileName = group.Add(new VocabularyKey(nameof(ProfileName), "Profile Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProfileFullName = group.Add(new VocabularyKey(nameof(ProfileFullName), "Full Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Blocked = group.Add(new VocabularyKey(nameof(Blocked), "Blocked", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Community = group.Add(new VocabularyKey(nameof(Community), "Social Channel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InfluenceScore = group.Add(new VocabularyKey(nameof(InfluenceScore), "Influence Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ProfileLink = group.Add(new VocabularyKey(nameof(ProfileLink), "Profile Link", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    UniqueProfileID = group.Add(new VocabularyKey(nameof(UniqueProfileID), "Unique Profile ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SocialProfileId { get; private set; }
        public VocabularyKey ProfileName { get; private set; }
        public VocabularyKey ProfileFullName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Blocked { get; private set; }
        public VocabularyKey Community { get; private set; }
        public VocabularyKey InfluenceScore { get; private set; }
        public VocabularyKey ProfileLink { get; private set; }
        public VocabularyKey UniqueProfileID { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}