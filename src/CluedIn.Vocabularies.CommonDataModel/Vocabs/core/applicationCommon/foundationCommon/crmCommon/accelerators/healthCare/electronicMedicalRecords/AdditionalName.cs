using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class AdditionalNameVocabulary : SimpleVocabulary
    {
        public AdditionalNameVocabulary()
        {
            VocabularyName = "Additional Name";
            KeyPrefix = "commonDataModel.additionalname";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.AdditionalName;

            AddGroup("AdditionalName Details for ElectronicMedicalRecords", group =>
            {
			    AdditionalNameId = group.Add(new VocabularyKey(nameof(AdditionalNameId), "Additional Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "Name End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FamilyName = group.Add(new VocabularyKey(nameof(FamilyName), "Family Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FirstName = group.Add(new VocabularyKey(nameof(FirstName), "First Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MiddleName = group.Add(new VocabularyKey(nameof(MiddleName), "Middle Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NameUse = group.Add(new VocabularyKey(nameof(NameUse), "Use of Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Prefix = group.Add(new VocabularyKey(nameof(Prefix), "Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Name Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Suffix = group.Add(new VocabularyKey(nameof(Suffix), "Suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="PatientId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
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
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey AdditionalNameId { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey FamilyName { get; private set; }
        public VocabularyKey FirstName { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NameUse { get; private set; }
        public VocabularyKey Prefix { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Suffix { get; private set; }
    }
}