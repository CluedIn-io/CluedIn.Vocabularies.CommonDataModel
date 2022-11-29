using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanAuthorVocabulary : SimpleVocabulary
    {
        public CarePlanAuthorVocabulary()
        {
            VocabularyName = "Care Plan Author";
            KeyPrefix = "commonDataModel.careplanauthor.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanAuthor";

            AddGroup("CarePlanAuthor Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanAuthorId = group.Add(new VocabularyKey(nameof(CarePlanAuthorId), "Care Plan Author", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanAuthorType = group.Add(new VocabularyKey(nameof(PlanAuthorType), "Author Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanAuthorId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PlanAuthorType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}