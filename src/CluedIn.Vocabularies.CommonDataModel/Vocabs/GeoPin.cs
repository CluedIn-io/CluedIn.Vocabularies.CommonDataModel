using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class GeoPinVocabulary : SimpleVocabulary
    {
        public GeoPinVocabulary()
        {
            VocabularyName = "Common Data Model GeoPin";
            KeyPrefix = "commonDataModel.geopin";
            KeySeparator = ".";
            Grouping = "/GeoPin";

            AddGroup("Common Data Model GeoPin Details", group =>
            {
                centerLatitude = group.Add(new VocabularyKey(nameof(centerLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                centerLongitude = group.Add(new VocabularyKey(nameof(centerLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                city = group.Add(new VocabularyKey(nameof(city), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                country = group.Add(new VocabularyKey(nameof(country), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                geoPinId = group.Add(new VocabularyKey(nameof(geoPinId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KPIEmailClickedCount = group.Add(new VocabularyKey(nameof(KPIEmailClickedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KPIEmailOpenedCount = group.Add(new VocabularyKey(nameof(KPIEmailOpenedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KPIRedirectLinkClickedCount = group.Add(new VocabularyKey(nameof(KPIRedirectLinkClickedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KPIWebsiteClickedCount = group.Add(new VocabularyKey(nameof(KPIWebsiteClickedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KPIWebsiteVisitedCount = group.Add(new VocabularyKey(nameof(KPIWebsiteVisitedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                kpiFormSubmittedCount = group.Add(new VocabularyKey(nameof(kpiFormSubmittedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                northwestLatitude = group.Add(new VocabularyKey(nameof(northwestLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                northwestLongitude = group.Add(new VocabularyKey(nameof(northwestLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                postalCode = group.Add(new VocabularyKey(nameof(postalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                requestbuilderserviceMktgeopins = group.Add(new VocabularyKey(nameof(requestbuilderserviceMktgeopins), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                resultparserserviceMktgeopins = group.Add(new VocabularyKey(nameof(resultparserserviceMktgeopins), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                serverIdMarketing = group.Add(new VocabularyKey(nameof(serverIdMarketing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                southeastLatitude = group.Add(new VocabularyKey(nameof(southeastLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                southeastLongitude = group.Add(new VocabularyKey(nameof(southeastLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                state = group.Add(new VocabularyKey(nameof(state), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey centerLatitude { get; private set; }
        public VocabularyKey centerLongitude { get; private set; }
        public VocabularyKey city { get; private set; }
        public VocabularyKey country { get; private set; }
        public VocabularyKey geoPinId { get; private set; }
        public VocabularyKey KPIEmailClickedCount { get; private set; }
        public VocabularyKey KPIEmailOpenedCount { get; private set; }
        public VocabularyKey KPIRedirectLinkClickedCount { get; private set; }
        public VocabularyKey KPIWebsiteClickedCount { get; private set; }
        public VocabularyKey KPIWebsiteVisitedCount { get; private set; }
        public VocabularyKey kpiFormSubmittedCount { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey northwestLatitude { get; private set; }
        public VocabularyKey northwestLongitude { get; private set; }
        public VocabularyKey postalCode { get; private set; }
        public VocabularyKey requestbuilderserviceMktgeopins { get; private set; }
        public VocabularyKey resultparserserviceMktgeopins { get; private set; }
        public VocabularyKey serverIdMarketing { get; private set; }
        public VocabularyKey southeastLatitude { get; private set; }
        public VocabularyKey southeastLongitude { get; private set; }
        public VocabularyKey state { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}