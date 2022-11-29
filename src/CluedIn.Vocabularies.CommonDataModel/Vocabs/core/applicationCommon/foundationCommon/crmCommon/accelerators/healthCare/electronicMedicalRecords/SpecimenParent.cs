using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class SpecimenParentVocabulary : SimpleVocabulary
    {
        public SpecimenParentVocabulary()
        {
            VocabularyName = "Specimen Parent";
            KeyPrefix = "commonDataModel.specimenparent.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/SpecimenParent";

            AddGroup("SpecimenParent Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SpecimenParentId = group.Add(new VocabularyKey(nameof(SpecimenParentId), "Specimen Parent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey SpecimenParentId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}