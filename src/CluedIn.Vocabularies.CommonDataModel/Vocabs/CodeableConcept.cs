using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CodeableConceptVocabulary : SimpleVocabulary
    {
        public CodeableConceptVocabulary()
        {
            VocabularyName = "CodeableConcept";
            KeyPrefix = "commonDataModel.codeableconcept";
            KeySeparator = ".";
            Grouping = "/CodeableConcept";

            AddGroup("CodeableConcept Details", group =>
            {
                codeableConceptId = group.Add(new VocabularyKey(nameof(codeableConceptId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                createdBy = group.Add(new VocabularyKey(nameof(createdBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                modifiedBy = group.Add(new VocabularyKey(nameof(modifiedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                organizationId = group.Add(new VocabularyKey(nameof(organizationId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                stateCode_display = group.Add(new VocabularyKey(nameof(stateCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                statusCode_display = group.Add(new VocabularyKey(nameof(statusCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                versionNumber = group.Add(new VocabularyKey(nameof(versionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                entityImageId = group.Add(new VocabularyKey(nameof(entityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                code = group.Add(new VocabularyKey(nameof(code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                text = group.Add(new VocabularyKey(nameof(text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                type = group.Add(new VocabularyKey(nameof(type), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                type_display = group.Add(new VocabularyKey(nameof(type_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey codeableConceptId { get; private set; }
        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey createdBy { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey modifiedBy { get; private set; }
        public VocabularyKey createdOnBehalfBy { get; private set; }
        public VocabularyKey modifiedOnBehalfBy { get; private set; }
        public VocabularyKey organizationId { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey stateCode_display { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey statusCode_display { get; private set; }
        public VocabularyKey versionNumber { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey entityImageId { get; private set; }
        public VocabularyKey code { get; private set; }
        public VocabularyKey text { get; private set; }
        public VocabularyKey type { get; private set; }
        public VocabularyKey type_display { get; private set; }


    }
}