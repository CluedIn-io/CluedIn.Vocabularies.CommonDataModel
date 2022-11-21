using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WebApplicationVocabulary : SimpleVocabulary
    {
        public WebApplicationVocabulary()
        {
            VocabularyName = "Web Application";
            KeyPrefix = "commonDataModel.webapplication";
            KeySeparator = ".";
            Grouping = "/WebApplication";

            AddGroup("WebApplication Details", group =>
            {
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AADClientID = group.Add(new VocabularyKey(nameof(AADClientID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AADMetadataEndpoint = group.Add(new VocabularyKey(nameof(AADMetadataEndpoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Origin = group.Add(new VocabularyKey(nameof(Origin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Publicendpoint = group.Add(new VocabularyKey(nameof(Publicendpoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Token = group.Add(new VocabularyKey(nameof(Token), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserAuthenticationType = group.Add(new VocabularyKey(nameof(UserAuthenticationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebApplicationId = group.Add(new VocabularyKey(nameof(WebApplicationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey AADClientID { get; private set; }
        public VocabularyKey AADMetadataEndpoint { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Origin { get; private set; }
        public VocabularyKey Publicendpoint { get; private set; }
        public VocabularyKey Token { get; private set; }
        public VocabularyKey UserAuthenticationType { get; private set; }
        public VocabularyKey WebApplicationId { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}