using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectCommon
{
    public class BookingStatusVocabulary : SimpleVocabulary
    {
        public BookingStatusVocabulary()
        {
            VocabularyName = "Booking Status";
            KeyPrefix = "commonDataModel.bookingstatus.projectcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.BookingStatus;

            AddGroup("BookingStatus Details for ProjectCommon", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImageURL = group.Add(new VocabularyKey(nameof(ImageURL), "Image Url", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    StatusColor = group.Add(new VocabularyKey(nameof(StatusColor), "Status Color", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommitType = group.Add(new VocabularyKey(nameof(CommitType), "Commit Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="BookingStatusId"/> from Vocab 'BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'BookingStatus'
            ///Property <see cref="BookingStatusId"/> from Vocab 'BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'BookingStatusId'
            ///Property <see cref="BookingStatusId"/> from Vocab '/core/applicationCommon/foundationCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'BookingStatus'
            ///Property <see cref="BookingStatusId"/> from Vocab 'projectServiceAutomation/ResourceAssignment.cdm.json/ResourceAssignment' with Property 'BookingStatusId'
            ///Property <see cref="BookingStatusId"/> from Vocab 'scheduling/BookingSetupMetadata.cdm.json/BookingSetupMetadata' with Property 'DefaultBookingCanceledStatus'
            ///Property <see cref="BookingStatusId"/> from Vocab 'scheduling/BookingSetupMetadata.cdm.json/BookingSetupMetadata' with Property 'DefaultBookingCommittedStatus'
            #endregion
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey ImageURL { get; private set; }
        public VocabularyKey StatusColor { get; private set; }
        public VocabularyKey CommitType { get; private set; }
    }
}