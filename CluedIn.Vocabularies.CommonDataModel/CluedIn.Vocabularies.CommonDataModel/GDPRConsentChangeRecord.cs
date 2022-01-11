using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class GDPRConsentChangeRecordVocabulary : SimpleVocabulary
    {
        public GDPRConsentChangeRecordVocabulary()
        {
            VocabularyName = "Common Data Model GDPRConsentChangeRecord";
            KeyPrefix = "commonDataModel.gdprconsentchangerecord";
            KeySeparator = ".";
            Grouping = "/GDPRConsentChangeRecord";

            AddGroup("Common Data Model GDPRConsentChangeRecord Details", group =>
            {
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GDPRConsentChangeRecordId = group.Add(new VocabularyKey(nameof(GDPRConsentChangeRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
value = group.Add(new VocabularyKey(nameof(value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
consentchangesource = group.Add(new VocabularyKey(nameof(consentchangesource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey createdOn { get; private set; }
public VocabularyKey createdOnBehalfBy { get; private set; }
public VocabularyKey importSequenceNumber { get; private set; }
public VocabularyKey modifiedOn { get; private set; }
public VocabularyKey modifiedOnBehalfBy { get; private set; }
public VocabularyKey GDPRConsentChangeRecordId { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey value { get; private set; }
public VocabularyKey consentchangesource { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }


    }
}