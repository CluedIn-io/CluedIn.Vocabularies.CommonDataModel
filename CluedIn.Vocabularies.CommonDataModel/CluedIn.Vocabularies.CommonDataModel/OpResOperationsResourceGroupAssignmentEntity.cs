using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OpResOperationsResourceGroupAssignmentEntityVocabulary : SimpleVocabulary
    {
        public OpResOperationsResourceGroupAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model OpResOperationsResourceGroupAssignmentEntity";
            KeyPrefix = "commonDataModel.opresoperationsresourcegroupassignmententity";
            KeySeparator = ".";
            Grouping = "/OpResOperationsResourceGroupAssignmentEntity";

            AddGroup("Common Data Model OpResOperationsResourceGroupAssignmentEntity Details", group =>
            {
                InputWarehouseId = group.Add(new VocabularyKey(nameof(InputWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InputWarehouseLocationId = group.Add(new VocabularyKey(nameof(InputWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationsResourceId = group.Add(new VocabularyKey(nameof(OperationsResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationsResourceGroupId = group.Add(new VocabularyKey(nameof(OperationsResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OutputWarehouseId = group.Add(new VocabularyKey(nameof(OutputWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OutputWarehouseLocationId = group.Add(new VocabularyKey(nameof(OutputWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey InputWarehouseId { get; private set; }
public VocabularyKey InputWarehouseLocationId { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }
public VocabularyKey OperationsResourceId { get; private set; }
public VocabularyKey OperationsResourceGroupId { get; private set; }
public VocabularyKey OutputWarehouseId { get; private set; }
public VocabularyKey OutputWarehouseLocationId { get; private set; }


    }
}