using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmJobFunctionEntityVocabulary : SimpleVocabulary
    {
        public HcmJobFunctionEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmJobFunctionEntity";
            KeyPrefix = "commonDataModel.hcmjobfunctionentity";
            KeySeparator = ".";
            Grouping = "/HcmJobFunctionEntity";

            AddGroup("Common Data Model HcmJobFunctionEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobFunctionId = group.Add(new VocabularyKey(nameof(JobFunctionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey JobFunctionId { get; private set; }


    }
}