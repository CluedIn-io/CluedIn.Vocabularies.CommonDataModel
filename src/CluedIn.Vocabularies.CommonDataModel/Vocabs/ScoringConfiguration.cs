using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ScoringConfigurationVocabulary : SimpleVocabulary
    {
        public ScoringConfigurationVocabulary()
        {
            VocabularyName = "Common Data Model ScoringConfiguration";
            KeyPrefix = "commonDataModel.scoringconfiguration";
            KeySeparator = ".";
            Grouping = "/ScoringConfiguration";

            AddGroup("Common Data Model ScoringConfiguration Details", group =>
            {
                automaticleadscorescleanupEnabled = group.Add(new VocabularyKey(nameof(automaticleadscorescleanupEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
automaticqualificationEnabled = group.Add(new VocabularyKey(nameof(automaticqualificationEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
automaticSalesreadyEnabled = group.Add(new VocabularyKey(nameof(automaticSalesreadyEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
leadscoringconfigurationId = group.Add(new VocabularyKey(nameof(leadscoringconfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey automaticleadscorescleanupEnabled { get; private set; }
public VocabularyKey automaticqualificationEnabled { get; private set; }
public VocabularyKey automaticSalesreadyEnabled { get; private set; }
public VocabularyKey leadscoringconfigurationId { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey createdOn { get; private set; }
public VocabularyKey createdOnBehalfBy { get; private set; }
public VocabularyKey importSequenceNumber { get; private set; }
public VocabularyKey modifiedOn { get; private set; }
public VocabularyKey modifiedOnBehalfBy { get; private set; }
public VocabularyKey overriddenCreatedOn { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
public VocabularyKey UTCConversionTimeZoneCode { get; private set; }


    }
}