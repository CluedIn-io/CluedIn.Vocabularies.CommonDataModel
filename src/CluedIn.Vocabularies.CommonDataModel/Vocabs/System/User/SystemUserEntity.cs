using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemUserEntityVocabulary : SimpleVocabulary
    {
        public SystemUserEntityVocabulary()
        {
            VocabularyName = "Common Data Model SystemUserEntity";
            KeyPrefix = "commonDataModel.systemuserentity";
            KeySeparator = ".";
            Grouping = "/SystemUserEntity";

            AddGroup("Common Data Model SystemUserEntity Details", group =>
            {
                DefaultCountryRegion = group.Add(new VocabularyKey(nameof(DefaultCountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentHandlingActive = group.Add(new VocabularyKey(nameof(DocumentHandlingActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShowAttachmentStatus = group.Add(new VocabularyKey(nameof(ShowAttachmentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Email = group.Add(new VocabularyKey(nameof(Email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SendAlertAsEmailMessage = group.Add(new VocabularyKey(nameof(SendAlertAsEmailMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EventPollFrequency = group.Add(new VocabularyKey(nameof(EventPollFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EventPopUpDisplayWhen = group.Add(new VocabularyKey(nameof(EventPopUpDisplayWhen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EventPopUpLinkDestination = group.Add(new VocabularyKey(nameof(EventPopUpLinkDestination), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EventPopUps = group.Add(new VocabularyKey(nameof(EventPopUps), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EventWorkflowShowPopup = group.Add(new VocabularyKey(nameof(EventWorkflowShowPopup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShowNotificationsInTheMicrosoftDynamicsAX7Client = group.Add(new VocabularyKey(nameof(ShowNotificationsInTheMicrosoftDynamicsAX7Client), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SendNotificationsInEmail = group.Add(new VocabularyKey(nameof(SendNotificationsInEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MarkEmptyLinks = group.Add(new VocabularyKey(nameof(MarkEmptyLinks), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserID = group.Add(new VocabularyKey(nameof(UserID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SqmEnabled = group.Add(new VocabularyKey(nameof(SqmEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SqmGUID = group.Add(new VocabularyKey(nameof(SqmGUID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkflowLineItemNotificationFormat = group.Add(new VocabularyKey(nameof(WorkflowLineItemNotificationFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Density = group.Add(new VocabularyKey(nameof(Density), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Theme = group.Add(new VocabularyKey(nameof(Theme), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartPage = group.Add(new VocabularyKey(nameof(StartPage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmailProviderID = group.Add(new VocabularyKey(nameof(EmailProviderID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserName = group.Add(new VocabularyKey(nameof(UserName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Enabled = group.Add(new VocabularyKey(nameof(Enabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AutoLogOff = group.Add(new VocabularyKey(nameof(AutoLogOff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SecurityIdentifier = group.Add(new VocabularyKey(nameof(SecurityIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NetworkDomain = group.Add(new VocabularyKey(nameof(NetworkDomain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Alias = group.Add(new VocabularyKey(nameof(Alias), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalUser = group.Add(new VocabularyKey(nameof(ExternalUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserInfo_language = group.Add(new VocabularyKey(nameof(UserInfo_language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Helplanguage = group.Add(new VocabularyKey(nameof(Helplanguage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreferredTimeZone = group.Add(new VocabularyKey(nameof(PreferredTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreferredCalendar = group.Add(new VocabularyKey(nameof(PreferredCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HomePageRefreshDuration = group.Add(new VocabularyKey(nameof(HomePageRefreshDuration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GlobalListPageLinkMode = group.Add(new VocabularyKey(nameof(GlobalListPageLinkMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GlobalExcelExportMode = group.Add(new VocabularyKey(nameof(GlobalExcelExportMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserInfo_defaultPartition = group.Add(new VocabularyKey(nameof(UserInfo_defaultPartition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GlobalExcelExportFilePath = group.Add(new VocabularyKey(nameof(GlobalExcelExportFilePath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreferredLocale = group.Add(new VocabularyKey(nameof(PreferredLocale), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonName = group.Add(new VocabularyKey(nameof(PersonName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AutomaticUrlUpdate = group.Add(new VocabularyKey(nameof(AutomaticUrlUpdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserObjectId = group.Add(new VocabularyKey(nameof(UserObjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DefaultCountryRegion { get; private set; }
public VocabularyKey DocumentHandlingActive { get; private set; }
public VocabularyKey ShowAttachmentStatus { get; private set; }
public VocabularyKey Email { get; private set; }
public VocabularyKey SendAlertAsEmailMessage { get; private set; }
public VocabularyKey EventPollFrequency { get; private set; }
public VocabularyKey EventPopUpDisplayWhen { get; private set; }
public VocabularyKey EventPopUpLinkDestination { get; private set; }
public VocabularyKey EventPopUps { get; private set; }
public VocabularyKey EventWorkflowShowPopup { get; private set; }
public VocabularyKey ShowNotificationsInTheMicrosoftDynamicsAX7Client { get; private set; }
public VocabularyKey SendNotificationsInEmail { get; private set; }
public VocabularyKey MarkEmptyLinks { get; private set; }
public VocabularyKey UserID { get; private set; }
public VocabularyKey Language { get; private set; }
public VocabularyKey SqmEnabled { get; private set; }
public VocabularyKey SqmGUID { get; private set; }
public VocabularyKey WorkflowLineItemNotificationFormat { get; private set; }
public VocabularyKey Density { get; private set; }
public VocabularyKey Theme { get; private set; }
public VocabularyKey StartPage { get; private set; }
public VocabularyKey EmailProviderID { get; private set; }
public VocabularyKey UserName { get; private set; }
public VocabularyKey Enabled { get; private set; }
public VocabularyKey Company { get; private set; }
public VocabularyKey AutoLogOff { get; private set; }
public VocabularyKey SecurityIdentifier { get; private set; }
public VocabularyKey NetworkDomain { get; private set; }
public VocabularyKey Alias { get; private set; }
public VocabularyKey ExternalUser { get; private set; }
public VocabularyKey UserInfo_language { get; private set; }
public VocabularyKey Helplanguage { get; private set; }
public VocabularyKey PreferredTimeZone { get; private set; }
public VocabularyKey PreferredCalendar { get; private set; }
public VocabularyKey HomePageRefreshDuration { get; private set; }
public VocabularyKey GlobalListPageLinkMode { get; private set; }
public VocabularyKey GlobalExcelExportMode { get; private set; }
public VocabularyKey UserInfo_defaultPartition { get; private set; }
public VocabularyKey GlobalExcelExportFilePath { get; private set; }
public VocabularyKey PreferredLocale { get; private set; }
public VocabularyKey AccountType { get; private set; }
public VocabularyKey PersonName { get; private set; }
public VocabularyKey AutomaticUrlUpdate { get; private set; }
public VocabularyKey UserObjectId { get; private set; }


    }
}