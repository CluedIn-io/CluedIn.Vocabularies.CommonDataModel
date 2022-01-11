using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerJourneyIterationVocabulary : SimpleVocabulary
    {
        public CustomerJourneyIterationVocabulary()
        {
            VocabularyName = "Common Data Model CustomerJourneyIteration";
            KeyPrefix = "commonDataModel.customerjourneyiteration";
            KeySeparator = ".";
            Grouping = "/CustomerJourneyIteration";

            AddGroup("Common Data Model CustomerJourneyIteration Details", group =>
            {
                customerJourneyId = group.Add(new VocabularyKey(nameof(customerJourneyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
customerJourneyIterationId = group.Add(new VocabularyKey(nameof(customerJourneyIterationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
designerState = group.Add(new VocabularyKey(nameof(designerState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
endDate = group.Add(new VocabularyKey(nameof(endDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
iterationNumber = group.Add(new VocabularyKey(nameof(iterationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
startDate = group.Add(new VocabularyKey(nameof(startDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
workflowDefinition = group.Add(new VocabularyKey(nameof(workflowDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey customerJourneyId { get; private set; }
public VocabularyKey customerJourneyIterationId { get; private set; }
public VocabularyKey designerState { get; private set; }
public VocabularyKey endDate { get; private set; }
public VocabularyKey iterationNumber { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey startDate { get; private set; }
public VocabularyKey workflowDefinition { get; private set; }
public VocabularyKey ownerIdName { get; private set; }
public VocabularyKey ownerIdType { get; private set; }
public VocabularyKey ownerIdYomiName { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}