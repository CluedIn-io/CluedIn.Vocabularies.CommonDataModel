using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanAddressesVocabulary : SimpleVocabulary
    {
        public CarePlanAddressesVocabulary()
        {
            VocabularyName = "Care Plan Addresses";
            KeyPrefix = "commonDataModel.careplanaddresses.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanAddresses";

            AddGroup("CarePlanAddresses Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanAddressesId = group.Add(new VocabularyKey(nameof(CarePlanAddressesId), "Care Plan Addresses", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanAddressesId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}