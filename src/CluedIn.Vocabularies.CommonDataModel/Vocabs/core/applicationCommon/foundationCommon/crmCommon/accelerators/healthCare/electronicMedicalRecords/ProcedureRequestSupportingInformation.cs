using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureRequestSupportingInformationVocabulary : SimpleVocabulary
    {
        public ProcedureRequestSupportingInformationVocabulary()
        {
            VocabularyName = "Procedure Request Supporting Information";
            KeyPrefix = "commonDataModel.procedurerequestsupportinginformation.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureRequestSupportingInformation";

            AddGroup("ProcedureRequestSupportingInformation Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureRequestSupportingInformationId = group.Add(new VocabularyKey(nameof(ProcedureRequestSupportingInformationId), "Procedure Request Supporting Information", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SupportingInfo = group.Add(new VocabularyKey(nameof(SupportingInfo), "Supporting Info", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureRequestSupportingInformationId { get; private set; }
        public VocabularyKey SupportingInfo { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}