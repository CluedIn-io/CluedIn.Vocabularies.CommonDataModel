using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class BusinessOperationVocabulary : SimpleVocabulary
    {
        public BusinessOperationVocabulary()
        {
            VocabularyName = "Business Operation";
            KeyPrefix = "commonDataModel.businessoperation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.BusinessOperation;

            AddGroup("BusinessOperation Details for Automotive", group =>
            {
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), "Address: City", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountry = group.Add(new VocabularyKey(nameof(AddressCountry), "Address: Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), "Address: County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), "Address: Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), "Address: Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressName = group.Add(new VocabularyKey(nameof(AddressName), "Address: Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressPostalCode = group.Add(new VocabularyKey(nameof(AddressPostalCode), "Address: ZIP/Postal Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStateProvince = group.Add(new VocabularyKey(nameof(AddressStateProvince), "Address: State/Province", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet1 = group.Add(new VocabularyKey(nameof(AddressStreet1), "Address: Street 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet2 = group.Add(new VocabularyKey(nameof(AddressStreet2), "Address: Street 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet3 = group.Add(new VocabularyKey(nameof(AddressStreet3), "Address: Street 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessOperationId = group.Add(new VocabularyKey(nameof(BusinessOperationId), "Business Operation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="FacilityId"/> to Vocab 'BusinessFacility.cdm.json/BusinessFacility' with Property 'BusinessFacilityId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="AccountId"/> to Vocab '/core/applicationCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="OperationTypeId"/> to Vocab 'OperationType.cdm.json/OperationType' with Property 'OperationTypeId'
            ///Property <see cref="BusinessOperationId"/> to Vocab 'BusinessOperation.cdm.json/BusinessOperation' with Property 'BusinessOperationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/Account.cdm.json/Account' with Property 'AccountId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="BusinessOperationId"/> from Vocab 'AggregateKPIContext.cdm.json/AggregateKPIContext' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'BusinessOperationCustomerPreference.cdm.json/BusinessOperationCustomerPreference' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'Deal.cdm.json/Deal' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'DealerPlate.cdm.json/DealerPlate' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'Device.cdm.json/Device' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'Fleet.cdm.json/Fleet' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'ServiceAppointment.cdm.json/ServiceAppointment' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'ServiceOrder.cdm.json/ServiceOrder' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'ServiceOrderJobDetail.cdm.json/ServiceOrderJobDetail' with Property 'BusinessOperationId'
            ///Property <see cref="BusinessOperationId"/> from Vocab 'TestDrive.cdm.json/TestDrive' with Property 'BusinessOperationId'
            #endregion
        }

        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressCountry { get; private set; }
        public VocabularyKey AddressCounty { get; private set; }
        public VocabularyKey AddressLatitude { get; private set; }
        public VocabularyKey AddressLongitude { get; private set; }
        public VocabularyKey AddressName { get; private set; }
        public VocabularyKey AddressPostalCode { get; private set; }
        public VocabularyKey AddressStateProvince { get; private set; }
        public VocabularyKey AddressStreet1 { get; private set; }
        public VocabularyKey AddressStreet2 { get; private set; }
        public VocabularyKey AddressStreet3 { get; private set; }
        public VocabularyKey BusinessOperationId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}