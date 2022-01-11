using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EpisodeOfCareVocabulary : SimpleVocabulary
    {
        public EpisodeOfCareVocabulary()
        {
            VocabularyName = "Common Data Model EpisodeOfCare";
            KeyPrefix = "commonDataModel.episodeofcare";
            KeySeparator = ".";
            Grouping = "/EpisodeOfCare";

            AddGroup("Common Data Model EpisodeOfCare Details", group =>
            {
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)); 
createdBy = group.Add(new VocabularyKey(nameof(createdBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)); 
modifiedBy = group.Add(new VocabularyKey(nameof(modifiedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
ownerId = group.Add(new VocabularyKey(nameof(ownerId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
owningBusinessUnit = group.Add(new VocabularyKey(nameof(owningBusinessUnit), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
owningUser = group.Add(new VocabularyKey(nameof(owningUser), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
owningTeam = group.Add(new VocabularyKey(nameof(owningTeam), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
versionNumber = group.Add(new VocabularyKey(nameof(versionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
episodeOfCareId = group.Add(new VocabularyKey(nameof(episodeOfCareId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
stateCode_display = group.Add(new VocabularyKey(nameof(stateCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
statusCode_display = group.Add(new VocabularyKey(nameof(statusCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
careManager = group.Add(new VocabularyKey(nameof(careManager), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
endDateTime = group.Add(new VocabularyKey(nameof(endDateTime), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)); 
identifier = group.Add(new VocabularyKey(nameof(identifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
organization = group.Add(new VocabularyKey(nameof(organization), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
patient = group.Add(new VocabularyKey(nameof(patient), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
startDateTime = group.Add(new VocabularyKey(nameof(startDateTime), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible)); 
status = group.Add(new VocabularyKey(nameof(status), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
status_display = group.Add(new VocabularyKey(nameof(status_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey createdOn { get; private set; }
public VocabularyKey createdBy { get; private set; }
public VocabularyKey modifiedOn { get; private set; }
public VocabularyKey modifiedBy { get; private set; }
public VocabularyKey createdOnBehalfBy { get; private set; }
public VocabularyKey modifiedOnBehalfBy { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey importSequenceNumber { get; private set; }
public VocabularyKey ownerId { get; private set; }
public VocabularyKey ownerIdType { get; private set; }
public VocabularyKey owningBusinessUnit { get; private set; }
public VocabularyKey owningUser { get; private set; }
public VocabularyKey owningTeam { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
public VocabularyKey versionNumber { get; private set; }
public VocabularyKey episodeOfCareId { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey stateCode_display { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey statusCode_display { get; private set; }
public VocabularyKey description { get; private set; }
public VocabularyKey careManager { get; private set; }
public VocabularyKey endDateTime { get; private set; }
public VocabularyKey identifier { get; private set; }
public VocabularyKey organization { get; private set; }
public VocabularyKey patient { get; private set; }
public VocabularyKey startDateTime { get; private set; }
public VocabularyKey status { get; private set; }
public VocabularyKey status_display { get; private set; }


    }
}