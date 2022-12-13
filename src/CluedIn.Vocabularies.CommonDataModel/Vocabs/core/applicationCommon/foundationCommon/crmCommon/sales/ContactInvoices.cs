using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ContactInvoicesVocabulary : SimpleVocabulary
    {
        public ContactInvoicesVocabulary()
        {
            VocabularyName = "Contact Invoices";
            KeyPrefix = "commonDataModel.contactinvoices";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ContactInvoices;

            AddGroup("ContactInvoices Details for Sales", group =>
            {
                ContactInvoiceId = group.Add(new VocabularyKey(nameof(ContactInvoiceId), "Unique identifier of the invoices for the contact.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="ContactId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="InvoiceId"/> to Vocab 'Invoice.cdm.json/Invoice' with Property 'InvoiceId'
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey ContactInvoiceId { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}