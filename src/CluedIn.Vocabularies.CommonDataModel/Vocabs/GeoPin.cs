using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class GeoPinVocabulary : SimpleVocabulary
    {
        public GeoPinVocabulary()
        {
            VocabularyName = "Geo Pin";
            KeyPrefix = "commonDataModel.geopin";
            KeySeparator = ".";
            Grouping = "/GeoPin";

            AddGroup("GeoPin Details", group =>
            {
                CenterLatitude = group.Add(new VocabularyKey(nameof(CenterLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CenterLongitude = group.Add(new VocabularyKey(nameof(CenterLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey(nameof(Country), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeoPinId = group.Add(new VocabularyKey(nameof(GeoPinId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KPIEmailClickedCount = group.Add(new VocabularyKey(nameof(KPIEmailClickedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KPIEmailOpenedCount = group.Add(new VocabularyKey(nameof(KPIEmailOpenedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KPIRedirectLinkClickedCount = group.Add(new VocabularyKey(nameof(KPIRedirectLinkClickedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KPIWebsiteClickedCount = group.Add(new VocabularyKey(nameof(KPIWebsiteClickedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KPIWebsiteVisitedCount = group.Add(new VocabularyKey(nameof(KPIWebsiteVisitedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KpiFormSubmittedCount = group.Add(new VocabularyKey(nameof(KpiFormSubmittedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NorthwestLatitude = group.Add(new VocabularyKey(nameof(NorthwestLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NorthwestLongitude = group.Add(new VocabularyKey(nameof(NorthwestLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestbuilderserviceMktgeopins = group.Add(new VocabularyKey(nameof(RequestbuilderserviceMktgeopins), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResultparserserviceMktgeopins = group.Add(new VocabularyKey(nameof(ResultparserserviceMktgeopins), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServerIdMarketing = group.Add(new VocabularyKey(nameof(ServerIdMarketing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SoutheastLatitude = group.Add(new VocabularyKey(nameof(SoutheastLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SoutheastLongitude = group.Add(new VocabularyKey(nameof(SoutheastLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CenterLatitude { get; private set; }
        public VocabularyKey CenterLongitude { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey GeoPinId { get; private set; }
        public VocabularyKey KPIEmailClickedCount { get; private set; }
        public VocabularyKey KPIEmailOpenedCount { get; private set; }
        public VocabularyKey KPIRedirectLinkClickedCount { get; private set; }
        public VocabularyKey KPIWebsiteClickedCount { get; private set; }
        public VocabularyKey KPIWebsiteVisitedCount { get; private set; }
        public VocabularyKey KpiFormSubmittedCount { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NorthwestLatitude { get; private set; }
        public VocabularyKey NorthwestLongitude { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey RequestbuilderserviceMktgeopins { get; private set; }
        public VocabularyKey ResultparserserviceMktgeopins { get; private set; }
        public VocabularyKey ServerIdMarketing { get; private set; }
        public VocabularyKey SoutheastLatitude { get; private set; }
        public VocabularyKey SoutheastLongitude { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}