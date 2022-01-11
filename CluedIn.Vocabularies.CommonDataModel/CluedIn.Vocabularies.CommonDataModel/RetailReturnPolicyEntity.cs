using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailReturnPolicyEntityVocabulary : SimpleVocabulary
    {
        public RetailReturnPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailReturnPolicyEntity";
            KeyPrefix = "commonDataModel.retailreturnpolicyentity";
            KeySeparator = ".";
            Grouping = "/RetailReturnPolicyEntity";

            AddGroup("Common Data Model RetailReturnPolicyEntity Details", group =>
            {
                BlockInDefaultReturnLocation = group.Add(new VocabularyKey(nameof(BlockInDefaultReturnLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyNumber = group.Add(new VocabularyKey(nameof(PolicyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PolicyPrintLabels = group.Add(new VocabularyKey(nameof(PolicyPrintLabels), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BlockInDefaultReturnLocation { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey PolicyNumber { get; private set; }
public VocabularyKey PolicyPrintLabels { get; private set; }


    }
}