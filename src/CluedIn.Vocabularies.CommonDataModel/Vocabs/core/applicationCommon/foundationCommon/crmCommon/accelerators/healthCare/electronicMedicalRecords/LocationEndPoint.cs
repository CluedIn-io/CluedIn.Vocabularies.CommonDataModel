using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class LocationEndPointVocabulary : SimpleVocabulary
    {
        public LocationEndPointVocabulary()
        {
            VocabularyName = "Location End Point";
            KeyPrefix = "commonDataModel.locationendpoint.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/LocationEndPoint";

            AddGroup("LocationEndPoint Details for ElectronicMedicalRecords", group =>
            {
			    LocationEndPointId = group.Add(new VocabularyKey(nameof(LocationEndPointId), "Location End Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey LocationEndPointId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}