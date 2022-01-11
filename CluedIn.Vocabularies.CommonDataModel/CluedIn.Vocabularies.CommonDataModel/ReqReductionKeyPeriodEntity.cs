using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqReductionKeyPeriodEntityVocabulary : SimpleVocabulary
    {
        public ReqReductionKeyPeriodEntityVocabulary()
        {
            VocabularyName = "Common Data Model ReqReductionKeyPeriodEntity";
            KeyPrefix = "commonDataModel.reqreductionkeyperiodentity";
            KeySeparator = ".";
            Grouping = "/ReqReductionKeyPeriodEntity";

            AddGroup("Common Data Model ReqReductionKeyPeriodEntity Details", group =>
            {
                IncrementalTimeChange = group.Add(new VocabularyKey(nameof(IncrementalTimeChange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TimeUnit = group.Add(new VocabularyKey(nameof(TimeUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReductionKeyId = group.Add(new VocabularyKey(nameof(ReductionKeyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReductionPercentage = group.Add(new VocabularyKey(nameof(ReductionPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IncrementalTimeChange { get; private set; }
public VocabularyKey TimeUnit { get; private set; }
public VocabularyKey ReductionKeyId { get; private set; }
public VocabularyKey ReductionPercentage { get; private set; }


    }
}