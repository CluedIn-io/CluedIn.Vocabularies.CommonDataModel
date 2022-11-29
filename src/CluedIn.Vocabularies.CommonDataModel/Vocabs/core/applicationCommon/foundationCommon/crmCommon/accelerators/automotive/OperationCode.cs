using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class OperationCodeVocabulary : SimpleVocabulary
    {
        public OperationCodeVocabulary()
        {
            VocabularyName = "Operation Code";
            KeyPrefix = "commonDataModel.operationcode.automotive";
            KeySeparator = ".";
            Grouping = "/OperationCode";

            AddGroup("OperationCode Details for Automotive", group =>
            {
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalCode = group.Add(new VocabularyKey(nameof(ExternalCode), "External Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OperationCodeId = group.Add(new VocabularyKey(nameof(OperationCodeId), "Operation Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StandardHours = group.Add(new VocabularyKey(nameof(StandardHours), "Standard Hours", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExternalCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OperationCodeId { get; private set; }
        public VocabularyKey StandardHours { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}