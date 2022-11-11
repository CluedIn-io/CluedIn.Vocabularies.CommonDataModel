using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class UserGeoRegionVocabulary : SimpleVocabulary
    {
        public UserGeoRegionVocabulary()
        {
            VocabularyName = "Common Data Model UserGeoRegion";
            KeyPrefix = "commonDataModel.usergeoregion";
            KeySeparator = ".";
            Grouping = "/UserGeoRegion";

            AddGroup("Common Data Model UserGeoRegion Details", group =>
            {
                geoRegion = group.Add(new VocabularyKey(nameof(geoRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                userGeoRegionId = group.Add(new VocabularyKey(nameof(userGeoRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey geoRegion { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey userGeoRegionId { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}