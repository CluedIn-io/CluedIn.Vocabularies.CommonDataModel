using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WrkCtrSiteSpecificOperationsResourceSchedulingParametersEntityVocabulary : SimpleVocabulary
    {
        public WrkCtrSiteSpecificOperationsResourceSchedulingParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model WrkCtrSiteSpecificOperationsResourceSchedulingParametersEntity";
            KeyPrefix = "commonDataModel.wrkctrsitespecificoperationsresourceschedulingparametersentity";
            KeySeparator = ".";
            Grouping = "/WrkCtrSiteSpecificOperationsResourceSchedulingParametersEntity";

            AddGroup("Common Data Model WrkCtrSiteSpecificOperationsResourceSchedulingParametersEntity Details", group =>
            {
                SiteId = group.Add(new VocabularyKey(nameof(SiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSchedulingSequenceTimeoutEnabled = group.Add(new VocabularyKey(nameof(IsSchedulingSequenceTimeoutEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SchedulingSequenceTimeoutSeconds = group.Add(new VocabularyKey(nameof(SchedulingSequenceTimeoutSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSchedulingOptimizationSequenceTimeoutEnabled = group.Add(new VocabularyKey(nameof(IsSchedulingOptimizationSequenceTimeoutEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SchedulingOptimizationSequenceTimeoutSeconds = group.Add(new VocabularyKey(nameof(SchedulingOptimizationSequenceTimeoutSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillReschedulingPreserveProductionUnit = group.Add(new VocabularyKey(nameof(WillReschedulingPreserveProductionUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillReschedulingPreserveWarehouse = group.Add(new VocabularyKey(nameof(WillReschedulingPreserveWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryOperationsResourceSelectionMethod = group.Add(new VocabularyKey(nameof(PrimaryOperationsResourceSelectionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SiteId { get; private set; }
public VocabularyKey IsSchedulingSequenceTimeoutEnabled { get; private set; }
public VocabularyKey SchedulingSequenceTimeoutSeconds { get; private set; }
public VocabularyKey IsSchedulingOptimizationSequenceTimeoutEnabled { get; private set; }
public VocabularyKey SchedulingOptimizationSequenceTimeoutSeconds { get; private set; }
public VocabularyKey WillReschedulingPreserveProductionUnit { get; private set; }
public VocabularyKey WillReschedulingPreserveWarehouse { get; private set; }
public VocabularyKey PrimaryOperationsResourceSelectionMethod { get; private set; }


    }
}