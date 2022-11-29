using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationPackageContentVocabulary : SimpleVocabulary
    {
        public MedicationPackageContentVocabulary()
        {
            VocabularyName = "Medication Package Content";
            KeyPrefix = "commonDataModel.medicationpackagecontent.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationPackageContent";

            AddGroup("MedicationPackageContent Details for ElectronicMedicalRecords", group =>
            {
			    MedicationPackageContentId = group.Add(new VocabularyKey(nameof(MedicationPackageContentId), "Medication Package Content", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PackageContentAmount = group.Add(new VocabularyKey(nameof(PackageContentAmount), "Package Amount", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    PackageItemType = group.Add(new VocabularyKey(nameof(PackageItemType), "Package Item Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationPackageContentId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PackageContentAmount { get; private set; }
        public VocabularyKey PackageItemType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}