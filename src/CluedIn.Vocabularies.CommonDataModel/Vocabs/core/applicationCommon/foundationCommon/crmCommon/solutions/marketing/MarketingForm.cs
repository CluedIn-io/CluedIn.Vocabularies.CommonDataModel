using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class MarketingFormVocabulary : SimpleVocabulary
    {
        public MarketingFormVocabulary()
        {
            VocabularyName = "Marketing Form";
            KeyPrefix = "commonDataModel.marketingform";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.MarketingForm;

            AddGroup("MarketingForm Details for Marketing", group =>
            {
                MarketingFormId = group.Add(new VocabularyKey(nameof(MarketingFormId), "Marketing form", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowPrefill = group.Add(new VocabularyKey(nameof(AllowPrefill), "Prefill fields", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ContactMatchingStrategy = group.Add(new VocabularyKey(nameof(ContactMatchingStrategy), "Contact matching strategy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpdateContactsLeads = group.Add(new VocabularyKey(nameof(UpdateContactsLeads), "Update contacts/leads", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingFormTemplate = group.Add(new VocabularyKey(nameof(MarketingFormTemplate), "Marketing form template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormControlMapping = group.Add(new VocabularyKey(nameof(FormControlMapping), "Form control mapping", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormDefinition = group.Add(new VocabularyKey(nameof(FormDefinition), "Form definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), "Insights", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadMatchingStrategy = group.Add(new VocabularyKey(nameof(LeadMatchingStrategy), "Lead matching strategy", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidForPageType = group.Add(new VocabularyKey(nameof(ValidForPageType), "Form type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Purpose = group.Add(new VocabularyKey(nameof(Purpose), "Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VisualStyle = group.Add(new VocabularyKey(nameof(VisualStyle), "Visual style", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="MarketingFormId"/> from Vocab 'Contact.cdm.json/Contact' with Property 'SourceForm'
            ///Property <see cref="MarketingFormId"/> from Vocab 'FormPage.cdm.json/FormPage' with Property 'MarketingFormId'
            ///Property <see cref="MarketingFormId"/> from Vocab 'GeoPin.cdm.json/GeoPin' with Property 'MarketingformGeoPinsId'
            ///Property <see cref="MarketingFormId"/> from Vocab 'Lead.cdm.json/Lead' with Property 'SourceForm'
            ///Property <see cref="MarketingFormId"/> from Vocab 'ListForm.cdm.json/ListForm' with Property 'FormId'
            #endregion
        }

        public VocabularyKey AllowPrefill { get; private set; }
        public VocabularyKey ContactMatchingStrategy { get; private set; }
        public VocabularyKey FormControlMapping { get; private set; }
        public VocabularyKey FormDefinition { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey LeadMatchingStrategy { get; private set; }
        public VocabularyKey MarketingFormId { get; private set; }
        public VocabularyKey MarketingFormTemplate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey UpdateContactsLeads { get; private set; }
        public VocabularyKey ValidForPageType { get; private set; }
        public VocabularyKey VisualStyle { get; private set; }
    }
}