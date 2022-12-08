using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Sales
{
    public class SalesLiteratureVocabulary : SimpleVocabulary
    {
        public SalesLiteratureVocabulary()
        {
            VocabularyName = "Sales Literature";
            KeyPrefix = "commonDataModel.salesliterature.sales";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.SalesLiterature;

            AddGroup("SalesLiterature Details for Sales", group =>
            {
			    SalesLiteratureId = group.Add(new VocabularyKey(nameof(SalesLiteratureId), "Sales Literature", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), "Expiration Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HasAttachments = group.Add(new VocabularyKey(nameof(HasAttachments), "Has Attachments", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsCustomerViewable = group.Add(new VocabularyKey(nameof(IsCustomerViewable), "Customer Viewable", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    KeyWords = group.Add(new VocabularyKey(nameof(KeyWords), "Key Words", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LiteratureTypeCode = group.Add(new VocabularyKey(nameof(LiteratureTypeCode), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectId = group.Add(new VocabularyKey(nameof(SubjectId), "Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CompetitorId"/> to Vocab 'Competitor.cdm.json/Competitor' with Property 'CompetitorId'
            ///Property <see cref="SalesLiteratureId"/> to Vocab 'SalesLiterature.cdm.json/SalesLiterature' with Property 'SalesLiteratureId'
            ///Property <see cref="ProductId"/> to Vocab '/core/applicationCommon/foundationCommon/Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="SalesLiteratureId"/> to Vocab 'SalesLiterature.cdm.json/SalesLiterature' with Property 'SalesLiteratureId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/foundationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="EmployeeContactId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="SalesLiteratureId"/> from Vocab 'CompetitorSalesLiterature.cdm.json/CompetitorSalesLiterature' with Property 'SalesLiteratureId'
            ///Property <see cref="SalesLiteratureId"/> from Vocab 'ProductSalesLiterature.cdm.json/ProductSalesLiterature' with Property 'SalesLiteratureId'
            ///Property <see cref="SalesLiteratureId"/> from Vocab 'SalesAttachment.cdm.json/SalesAttachment' with Property 'SalesLiteratureId'
            #endregion
        }

        public VocabularyKey SalesLiteratureId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey HasAttachments { get; private set; }
        public VocabularyKey IsCustomerViewable { get; private set; }
        public VocabularyKey KeyWords { get; private set; }
        public VocabularyKey LiteratureTypeCode { get; private set; }
        public VocabularyKey SubjectId { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}