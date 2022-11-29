using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class SpecimenContainerVocabulary : SimpleVocabulary
    {
        public SpecimenContainerVocabulary()
        {
            VocabularyName = "Specimen Container";
            KeyPrefix = "commonDataModel.specimencontainer.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/SpecimenContainer";

            AddGroup("SpecimenContainer Details for ElectronicMedicalRecords", group =>
            {
			    ContainerAdditiveType = group.Add(new VocabularyKey(nameof(ContainerAdditiveType), "Container Additive Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContainerCapacity = group.Add(new VocabularyKey(nameof(ContainerCapacity), "Container Capacity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ContainerDescription = group.Add(new VocabularyKey(nameof(ContainerDescription), "Container Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContainerNumber = group.Add(new VocabularyKey(nameof(ContainerNumber), "Container Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContainerSpecimenQuantity = group.Add(new VocabularyKey(nameof(ContainerSpecimenQuantity), "Specimen Quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SpecimenContainerId = group.Add(new VocabularyKey(nameof(SpecimenContainerId), "Specimen Container", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ContainerAdditiveType { get; private set; }
        public VocabularyKey ContainerCapacity { get; private set; }
        public VocabularyKey ContainerDescription { get; private set; }
        public VocabularyKey ContainerNumber { get; private set; }
        public VocabularyKey ContainerSpecimenQuantity { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SpecimenContainerId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}