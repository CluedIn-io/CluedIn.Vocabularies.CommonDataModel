using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPersonalContactPersonEntityVocabulary : SimpleVocabulary
    {
        public HcmPersonalContactPersonEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmPersonalContactPersonEntity";
            KeyPrefix = "commonDataModel.hcmpersonalcontactpersonentity";
            KeySeparator = ".";
            Grouping = "/HcmPersonalContactPersonEntity";

            AddGroup("Common Data Model HcmPersonalContactPersonEntity Details", group =>
            {
                WorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPersonPartyNumber = group.Add(new VocabularyKey(nameof(ContactPersonPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RelationshipType = group.Add(new VocabularyKey(nameof(RelationshipType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactFirstName = group.Add(new VocabularyKey(nameof(ContactFirstName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactMiddleName = group.Add(new VocabularyKey(nameof(ContactMiddleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactLastNamePrefix = group.Add(new VocabularyKey(nameof(ContactLastNamePrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactLastName = group.Add(new VocabularyKey(nameof(ContactLastName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsBeneficiary = group.Add(new VocabularyKey(nameof(IsBeneficiary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsEmergencyContact = group.Add(new VocabularyKey(nameof(IsEmergencyContact), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmergencyContactPrimarySecondary = group.Add(new VocabularyKey(nameof(EmergencyContactPrimarySecondary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDependent = group.Add(new VocabularyKey(nameof(IsDependent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDependentCourtOrdered = group.Add(new VocabularyKey(nameof(IsDependentCourtOrdered), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDependentDomesticPartnerVerified = group.Add(new VocabularyKey(nameof(IsDependentDomesticPartnerVerified), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DependentCourtOrderedExpirationDate = group.Add(new VocabularyKey(nameof(DependentCourtOrderedExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Gender = group.Add(new VocabularyKey(nameof(Gender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BirthDate = group.Add(new VocabularyKey(nameof(BirthDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsFulltimeStudent = group.Add(new VocabularyKey(nameof(IsFulltimeStudent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDisabled = group.Add(new VocabularyKey(nameof(IsDisabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisabledVerificationDate = group.Add(new VocabularyKey(nameof(DisabledVerificationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactName = group.Add(new VocabularyKey(nameof(ContactName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPartyType = group.Add(new VocabularyKey(nameof(ContactPartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DependentPersonalContactRelationship = group.Add(new VocabularyKey(nameof(DependentPersonalContactRelationship), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmergencyContactPersonalContactRelationship = group.Add(new VocabularyKey(nameof(EmergencyContactPersonalContactRelationship), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WorkerPersonnelNumber { get; private set; }
public VocabularyKey ContactPersonPartyNumber { get; private set; }
public VocabularyKey RelationshipType { get; private set; }
public VocabularyKey ContactFirstName { get; private set; }
public VocabularyKey ContactMiddleName { get; private set; }
public VocabularyKey ContactLastNamePrefix { get; private set; }
public VocabularyKey ContactLastName { get; private set; }
public VocabularyKey IsBeneficiary { get; private set; }
public VocabularyKey IsEmergencyContact { get; private set; }
public VocabularyKey EmergencyContactPrimarySecondary { get; private set; }
public VocabularyKey IsDependent { get; private set; }
public VocabularyKey IsDependentCourtOrdered { get; private set; }
public VocabularyKey IsDependentDomesticPartnerVerified { get; private set; }
public VocabularyKey DependentCourtOrderedExpirationDate { get; private set; }
public VocabularyKey Gender { get; private set; }
public VocabularyKey BirthDate { get; private set; }
public VocabularyKey IsFulltimeStudent { get; private set; }
public VocabularyKey IsDisabled { get; private set; }
public VocabularyKey DisabledVerificationDate { get; private set; }
public VocabularyKey ContactName { get; private set; }
public VocabularyKey ContactPartyType { get; private set; }
public VocabularyKey DependentPersonalContactRelationship { get; private set; }
public VocabularyKey EmergencyContactPersonalContactRelationship { get; private set; }


    }
}