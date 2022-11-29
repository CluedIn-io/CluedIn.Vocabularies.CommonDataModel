using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class RequestGroupActionConditionVocabulary : SimpleVocabulary
    {
        public RequestGroupActionConditionVocabulary()
        {
            VocabularyName = "Request Group Action Condition";
            KeyPrefix = "commonDataModel.requestgroupactioncondition.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/RequestGroupActionCondition";

            AddGroup("RequestGroupActionCondition Details for ElectronicMedicalRecords", group =>
            {
			    ActionConditionDescription = group.Add(new VocabularyKey(nameof(ActionConditionDescription), "Action Condition Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionConditionExpression = group.Add(new VocabularyKey(nameof(ActionConditionExpression), "Action Condition Expression", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionConditionKind = group.Add(new VocabularyKey(nameof(ActionConditionKind), "Action Condition Kind", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionConditionLanguage = group.Add(new VocabularyKey(nameof(ActionConditionLanguage), "Action Condition Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestGroupActionConditionId = group.Add(new VocabularyKey(nameof(RequestGroupActionConditionId), "Request Group Action Condition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ActionConditionDescription { get; private set; }
        public VocabularyKey ActionConditionExpression { get; private set; }
        public VocabularyKey ActionConditionKind { get; private set; }
        public VocabularyKey ActionConditionLanguage { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequestGroupActionConditionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}