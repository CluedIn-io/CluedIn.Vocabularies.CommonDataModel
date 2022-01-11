using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmCompensationPerformancePlansEntityVocabulary : SimpleVocabulary
    {
        public HcmCompensationPerformancePlansEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmCompensationPerformancePlansEntity";
            KeyPrefix = "commonDataModel.hcmcompensationperformanceplansentity";
            KeySeparator = ".";
            Grouping = "/HcmCompensationPerformancePlansEntity";

            AddGroup("Common Data Model HcmCompensationPerformancePlansEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Plan = group.Add(new VocabularyKey(nameof(Plan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Effective = group.Add(new VocabularyKey(nameof(Effective), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Expiration = group.Add(new VocabularyKey(nameof(Expiration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey Plan { get; private set; }
public VocabularyKey Effective { get; private set; }
public VocabularyKey Expiration { get; private set; }


    }
}