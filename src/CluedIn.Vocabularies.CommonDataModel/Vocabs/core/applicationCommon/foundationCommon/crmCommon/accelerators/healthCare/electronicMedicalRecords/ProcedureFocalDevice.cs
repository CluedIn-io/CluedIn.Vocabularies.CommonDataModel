using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ProcedureFocalDeviceVocabulary : SimpleVocabulary
    {
        public ProcedureFocalDeviceVocabulary()
        {
            VocabularyName = "Procedure Focal Device";
            KeyPrefix = "commonDataModel.procedurefocaldevice.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ProcedureFocalDevice";

            AddGroup("ProcedureFocalDevice Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcedureFocalDeviceId = group.Add(new VocabularyKey(nameof(ProcedureFocalDeviceId), "Procedure Focal Device", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcedureFocalDeviceId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}