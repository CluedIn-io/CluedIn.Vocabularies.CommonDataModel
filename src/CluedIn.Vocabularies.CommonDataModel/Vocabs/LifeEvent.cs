using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LifeEventVocabulary : SimpleVocabulary
    {
        public LifeEventVocabulary()
        {
            VocabularyName = "Common Data Model LifeEvent";
            KeyPrefix = "commonDataModel.lifeevent";
            KeySeparator = ".";
            Grouping = "/LifeEvent";

            AddGroup("Common Data Model LifeEvent Details", group =>
            {
                lifemomentId = group.Add(new VocabularyKey(nameof(lifemomentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lifeMomentCategory = group.Add(new VocabularyKey(nameof(lifeMomentCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lifemomentdate = group.Add(new VocabularyKey(nameof(lifemomentdate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lifemomenttitle = group.Add(new VocabularyKey(nameof(lifemomenttitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
lifeMomentType = group.Add(new VocabularyKey(nameof(lifeMomentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
msfsiModifiedOn = group.Add(new VocabularyKey(nameof(msfsiModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey lifemomentId { get; private set; }
public VocabularyKey createdOn { get; private set; }
public VocabularyKey modifiedOn { get; private set; }
public VocabularyKey statecode { get; private set; }
public VocabularyKey statuscode { get; private set; }
public VocabularyKey importSequenceNumber { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey lifeMomentCategory { get; private set; }
public VocabularyKey lifemomentdate { get; private set; }
public VocabularyKey lifemomenttitle { get; private set; }
public VocabularyKey lifeMomentType { get; private set; }
public VocabularyKey msfsiModifiedOn { get; private set; }


    }
}