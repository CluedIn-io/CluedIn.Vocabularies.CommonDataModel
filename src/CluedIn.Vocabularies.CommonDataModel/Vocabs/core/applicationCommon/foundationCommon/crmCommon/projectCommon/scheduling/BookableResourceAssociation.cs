using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class BookableResourceAssociationVocabulary : SimpleVocabulary
    {
        public BookableResourceAssociationVocabulary()
        {
            VocabularyName = "Bookable Resource Association";
            KeyPrefix = "commonDataModel.bookableresourceassociation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.BookableResourceAssociation;

            AddGroup("BookableResourceAssociation Details for Scheduling", group =>
            {
			    BookableresourceassociationId = group.Add(new VocabularyKey(nameof(BookableresourceassociationId), "Bookable Resource Association", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FromDate = group.Add(new VocabularyKey(nameof(FromDate), "From Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ToDate = group.Add(new VocabularyKey(nameof(ToDate), "To Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Resource1"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="Resource2"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey BookableresourceassociationId { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}