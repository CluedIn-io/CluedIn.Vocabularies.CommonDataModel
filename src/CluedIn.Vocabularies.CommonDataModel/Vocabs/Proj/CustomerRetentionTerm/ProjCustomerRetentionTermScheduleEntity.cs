using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCustomerRetentionTermScheduleEntityVocabulary : SimpleVocabulary
    {
        public ProjCustomerRetentionTermScheduleEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjCustomerRetentionTermScheduleEntity";
            KeyPrefix = "commonDataModel.projcustomerretentiontermscheduleentity";
            KeySeparator = ".";
            Grouping = "/ProjCustomerRetentionTermScheduleEntity";

            AddGroup("Common Data Model ProjCustomerRetentionTermScheduleEntity Details", group =>
            {
                PercentComplete = group.Add(new VocabularyKey(nameof(PercentComplete), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Release = group.Add(new VocabularyKey(nameof(Release), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PercentToRetain = group.Add(new VocabularyKey(nameof(PercentToRetain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetentionTerm = group.Add(new VocabularyKey(nameof(RetentionTerm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PercentComplete { get; private set; }
public VocabularyKey Release { get; private set; }
public VocabularyKey PercentToRetain { get; private set; }
public VocabularyKey RetentionTerm { get; private set; }


    }
}