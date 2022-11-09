using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OpResOperationsResourceCapabilityAssignmentEntityVocabulary : SimpleVocabulary
    {
        public OpResOperationsResourceCapabilityAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model OpResOperationsResourceCapabilityAssignmentEntity";
            KeyPrefix = "commonDataModel.opresoperationsresourcecapabilityassignmententity";
            KeySeparator = ".";
            Grouping = "/OpResOperationsResourceCapabilityAssignmentEntity";

            AddGroup("Common Data Model OpResOperationsResourceCapabilityAssignmentEntity Details", group =>
            {
                OperationsResourceCapabilityName = group.Add(new VocabularyKey(nameof(OperationsResourceCapabilityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Level = group.Add(new VocabularyKey(nameof(Level), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationsResourceId = group.Add(new VocabularyKey(nameof(OperationsResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationsResourceLegalEntityId = group.Add(new VocabularyKey(nameof(OperationsResourceLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey OperationsResourceCapabilityName { get; private set; }
public VocabularyKey Level { get; private set; }
public VocabularyKey Priority { get; private set; }
public VocabularyKey OperationsResourceId { get; private set; }
public VocabularyKey OperationsResourceLegalEntityId { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }


    }
}