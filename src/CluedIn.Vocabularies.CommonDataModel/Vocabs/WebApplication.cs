using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WebApplicationVocabulary : SimpleVocabulary
    {
        public WebApplicationVocabulary()
        {
            VocabularyName = "Common Data Model WebApplication";
            KeyPrefix = "commonDataModel.webapplication";
            KeySeparator = ".";
            Grouping = "/WebApplication";

            AddGroup("Common Data Model WebApplication Details", group =>
            {
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AADClientID = group.Add(new VocabularyKey(nameof(AADClientID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AADMetadataEndpoint = group.Add(new VocabularyKey(nameof(AADMetadataEndpoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                origin = group.Add(new VocabularyKey(nameof(origin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                publicendpoint = group.Add(new VocabularyKey(nameof(publicendpoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                token = group.Add(new VocabularyKey(nameof(token), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                userAuthenticationType = group.Add(new VocabularyKey(nameof(userAuthenticationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                webApplicationId = group.Add(new VocabularyKey(nameof(webApplicationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey createdOnBehalfBy { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey modifiedOnBehalfBy { get; private set; }
        public VocabularyKey AADClientID { get; private set; }
        public VocabularyKey AADMetadataEndpoint { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey origin { get; private set; }
        public VocabularyKey publicendpoint { get; private set; }
        public VocabularyKey token { get; private set; }
        public VocabularyKey userAuthenticationType { get; private set; }
        public VocabularyKey webApplicationId { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }


    }
}